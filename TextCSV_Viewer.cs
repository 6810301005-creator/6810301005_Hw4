using System;
using System.IO;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class frmTextView : Form
    {
        public frmTextView()
        {
            InitializeComponent();
        }

        // ==========================
        // TEXT TAB
        // ==========================
        private void btRead_Click(object sender, EventArgs e)
        {
            try
            {
                rtbShow.Clear();

                string[] lines = File.ReadAllLines(tbFileName.Text);

                int startRow = 1;
                int endRow = lines.Length;

                if (!string.IsNullOrWhiteSpace(tbStartRow.Text))
                    startRow = Convert.ToInt32(tbStartRow.Text);

                if (!string.IsNullOrWhiteSpace(tbEndRow.Text))
                    endRow = Convert.ToInt32(tbEndRow.Text);

                if (startRow < 1)
                    startRow = 1;

                if (endRow > lines.Length)
                    endRow = lines.Length;

                if (startRow > endRow)
                {
                    MessageBox.Show(
                        "Start Row ต้องน้อยกว่า End Row",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                for (int i = startRow - 1; i < endRow; i++)
                {
                    rtbShow.AppendText(lines[i] + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==========================
        // CSV TAB
        // ==========================
        private void btReadCSV_Click(object sender, EventArgs e)
        {
            try
            {
                dgvData.Rows.Clear();
                dgvData.Columns.Clear();

                int startRow = 1;
                int endRow = int.MaxValue;

                if (!string.IsNullOrWhiteSpace(tbStartRowCSV.Text))
                    startRow = Convert.ToInt32(tbStartRowCSV.Text);

                if (!string.IsNullOrWhiteSpace(tbEndRowCSV.Text))
                    endRow = Convert.ToInt32(tbEndRowCSV.Text);

                if (startRow < 1)
                    startRow = 1;

                if (startRow > endRow)
                {
                    MessageBox.Show(
                        "Start Row ต้องน้อยกว่า End Row",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string filterText =
                    tbFileNameCSV.Text.Trim().ToLower();

                using (StreamReader srReader =
                    new StreamReader(tbFileName.Text))
                {
                    string strLine;
                    bool headerRead = false;
                    int currentRow = 0;

                    while ((strLine = srReader.ReadLine()) != null)
                    {
                        if (strLine.StartsWith("#"))
                            continue;

                        string[] values = strLine.Split(',');

                        // Header
                        if (!headerRead)
                        {
                            foreach (string col in values)
                            {
                                dgvData.Columns.Add(
                                    col.Trim(),
                                    col.Trim());
                            }

                            headerRead = true;
                            continue;
                        }

                        currentRow++;

                        // Partial Loading
                        if (currentRow < startRow)
                            continue;

                        if (currentRow > endRow)
                            break;

                        // Filtering
                        if (!string.IsNullOrEmpty(filterText))
                        {
                            bool found = false;

                            foreach (string value in values)
                            {
                                if (value.ToLower()
                                    .Contains(filterText))
                                {
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                                continue;
                        }

                        dgvData.Rows.Add(values);
                    }
                }

                MessageBox.Show(
                    "Load Complete",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==========================
        // BROWSE FILE
        // ==========================
        private void btBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd =
                new OpenFileDialog())
            {
                ofd.Filter =
                    "Text Files (*.txt)|*.txt|" +
                    "CSV Files (*.csv)|*.csv|" +
                    "All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbFileName.Text = ofd.FileName;
                }
            }
        }

        // ==========================
        // EMPTY EVENTS
        // ==========================
        private void rtbShow_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void textBox4_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void tabpText_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label3_Click(
            object sender,
            EventArgs e)
        {
        }

        private void textBox3_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void label4_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label3_Click_1(
            object sender,
            EventArgs e)
        {
        }

        private void label2_Click(
            object sender,
            EventArgs e)
        {
        }

        private void tbEndRowCSV_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}