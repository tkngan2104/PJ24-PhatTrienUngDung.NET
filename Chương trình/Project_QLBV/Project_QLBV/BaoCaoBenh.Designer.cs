namespace Project_QLBV
{
    partial class BaoCaoBenh
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoBenh));
            this.LayTKCuaDSBenhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBVDataSet21 = new Project_QLBV.QLBVDataSet21();
            this.LayTinhTrangSKCuaBenhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBVDataSet22 = new Project_QLBV.QLBVDataSet22();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvDSTKBenh = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rptBaoCaoDSBenh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rptBaoCaoBenhCuThe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTenBenh = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaBenh = new System.Windows.Forms.TextBox();
            this.lblBCTKB = new System.Windows.Forms.Label();
            this.LayTKCuaDSBenhTableAdapter = new Project_QLBV.QLBVDataSet21TableAdapters.LayTKCuaDSBenhTableAdapter();
            this.LayTinhTrangSKCuaBenhNhanTableAdapter = new Project_QLBV.QLBVDataSet22TableAdapters.LayTinhTrangSKCuaBenhNhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LayTKCuaDSBenhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBVDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayTinhTrangSKCuaBenhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBVDataSet22)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTKBenh)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayTKCuaDSBenhBindingSource
            // 
            this.LayTKCuaDSBenhBindingSource.DataMember = "LayTKCuaDSBenh";
            this.LayTKCuaDSBenhBindingSource.DataSource = this.QLBVDataSet21;
            // 
            // QLBVDataSet21
            // 
            this.QLBVDataSet21.DataSetName = "QLBVDataSet21";
            this.QLBVDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LayTinhTrangSKCuaBenhNhanBindingSource
            // 
            this.LayTinhTrangSKCuaBenhNhanBindingSource.DataMember = "LayTinhTrangSKCuaBenhNhan";
            this.LayTinhTrangSKCuaBenhNhanBindingSource.DataSource = this.QLBVDataSet22;
            // 
            // QLBVDataSet22
            // 
            this.QLBVDataSet22.DataSetName = "QLBVDataSet22";
            this.QLBVDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1367, 138);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(860, 60);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(198, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.Location = new System.Drawing.Point(582, 60);
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
            this.btnTim.Location = new System.Drawing.Point(304, 60);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(198, 41);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvDSTKBenh);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(573, 138);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(819, 240);
            this.groupBox7.TabIndex = 89;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh Sách Thống Kê Bệnh";
            // 
            // dgvDSTKBenh
            // 
            this.dgvDSTKBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTKBenh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSTKBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTKBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTKBenh.Location = new System.Drawing.Point(3, 26);
            this.dgvDSTKBenh.Name = "dgvDSTKBenh";
            this.dgvDSTKBenh.RowHeadersWidth = 62;
            this.dgvDSTKBenh.RowTemplate.Height = 28;
            this.dgvDSTKBenh.Size = new System.Drawing.Size(813, 211);
            this.dgvDSTKBenh.TabIndex = 0;
            this.dgvDSTKBenh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTKBenh_CellContentClick);
            this.dgvDSTKBenh.Click += new System.EventHandler(this.dgvDSTKBenh_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rptBaoCaoDSBenh);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(25, 1023);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1367, 423);
            this.groupBox6.TabIndex = 93;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Báo Cáo Danh Sách Bệnh";
            // 
            // rptBaoCaoDSBenh
            // 
            this.rptBaoCaoDSBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LayTKCuaDSBenhBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.LayTinhTrangSKCuaBenhNhanBindingSource;
            this.rptBaoCaoDSBenh.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBaoCaoDSBenh.LocalReport.DataSources.Add(reportDataSource2);
            this.rptBaoCaoDSBenh.LocalReport.ReportEmbeddedResource = "Project_QLBV.rptThongKeCuaDSBenh.rdlc";
            this.rptBaoCaoDSBenh.Location = new System.Drawing.Point(3, 26);
            this.rptBaoCaoDSBenh.Name = "rptBaoCaoDSBenh";
            this.rptBaoCaoDSBenh.ServerReport.BearerToken = null;
            this.rptBaoCaoDSBenh.Size = new System.Drawing.Size(1361, 394);
            this.rptBaoCaoDSBenh.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rptBaoCaoBenhCuThe);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 574);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1367, 423);
            this.groupBox4.TabIndex = 94;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Báo Cáo Bệnh Cụ Thể";
            // 
            // rptBaoCaoBenhCuThe
            // 
            this.rptBaoCaoBenhCuThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBaoCaoBenhCuThe.LocalReport.ReportEmbeddedResource = "Project_QLBV.rptThongKeCuaBenhCuThe.rdlc";
            this.rptBaoCaoBenhCuThe.Location = new System.Drawing.Point(3, 26);
            this.rptBaoCaoBenhCuThe.Name = "rptBaoCaoBenhCuThe";
            this.rptBaoCaoBenhCuThe.ServerReport.BearerToken = null;
            this.rptBaoCaoBenhCuThe.Size = new System.Drawing.Size(1361, 394);
            this.rptBaoCaoBenhCuThe.TabIndex = 0;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(31, 159);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(58, 25);
            this.lblNgay.TabIndex = 13;
            this.lblNgay.Text = "Ngày";
            // 
            // lblTenBenh
            // 
            this.lblTenBenh.AutoSize = true;
            this.lblTenBenh.Location = new System.Drawing.Point(31, 91);
            this.lblTenBenh.Name = "lblTenBenh";
            this.lblTenBenh.Size = new System.Drawing.Size(96, 25);
            this.lblTenBenh.TabIndex = 11;
            this.lblTenBenh.Text = "Tên bệnh";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(150, 154);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(293, 30);
            this.dtpNgay.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaBenh);
            this.groupBox2.Controls.Add(this.lblNgay);
            this.groupBox2.Controls.Add(this.lblTenBenh);
            this.groupBox2.Controls.Add(this.dtpNgay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 240);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thời Gian Thống Kê";
            // 
            // txtMaBenh
            // 
            this.txtMaBenh.Location = new System.Drawing.Point(150, 86);
            this.txtMaBenh.Name = "txtMaBenh";
            this.txtMaBenh.Size = new System.Drawing.Size(293, 30);
            this.txtMaBenh.TabIndex = 15;
            // 
            // lblBCTKB
            // 
            this.lblBCTKB.AutoSize = true;
            this.lblBCTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCTKB.ForeColor = System.Drawing.Color.Red;
            this.lblBCTKB.Location = new System.Drawing.Point(281, 30);
            this.lblBCTKB.Name = "lblBCTKB";
            this.lblBCTKB.Size = new System.Drawing.Size(835, 69);
            this.lblBCTKB.TabIndex = 90;
            this.lblBCTKB.Text = "BÁO CÁO THỐNG KÊ BỆNH";
            // 
            // LayTKCuaDSBenhTableAdapter
            // 
            this.LayTKCuaDSBenhTableAdapter.ClearBeforeFill = true;
            // 
            // LayTinhTrangSKCuaBenhNhanTableAdapter
            // 
            this.LayTinhTrangSKCuaBenhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1464, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblBCTKB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCaoBenh";
            this.Text = "BaoCaoBenh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCaoBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayTKCuaDSBenhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBVDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayTinhTrangSKCuaBenhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBVDataSet22)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTKBenh)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvDSTKBenh;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTenBenh;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaBenh;
        private System.Windows.Forms.Label lblBCTKB;
        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCaoBenhCuThe;
        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCaoDSBenh;
        private System.Windows.Forms.BindingSource LayTKCuaDSBenhBindingSource;
        private QLBVDataSet21 QLBVDataSet21;
        private System.Windows.Forms.BindingSource LayTinhTrangSKCuaBenhNhanBindingSource;
        private QLBVDataSet22 QLBVDataSet22;
        private QLBVDataSet21TableAdapters.LayTKCuaDSBenhTableAdapter LayTKCuaDSBenhTableAdapter;
        private QLBVDataSet22TableAdapters.LayTinhTrangSKCuaBenhNhanTableAdapter LayTinhTrangSKCuaBenhNhanTableAdapter;
        private System.Windows.Forms.Button btnThoat;
    }
}