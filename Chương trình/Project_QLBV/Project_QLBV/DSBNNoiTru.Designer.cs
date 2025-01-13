namespace Project_QLBV
{
    partial class DSBNNoiTru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSBNNoiTru));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvDSBN = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rptDSBNTheoNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rptDSBNTheoNam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rptDSBNTheoKhoangTG = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rptDSBNTheoThang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radKhoangTG = new System.Windows.Forms.RadioButton();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.lblTKDSBNNT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1367, 138);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.Location = new System.Drawing.Point(780, 59);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(198, 41);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Location = new System.Drawing.Point(438, 59);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(198, 41);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvDSBN);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(589, 136);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(819, 347);
            this.groupBox7.TabIndex = 83;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh Sách Bệnh Nhân Nội Trú";
            // 
            // dgvDSBN
            // 
            this.dgvDSBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBN.Location = new System.Drawing.Point(3, 26);
            this.dgvDSBN.Name = "dgvDSBN";
            this.dgvDSBN.RowHeadersWidth = 62;
            this.dgvDSBN.RowTemplate.Height = 28;
            this.dgvDSBN.Size = new System.Drawing.Size(813, 318);
            this.dgvDSBN.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rptDSBNTheoNgay);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(40, 1122);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1367, 423);
            this.groupBox6.TabIndex = 87;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh Sách Bệnh Nhân Theo Ngày";
            // 
            // rptDSBNTheoNgay
            // 
            this.rptDSBNTheoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDSBNTheoNgay.LocalReport.ReportEmbeddedResource = "Project_QLBV.rptTimBNNoiTruTheoNgay.rdlc";
            this.rptDSBNTheoNgay.Location = new System.Drawing.Point(3, 26);
            this.rptDSBNTheoNgay.Name = "rptDSBNTheoNgay";
            this.rptDSBNTheoNgay.ServerReport.BearerToken = null;
            this.rptDSBNTheoNgay.Size = new System.Drawing.Size(1361, 394);
            this.rptDSBNTheoNgay.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rptDSBNTheoNam);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(38, 2016);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1367, 423);
            this.groupBox5.TabIndex = 90;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Bệnh Nhân Theo Năm";
            // 
            // rptDSBNTheoNam
            // 
            this.rptDSBNTheoNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDSBNTheoNam.LocalReport.ReportEmbeddedResource = "Project_QLBV.rptTimDSBNTheoNam.rdlc";
            this.rptDSBNTheoNam.Location = new System.Drawing.Point(3, 26);
            this.rptDSBNTheoNam.Name = "rptDSBNTheoNam";
            this.rptDSBNTheoNam.ServerReport.BearerToken = null;
            this.rptDSBNTheoNam.Size = new System.Drawing.Size(1361, 394);
            this.rptDSBNTheoNam.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rptDSBNTheoKhoangTG);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(41, 675);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1367, 423);
            this.groupBox4.TabIndex = 88;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Bệnh Nhân Theo Khoảng Thời Gian";
            // 
            // rptDSBNTheoKhoangTG
            // 
            this.rptDSBNTheoKhoangTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDSBNTheoKhoangTG.LocalReport.ReportEmbeddedResource = "Project_QLBV.rptTimDSBNTheoKhoangTG.rdlc";
            this.rptDSBNTheoKhoangTG.Location = new System.Drawing.Point(3, 26);
            this.rptDSBNTheoKhoangTG.Name = "rptDSBNTheoKhoangTG";
            this.rptDSBNTheoKhoangTG.ServerReport.BearerToken = null;
            this.rptDSBNTheoKhoangTG.Size = new System.Drawing.Size(1361, 394);
            this.rptDSBNTheoKhoangTG.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rptDSBNTheoThang);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 1568);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1367, 423);
            this.groupBox3.TabIndex = 89;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Bệnh Nhân Theo Tháng";
            // 
            // rptDSBNTheoThang
            // 
            this.rptDSBNTheoThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDSBNTheoThang.LocalReport.ReportEmbeddedResource = "Project_QLBV.rptTimBNNoiTruTheoThang.rdlc";
            this.rptDSBNTheoThang.Location = new System.Drawing.Point(3, 26);
            this.rptDSBNTheoThang.Name = "rptDSBNTheoThang";
            this.rptDSBNTheoThang.ServerReport.BearerToken = null;
            this.rptDSBNTheoThang.Size = new System.Drawing.Size(1361, 394);
            this.rptDSBNTheoThang.TabIndex = 0;
            // 
            // radKhoangTG
            // 
            this.radKhoangTG.AutoSize = true;
            this.radKhoangTG.Location = new System.Drawing.Point(36, 290);
            this.radKhoangTG.Name = "radKhoangTG";
            this.radKhoangTG.Size = new System.Drawing.Size(184, 29);
            this.radKhoangTG.TabIndex = 14;
            this.radKhoangTG.Text = "Khoảng thời gian";
            this.radKhoangTG.UseVisualStyleBackColor = true;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(31, 159);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(96, 25);
            this.lblDenNgay.TabIndex = 13;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(150, 86);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(293, 30);
            this.dtpNgay.TabIndex = 12;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(31, 91);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(84, 25);
            this.lblTuNgay.TabIndex = 11;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(150, 154);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(293, 30);
            this.dtpDenNgay.TabIndex = 10;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(349, 239);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(78, 29);
            this.radNam.TabIndex = 9;
            this.radNam.Text = "Năm";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(187, 239);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(94, 29);
            this.radThang.TabIndex = 8;
            this.radThang.Text = "Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radKhoangTG);
            this.groupBox2.Controls.Add(this.lblDenNgay);
            this.groupBox2.Controls.Add(this.dtpNgay);
            this.groupBox2.Controls.Add(this.lblTuNgay);
            this.groupBox2.Controls.Add(this.dtpDenNgay);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.radThang);
            this.groupBox2.Controls.Add(this.radNgay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 347);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thời Gian Thống Kê";
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Checked = true;
            this.radNgay.Location = new System.Drawing.Point(36, 239);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(83, 29);
            this.radNgay.TabIndex = 7;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            // 
            // lblTKDSBNNT
            // 
            this.lblTKDSBNNT.AutoSize = true;
            this.lblTKDSBNNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKDSBNNT.ForeColor = System.Drawing.Color.Red;
            this.lblTKDSBNNT.Location = new System.Drawing.Point(29, 34);
            this.lblTKDSBNNT.Name = "lblTKDSBNNT";
            this.lblTKDSBNNT.Size = new System.Drawing.Size(1375, 69);
            this.lblTKDSBNNT.TabIndex = 84;
            this.lblTKDSBNNT.Text = "THỐNG KÊ DANH SÁCH BỆNH NHÂN NỘI TRÚ";
            // 
            // DSBNNoiTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1480, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTKDSBNNT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSBNNoiTru";
            this.Text = "DSBNNoiTru";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DSBNNoiTru_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvDSBN;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radKhoangTG;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.Label lblTKDSBNNT;
        private Microsoft.Reporting.WinForms.ReportViewer rptDSBNTheoKhoangTG;
        private Microsoft.Reporting.WinForms.ReportViewer rptDSBNTheoNgay;
        private Microsoft.Reporting.WinForms.ReportViewer rptDSBNTheoThang;
        private Microsoft.Reporting.WinForms.ReportViewer rptDSBNTheoNam;
    }
}