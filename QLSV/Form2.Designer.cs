namespace QLSV
{
    partial class Form2
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
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.gbDiem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.dG1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNH1 = new System.Windows.Forms.TextBox();
            this.txtNH2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.label100 = new System.Windows.Forms.Label();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtxep = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.gbTT.SuspendLayout();
            this.gbDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.btnXuat);
            this.gbTT.Controls.Add(this.txtE);
            this.gbTT.Controls.Add(this.label2);
            this.gbTT.Controls.Add(this.txtGT);
            this.gbTT.Controls.Add(this.label1);
            this.gbTT.Controls.Add(this.txtNS);
            this.gbTT.Controls.Add(this.label5);
            this.gbTT.Controls.Add(this.txtMa);
            this.gbTT.Controls.Add(this.label4);
            this.gbTT.Controls.Add(this.txtTen);
            this.gbTT.Controls.Add(this.label3);
            this.gbTT.Location = new System.Drawing.Point(12, 12);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(698, 189);
            this.gbTT.TabIndex = 0;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin Sinh Viên";
            // 
            // gbDiem
            // 
            this.gbDiem.Controls.Add(this.cbHK);
            this.gbDiem.Controls.Add(this.dG1);
            this.gbDiem.Controls.Add(this.txtNH2);
            this.gbDiem.Controls.Add(this.txtxep);
            this.gbDiem.Controls.Add(this.txtdtb);
            this.gbDiem.Controls.Add(this.label9);
            this.gbDiem.Controls.Add(this.txtNH1);
            this.gbDiem.Controls.Add(this.label100);
            this.gbDiem.Controls.Add(this.label7);
            this.gbDiem.Controls.Add(this.label6);
            this.gbDiem.Location = new System.Drawing.Point(12, 207);
            this.gbDiem.Name = "gbDiem";
            this.gbDiem.Size = new System.Drawing.Size(698, 235);
            this.gbDiem.TabIndex = 0;
            this.gbDiem.TabStop = false;
            this.gbDiem.Text = "Bảng Điểm ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học và Tên";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(84, 18);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(273, 20);
            this.txtTen.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MSSV";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(84, 41);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(273, 20);
            this.txtMa.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày sinh";
            // 
            // txtNS
            // 
            this.txtNS.Enabled = false;
            this.txtNS.Location = new System.Drawing.Point(84, 64);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(273, 20);
            this.txtNS.TabIndex = 3;
            // 
            // dG1
            // 
            this.dG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dG1.Location = new System.Drawing.Point(0, 67);
            this.dG1.Name = "dG1";
            this.dG1.Size = new System.Drawing.Size(698, 188);
            this.dG1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Năm học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Học kỳ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên HP";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số TC";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm chữ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Điểm số";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới tính";
            // 
            // txtGT
            // 
            this.txtGT.Enabled = false;
            this.txtGT.Location = new System.Drawing.Point(84, 90);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(273, 20);
            this.txtGT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txtE
            // 
            this.txtE.Enabled = false;
            this.txtE.Location = new System.Drawing.Point(84, 116);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(273, 20);
            this.txtE.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Năm học";
            // 
            // txtNH1
            // 
            this.txtNH1.Enabled = false;
            this.txtNH1.Location = new System.Drawing.Point(84, 19);
            this.txtNH1.Name = "txtNH1";
            this.txtNH1.Size = new System.Drawing.Size(79, 20);
            this.txtNH1.TabIndex = 3;
            // 
            // txtNH2
            // 
            this.txtNH2.Enabled = false;
            this.txtNH2.Location = new System.Drawing.Point(169, 19);
            this.txtNH2.Name = "txtNH2";
            this.txtNH2.Size = new System.Drawing.Size(79, 20);
            this.txtNH2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Học kỳ";
            // 
            // cbHK
            // 
            this.cbHK.Enabled = false;
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbHK.Location = new System.Drawing.Point(359, 19);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(121, 21);
            this.cbHK.TabIndex = 4;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(543, 18);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(29, 13);
            this.label100.TabIndex = 2;
            this.label100.Text = "ĐTB";
            // 
            // txtdtb
            // 
            this.txtdtb.Enabled = false;
            this.txtdtb.Location = new System.Drawing.Point(613, 15);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(79, 20);
            this.txtdtb.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Xếp loại";
            // 
            // txtxep
            // 
            this.txtxep.Enabled = false;
            this.txtxep.Location = new System.Drawing.Point(613, 41);
            this.txtxep.Name = "txtxep";
            this.txtxep.Size = new System.Drawing.Size(79, 20);
            this.txtxep.TabIndex = 3;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(307, 160);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(115, 23);
            this.btnXuat.TabIndex = 4;
            this.btnXuat.Text = "Xuất Bảng Điểm";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 454);
            this.Controls.Add(this.gbDiem);
            this.Controls.Add(this.gbTT);
            this.Name = "Form2";
            this.Text = "Xuất Điểm Sinh Viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            this.gbDiem.ResumeLayout(false);
            this.gbDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.GroupBox gbDiem;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.TextBox txtNH2;
        private System.Windows.Forms.TextBox txtxep;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNH1;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXuat;
    }
}