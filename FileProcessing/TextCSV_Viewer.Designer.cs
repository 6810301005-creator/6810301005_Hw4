namespace FileProcessing
{
	partial class frmTextView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabpText = new System.Windows.Forms.TabPage();
            this.txtFileName = new System.Windows.Forms.Label();
            this.txtEndRow = new System.Windows.Forms.Label();
            this.txtStartRow = new System.Windows.Forms.Label();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.tabpCSV = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA256_Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5_Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA1_Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReadCSV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbStartRow = new System.Windows.Forms.TextBox();
            this.tbEndRow = new System.Windows.Forms.TextBox();
            this.tbFilenam = new System.Windows.Forms.TextBox();
            this.txtStartRowCSV = new System.Windows.Forms.Label();
            this.txtEndRowCSV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStartRowCSV = new System.Windows.Forms.TextBox();
            this.tbEndRowCSV = new System.Windows.Forms.TextBox();
            this.tbFileNameCSV = new System.Windows.Forms.TextBox();
            this.tabcMain.SuspendLayout();
            this.tabpText.SuspendLayout();
            this.tabpCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(105, 13);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(910, 26);
            this.tbFileName.TabIndex = 1;
            this.tbFileName.Text = "D:\\YutData\\DistributedHome\\cdti.Code\\FileProcessing\\data\\malware_500.csv";
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(1053, 8);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(113, 33);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // tabcMain
            // 
            this.tabcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcMain.Controls.Add(this.tabpText);
            this.tabcMain.Controls.Add(this.tabpCSV);
            this.tabcMain.Location = new System.Drawing.Point(12, 48);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(1188, 1111);
            this.tabcMain.TabIndex = 3;
            // 
            // tabpText
            // 
            this.tabpText.Controls.Add(this.tbFilenam);
            this.tabpText.Controls.Add(this.tbEndRow);
            this.tabpText.Controls.Add(this.tbStartRow);
            this.tabpText.Controls.Add(this.txtFileName);
            this.tabpText.Controls.Add(this.txtEndRow);
            this.tabpText.Controls.Add(this.txtStartRow);
            this.tabpText.Controls.Add(this.rtbShow);
            this.tabpText.Controls.Add(this.btRead);
            this.tabpText.Location = new System.Drawing.Point(4, 29);
            this.tabpText.Name = "tabpText";
            this.tabpText.Padding = new System.Windows.Forms.Padding(3);
            this.tabpText.Size = new System.Drawing.Size(1180, 1078);
            this.tabpText.TabIndex = 0;
            this.tabpText.Text = "Text";
            this.tabpText.UseVisualStyleBackColor = true;
            this.tabpText.Click += new System.EventHandler(this.tabpText_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.AutoSize = true;
            this.txtFileName.Location = new System.Drawing.Point(586, 22);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(76, 20);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.Text = "FileName";
            this.txtFileName.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEndRow
            // 
            this.txtEndRow.AutoSize = true;
            this.txtEndRow.Location = new System.Drawing.Point(402, 22);
            this.txtEndRow.Name = "txtEndRow";
            this.txtEndRow.Size = new System.Drawing.Size(70, 20);
            this.txtEndRow.TabIndex = 3;
            this.txtEndRow.Text = "EndRow";
            this.txtEndRow.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtStartRow
            // 
            this.txtStartRow.AutoSize = true;
            this.txtStartRow.Location = new System.Drawing.Point(215, 25);
            this.txtStartRow.Name = "txtStartRow";
            this.txtStartRow.Size = new System.Drawing.Size(76, 20);
            this.txtStartRow.TabIndex = 2;
            this.txtStartRow.Text = "StartRow";
            // 
            // rtbShow
            // 
            this.rtbShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbShow.Location = new System.Drawing.Point(16, 134);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(1146, 938);
            this.rtbShow.TabIndex = 1;
            this.rtbShow.Text = "";
            this.rtbShow.WordWrap = false;
            this.rtbShow.TextChanged += new System.EventHandler(this.rtbShow_TextChanged);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(17, 16);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(115, 38);
            this.btRead.TabIndex = 0;
            this.btRead.Text = "read as text file";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // tabpCSV
            // 
            this.tabpCSV.Controls.Add(this.tbFileNameCSV);
            this.tabpCSV.Controls.Add(this.tbEndRowCSV);
            this.tabpCSV.Controls.Add(this.tbStartRowCSV);
            this.tabpCSV.Controls.Add(this.label4);
            this.tabpCSV.Controls.Add(this.txtEndRowCSV);
            this.tabpCSV.Controls.Add(this.txtStartRowCSV);
            this.tabpCSV.Controls.Add(this.dgvData);
            this.tabpCSV.Controls.Add(this.btReadCSV);
            this.tabpCSV.Location = new System.Drawing.Point(4, 29);
            this.tabpCSV.Name = "tabpCSV";
            this.tabpCSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCSV.Size = new System.Drawing.Size(1180, 1078);
            this.tabpCSV.TabIndex = 1;
            this.tabpCSV.Text = "CSV";
            this.tabpCSV.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegisterDate,
            this.SHA256_Hash,
            this.MD5_Hash,
            this.SHA1_Hash});
            this.dgvData.Location = new System.Drawing.Point(25, 131);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(1133, 929);
            this.dgvData.TabIndex = 1;
            // 
            // RegisterDate
            // 
            this.RegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RegisterDate.HeaderText = "Date";
            this.RegisterDate.MinimumWidth = 8;
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Width = 80;
            // 
            // SHA256_Hash
            // 
            this.SHA256_Hash.HeaderText = "SHA256 Hash";
            this.SHA256_Hash.MinimumWidth = 8;
            this.SHA256_Hash.Name = "SHA256_Hash";
            this.SHA256_Hash.Width = 150;
            // 
            // MD5_Hash
            // 
            this.MD5_Hash.HeaderText = "MD5Hash";
            this.MD5_Hash.MinimumWidth = 8;
            this.MD5_Hash.Name = "MD5_Hash";
            this.MD5_Hash.Width = 150;
            // 
            // SHA1_Hash
            // 
            this.SHA1_Hash.HeaderText = "SHA1 Hash";
            this.SHA1_Hash.MinimumWidth = 8;
            this.SHA1_Hash.Name = "SHA1_Hash";
            this.SHA1_Hash.Width = 150;
            // 
            // btReadCSV
            // 
            this.btReadCSV.Location = new System.Drawing.Point(23, 7);
            this.btReadCSV.Name = "btReadCSV";
            this.btReadCSV.Size = new System.Drawing.Size(107, 36);
            this.btReadCSV.TabIndex = 0;
            this.btReadCSV.Text = "read as csv";
            this.btReadCSV.UseVisualStyleBackColor = true;
            this.btReadCSV.Click += new System.EventHandler(this.btReadCSV_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // tbStartRow
            // 
            this.tbStartRow.Location = new System.Drawing.Point(204, 66);
            this.tbStartRow.Name = "tbStartRow";
            this.tbStartRow.Size = new System.Drawing.Size(100, 26);
            this.tbStartRow.TabIndex = 5;
            // 
            // tbEndRow
            // 
            this.tbEndRow.Location = new System.Drawing.Point(387, 66);
            this.tbEndRow.Name = "tbEndRow";
            this.tbEndRow.Size = new System.Drawing.Size(100, 26);
            this.tbEndRow.TabIndex = 6;
            this.tbEndRow.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbFilenam
            // 
            this.tbFilenam.Location = new System.Drawing.Point(574, 66);
            this.tbFilenam.Name = "tbFilenam";
            this.tbFilenam.Size = new System.Drawing.Size(100, 26);
            this.tbFilenam.TabIndex = 7;
            this.tbFilenam.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtStartRowCSV
            // 
            this.txtStartRowCSV.AutoSize = true;
            this.txtStartRowCSV.Location = new System.Drawing.Point(223, 23);
            this.txtStartRowCSV.Name = "txtStartRowCSV";
            this.txtStartRowCSV.Size = new System.Drawing.Size(109, 20);
            this.txtStartRowCSV.TabIndex = 2;
            this.txtStartRowCSV.Text = "StartRowCSV";
            this.txtStartRowCSV.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEndRowCSV
            // 
            this.txtEndRowCSV.AutoSize = true;
            this.txtEndRowCSV.Location = new System.Drawing.Point(426, 23);
            this.txtEndRowCSV.Name = "txtEndRowCSV";
            this.txtEndRowCSV.Size = new System.Drawing.Size(103, 20);
            this.txtEndRowCSV.TabIndex = 3;
            this.txtEndRowCSV.Text = "EndRowCSV";
            this.txtEndRowCSV.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "FileNameCSV";
            // 
            // tbStartRowCSV
            // 
            this.tbStartRowCSV.Location = new System.Drawing.Point(227, 62);
            this.tbStartRowCSV.Name = "tbStartRowCSV";
            this.tbStartRowCSV.Size = new System.Drawing.Size(100, 26);
            this.tbStartRowCSV.TabIndex = 5;
            // 
            // tbEndRowCSV
            // 
            this.tbEndRowCSV.Location = new System.Drawing.Point(429, 62);
            this.tbEndRowCSV.Name = "tbEndRowCSV";
            this.tbEndRowCSV.Size = new System.Drawing.Size(100, 26);
            this.tbEndRowCSV.TabIndex = 6;
            this.tbEndRowCSV.TextChanged += new System.EventHandler(this.tbEndRowCSV_TextChanged);
            // 
            // tbFileNameCSV
            // 
            this.tbFileNameCSV.Location = new System.Drawing.Point(632, 62);
            this.tbFileNameCSV.Name = "tbFileNameCSV";
            this.tbFileNameCSV.Size = new System.Drawing.Size(100, 26);
            this.tbFileNameCSV.TabIndex = 7;
            // 
            // frmTextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 1169);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabcMain);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Name = "frmTextView";
            this.Text = "Text/CSV viewer";
            this.tabcMain.ResumeLayout(false);
            this.tabpText.ResumeLayout(false);
            this.tabpText.PerformLayout();
            this.tabpCSV.ResumeLayout(false);
            this.tabpCSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.Button btBrowse;
		private System.Windows.Forms.TabControl tabcMain;
		private System.Windows.Forms.TabPage tabpText;
		private System.Windows.Forms.TabPage tabpCSV;
		private System.Windows.Forms.Button btRead;
		private System.Windows.Forms.RichTextBox rtbShow;
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.Button btReadCSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn SHA256_Hash;
		private System.Windows.Forms.DataGridViewTextBoxColumn MD5_Hash;
		private System.Windows.Forms.DataGridViewTextBoxColumn SHA1_Hash;
        private System.Windows.Forms.Label txtFileName;
        private System.Windows.Forms.Label txtEndRow;
        private System.Windows.Forms.Label txtStartRow;
        private System.Windows.Forms.TextBox tbFilenam;
        private System.Windows.Forms.TextBox tbEndRow;
        private System.Windows.Forms.TextBox tbStartRow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtEndRowCSV;
        private System.Windows.Forms.Label txtStartRowCSV;
        private System.Windows.Forms.TextBox tbFileNameCSV;
        private System.Windows.Forms.TextBox tbEndRowCSV;
        private System.Windows.Forms.TextBox tbStartRowCSV;
    }
}

