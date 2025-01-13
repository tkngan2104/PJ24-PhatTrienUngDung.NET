namespace Project_QLBV
{
    partial class DamNhanChuyenMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamNhanChuyenMon));
            this.cboCN = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNgLam = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtEXP = new System.Windows.Forms.TextBox();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblDNCM = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSDNCM = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDNCM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCN
            // 
            this.cboCN.FormattingEnabled = true;
            this.cboCN.Location = new System.Drawing.Point(226, 144);
            this.cboCN.Name = "cboCN";
            this.cboCN.Size = new System.Drawing.Size(276, 33);
            this.cboCN.TabIndex = 8;
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(226, 60);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(276, 33);
            this.cboNV.TabIndex = 7;
            this.cboNV.SelectedIndexChanged += new System.EventHandler(this.cboNV_SelectedIndexChanged);
            // 
            // lblNgLam
            // 
            this.lblNgLam.AutoSize = true;
            this.lblNgLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgLam.Location = new System.Drawing.Point(41, 229);
            this.lblNgLam.Name = "lblNgLam";
            this.lblNgLam.Size = new System.Drawing.Size(94, 25);
            this.lblNgLam.TabIndex = 6;
            this.lblNgLam.Text = "Ngày làm";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(41, 69);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 25);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(325, 176);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(233, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát màn hình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Location = new System.Drawing.Point(325, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(233, 41);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(42, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(233, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtEXP
            // 
            this.txtEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEXP.Location = new System.Drawing.Point(478, 224);
            this.txtEXP.Name = "txtEXP";
            this.txtEXP.ReadOnly = true;
            this.txtEXP.Size = new System.Drawing.Size(243, 30);
            this.txtEXP.TabIndex = 13;
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLam.Location = new System.Drawing.Point(226, 224);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(196, 30);
            this.dtpNgayLam.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(42, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuyenNganh.Location = new System.Drawing.Point(41, 152);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(141, 25);
            this.lblChuyenNganh.TabIndex = 4;
            this.lblChuyenNganh.Text = "Chuyên ngành";
            // 
            // lblDNCM
            // 
            this.lblDNCM.AutoSize = true;
            this.lblDNCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNCM.ForeColor = System.Drawing.Color.Red;
            this.lblDNCM.Location = new System.Drawing.Point(337, 41);
            this.lblDNCM.Name = "lblDNCM";
            this.lblDNCM.Size = new System.Drawing.Size(791, 69);
            this.lblDNCM.TabIndex = 23;
            this.lblDNCM.Text = "ĐẢM NHẬN CHUYÊN MÔN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(840, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 302);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // dgvDSDNCM
            // 
            this.dgvDSDNCM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDNCM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSDNCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDNCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDNCM.Location = new System.Drawing.Point(3, 26);
            this.dgvDSDNCM.Name = "dgvDSDNCM";
            this.dgvDSDNCM.RowHeadersWidth = 62;
            this.dgvDSDNCM.RowTemplate.Height = 28;
            this.dgvDSDNCM.Size = new System.Drawing.Size(1407, 366);
            this.dgvDSDNCM.TabIndex = 0;
            this.dgvDSDNCM.Click += new System.EventHandler(this.dgvDSDNCM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSDNCM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 395);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Đảm Nhận Chuyên Môn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEXP);
            this.groupBox3.Controls.Add(this.dtpNgayLam);
            this.groupBox3.Controls.Add(this.cboCN);
            this.groupBox3.Controls.Add(this.cboNV);
            this.groupBox3.Controls.Add(this.lblNgLam);
            this.groupBox3.Controls.Add(this.lblChuyenNganh);
            this.groupBox3.Controls.Add(this.lblNhanVien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 302);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Đảm Nhận Chuyên Môn";
            // 
            // DamNhanChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1489, 792);
            this.Controls.Add(this.lblDNCM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DamNhanChuyenMon";
            this.Text = "DamNhanChuyenMon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DamNhanChuyenMon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDNCM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCN;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNgLam;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtEXP;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblDNCM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSDNCM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}