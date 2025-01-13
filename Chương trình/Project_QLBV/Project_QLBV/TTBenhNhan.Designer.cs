namespace Project_QLBV
{
    partial class TTBenhNhan
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBHYT = new System.Windows.Forms.Button();
            this.btnLapHSBA = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTTBenhNhan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTTBenhNhan = new System.Windows.Forms.DataGridView();
            this.mtbTTLH = new System.Windows.Forms.MaskedTextBox();
            this.lblTTLienHe = new System.Windows.Forms.Label();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgSinh = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.lblTenBN = new System.Windows.Forms.Label();
            this.lblMSNhanVien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBenhNhan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.Location = new System.Drawing.Point(1054, 41);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(154, 41);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBHYT
            // 
            this.btnBHYT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBHYT.Location = new System.Drawing.Point(616, 41);
            this.btnBHYT.Name = "btnBHYT";
            this.btnBHYT.Size = new System.Drawing.Size(162, 41);
            this.btnBHYT.TabIndex = 7;
            this.btnBHYT.Text = "Bảo hiểm y tế";
            this.btnBHYT.UseVisualStyleBackColor = false;
            this.btnBHYT.Click += new System.EventHandler(this.btnBHYT_Click);
            // 
            // btnLapHSBA
            // 
            this.btnLapHSBA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLapHSBA.FlatAppearance.BorderSize = 0;
            this.btnLapHSBA.Location = new System.Drawing.Point(816, 41);
            this.btnLapHSBA.Name = "btnLapHSBA";
            this.btnLapHSBA.Size = new System.Drawing.Size(193, 41);
            this.btnLapHSBA.TabIndex = 6;
            this.btnLapHSBA.Text = "Lập hồ sơ bệnh án";
            this.btnLapHSBA.UseVisualStyleBackColor = false;
            this.btnLapHSBA.Click += new System.EventHandler(this.btnLapHSBA_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(19, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTTBenhNhan
            // 
            this.lblTTBenhNhan.AutoSize = true;
            this.lblTTBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTBenhNhan.ForeColor = System.Drawing.Color.Red;
            this.lblTTBenhNhan.Location = new System.Drawing.Point(374, 12);
            this.lblTTBenhNhan.Name = "lblTTBenhNhan";
            this.lblTTBenhNhan.Size = new System.Drawing.Size(746, 69);
            this.lblTTBenhNhan.TabIndex = 22;
            this.lblTTBenhNhan.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnBHYT);
            this.groupBox1.Controls.Add(this.btnLapHSBA);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 564);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 106);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Location = new System.Drawing.Point(419, 41);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(162, 41);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(213, 41);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTTBenhNhan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 694);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 443);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Bệnh Nhân";
            // 
            // dgvTTBenhNhan
            // 
            this.dgvTTBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTBenhNhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTTBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTBenhNhan.Location = new System.Drawing.Point(3, 26);
            this.dgvTTBenhNhan.Name = "dgvTTBenhNhan";
            this.dgvTTBenhNhan.RowHeadersWidth = 62;
            this.dgvTTBenhNhan.RowTemplate.Height = 28;
            this.dgvTTBenhNhan.Size = new System.Drawing.Size(1407, 414);
            this.dgvTTBenhNhan.TabIndex = 0;
            this.dgvTTBenhNhan.Click += new System.EventHandler(this.dgvTTBenhNhan_Click);
            // 
            // mtbTTLH
            // 
            this.mtbTTLH.Location = new System.Drawing.Point(1049, 139);
            this.mtbTTLH.Mask = "(000) 000-0000";
            this.mtbTTLH.Name = "mtbTTLH";
            this.mtbTTLH.Size = new System.Drawing.Size(321, 30);
            this.mtbTTLH.TabIndex = 29;
            this.mtbTTLH.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTTLH_Validating);
            // 
            // lblTTLienHe
            // 
            this.lblTTLienHe.AutoSize = true;
            this.lblTTLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTLienHe.Location = new System.Drawing.Point(826, 142);
            this.lblTTLienHe.Name = "lblTTLienHe";
            this.lblTTLienHe.Size = new System.Drawing.Size(156, 25);
            this.lblTTLienHe.TabIndex = 28;
            this.lblTTLienHe.Text = "Thông tin liên hệ";
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(1049, 381);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(321, 30);
            this.txtNgheNghiep.TabIndex = 27;
            this.txtNgheNghiep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgheNghiep_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(1049, 299);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(321, 30);
            this.txtDiaChi.TabIndex = 26;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgheNghiep.Location = new System.Drawing.Point(826, 386);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(123, 25);
            this.lblNgheNghiep.TabIndex = 25;
            this.lblNgheNghiep.Text = "Nghề nghiệp";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(826, 304);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(71, 25);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgSinh
            // 
            this.lblNgSinh.AutoSize = true;
            this.lblNgSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgSinh.Location = new System.Drawing.Point(36, 304);
            this.lblNgSinh.Name = "lblNgSinh";
            this.lblNgSinh.Size = new System.Drawing.Size(99, 25);
            this.lblNgSinh.TabIndex = 2;
            this.lblNgSinh.Text = "Ngày sinh";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBN.Location = new System.Drawing.Point(259, 53);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(321, 30);
            this.txtMaBN.TabIndex = 1;
            this.txtMaBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaBN_KeyPress);
            // 
            // lblTenBN
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBN.Location = new System.Drawing.Point(36, 142);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(145, 25);
            this.lblTenBN.TabIndex = 4;
            this.lblTenBN.Text = "Tên bệnh nhân";
            // 
            // lblMSNhanVien
            // 
            this.lblMSNhanVien.AutoSize = true;
            this.lblMSNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSNhanVien.Location = new System.Drawing.Point(36, 59);
            this.lblMSNhanVien.Name = "lblMSNhanVien";
            this.lblMSNhanVien.Size = new System.Drawing.Size(164, 25);
            this.lblMSNhanVien.TabIndex = 0;
            this.lblMSNhanVien.Text = "Mã số bệnh nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbTTLH);
            this.groupBox2.Controls.Add(this.lblTTLienHe);
            this.groupBox2.Controls.Add(this.txtNgheNghiep);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.lblNgheNghiep);
            this.groupBox2.Controls.Add(this.mtbSDT);
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.lblCCCD);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.lblGioiTinh);
            this.groupBox2.Controls.Add(this.lblSDT);
            this.groupBox2.Controls.Add(this.txtTenBN);
            this.groupBox2.Controls.Add(this.dtpNgSinh);
            this.groupBox2.Controls.Add(this.lblDiaChi);
            this.groupBox2.Controls.Add(this.lblNgSinh);
            this.groupBox2.Controls.Add(this.txtMaBN);
            this.groupBox2.Controls.Add(this.lblTenBN);
            this.groupBox2.Controls.Add(this.lblMSNhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1412, 427);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Bệnh Nhân";
            // 
            // mtbSDT
            // 
            this.mtbSDT.Location = new System.Drawing.Point(1049, 53);
            this.mtbSDT.Mask = "(000) 000-0000";
            this.mtbSDT.Name = "mtbSDT";
            this.mtbSDT.Size = new System.Drawing.Size(321, 30);
            this.mtbSDT.TabIndex = 23;
            this.mtbSDT.Validating += new System.ComponentModel.CancelEventHandler(this.mtbSDT_Validating);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(433, 220);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(62, 29);
            this.radNu.TabIndex = 22;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(826, 222);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(71, 25);
            this.lblCCCD.TabIndex = 7;
            this.lblCCCD.Text = "CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(1049, 217);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(321, 30);
            this.txtCCCD.TabIndex = 8;
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(259, 220);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(78, 29);
            this.radNam.TabIndex = 21;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(36, 222);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(82, 25);
            this.lblGioiTinh.TabIndex = 20;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(826, 56);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(126, 25);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(259, 137);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(321, 30);
            this.txtTenBN.TabIndex = 19;
            this.txtTenBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenBN_KeyPress);
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgSinh.Location = new System.Drawing.Point(259, 299);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(321, 30);
            this.dtpNgSinh.TabIndex = 14;
            this.dtpNgSinh.ValueChanged += new System.EventHandler(this.dtpNgSinh_ValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(1241, 41);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 41);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TTBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1489, 854);
            this.Controls.Add(this.lblTTBenhNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TTBenhNhan";
            this.Text = "TTBenhNhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TTBenhNhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBenhNhan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBHYT;
        private System.Windows.Forms.Button btnLapHSBA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTTBenhNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTTBenhNhan;
        private System.Windows.Forms.MaskedTextBox mtbTTLH;
        private System.Windows.Forms.Label lblTTLienHe;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgheNghiep;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgSinh;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label lblTenBN;
        private System.Windows.Forms.Label lblMSNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtbSDT;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.Button btnThoat;
    }
}