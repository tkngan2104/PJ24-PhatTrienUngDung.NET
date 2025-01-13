namespace Project_QLBV
{
    partial class DangKyKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyKham));
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cboNVYeuCau = new System.Windows.Forms.ComboBox();
            this.lblNVYeuCau = new System.Windows.Forms.Label();
            this.txtNVYeuCau = new System.Windows.Forms.TextBox();
            this.cboNVPhuTrach = new System.Windows.Forms.ComboBox();
            this.cboPhieuKhamBenh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.lblNVPhuTrach = new System.Windows.Forms.Label();
            this.txtNVPhuTrach = new System.Windows.Forms.TextBox();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.txtMaKham = new System.Windows.Forms.TextBox();
            this.lblPKB = new System.Windows.Forms.Label();
            this.lblMaKham = new System.Windows.Forms.Label();
            this.btnPhanGiuong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChuanDoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDKK = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDKKHAM = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKK)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(1132, 100);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(317, 26);
            this.dtpNgay.TabIndex = 51;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(981, 88);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(321, 30);
            this.txtTenPhong.TabIndex = 43;
            this.txtTenPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenPhong_KeyPress);
            this.txtTenPhong.Leave += new System.EventHandler(this.txtTenPhong_Leave);
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(978, 249);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.ReadOnly = true;
            this.txtTenBN.Size = new System.Drawing.Size(321, 30);
            this.txtTenBN.TabIndex = 42;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(777, 91);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(69, 25);
            this.lblPhong.TabIndex = 39;
            this.lblPhong.Text = "Phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(981, 137);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(321, 30);
            this.txtMaPhong.TabIndex = 40;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
            // 
            // cboNVYeuCau
            // 
            this.cboNVYeuCau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVYeuCau.FormattingEnabled = true;
            this.cboNVYeuCau.Location = new System.Drawing.Point(289, 377);
            this.cboNVYeuCau.Name = "cboNVYeuCau";
            this.cboNVYeuCau.Size = new System.Drawing.Size(172, 33);
            this.cboNVYeuCau.TabIndex = 38;
            this.cboNVYeuCau.SelectedIndexChanged += new System.EventHandler(this.cboNVYeuCau_SelectedIndexChanged);
            // 
            // lblNVYeuCau
            // 
            this.lblNVYeuCau.AutoSize = true;
            this.lblNVYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVYeuCau.Location = new System.Drawing.Point(85, 380);
            this.lblNVYeuCau.Name = "lblNVYeuCau";
            this.lblNVYeuCau.Size = new System.Drawing.Size(174, 25);
            this.lblNVYeuCau.TabIndex = 36;
            this.lblNVYeuCau.Text = "Nhân viên yêu cầu";
            // 
            // txtNVYeuCau
            // 
            this.txtNVYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVYeuCau.Location = new System.Drawing.Point(289, 426);
            this.txtNVYeuCau.Name = "txtNVYeuCau";
            this.txtNVYeuCau.ReadOnly = true;
            this.txtNVYeuCau.Size = new System.Drawing.Size(321, 30);
            this.txtNVYeuCau.TabIndex = 37;
            // 
            // cboNVPhuTrach
            // 
            this.cboNVPhuTrach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVPhuTrach.FormattingEnabled = true;
            this.cboNVPhuTrach.Location = new System.Drawing.Point(289, 246);
            this.cboNVPhuTrach.Name = "cboNVPhuTrach";
            this.cboNVPhuTrach.Size = new System.Drawing.Size(172, 33);
            this.cboNVPhuTrach.TabIndex = 35;
            this.cboNVPhuTrach.SelectedIndexChanged += new System.EventHandler(this.cboNVPhuTrach_SelectedIndexChanged);
            // 
            // cboPhieuKhamBenh
            // 
            this.cboPhieuKhamBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieuKhamBenh.FormattingEnabled = true;
            this.cboPhieuKhamBenh.Location = new System.Drawing.Point(289, 164);
            this.cboPhieuKhamBenh.Name = "cboPhieuKhamBenh";
            this.cboPhieuKhamBenh.Size = new System.Drawing.Size(321, 33);
            this.cboPhieuKhamBenh.TabIndex = 34;
            this.cboPhieuKhamBenh.SelectedIndexChanged += new System.EventHandler(this.cboPhieuKhamBenh_SelectedIndexChanged);
            this.cboPhieuKhamBenh.SelectedValueChanged += new System.EventHandler(this.cboPhieuKhamBenh_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1051, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.txtTenBN);
            this.groupBox2.Controls.Add(this.lblPhong);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.cboNVYeuCau);
            this.groupBox2.Controls.Add(this.lblNVYeuCau);
            this.groupBox2.Controls.Add(this.txtNVYeuCau);
            this.groupBox2.Controls.Add(this.cboNVPhuTrach);
            this.groupBox2.Controls.Add(this.cboPhieuKhamBenh);
            this.groupBox2.Controls.Add(this.lblTrieuChung);
            this.groupBox2.Controls.Add(this.txtTrieuChung);
            this.groupBox2.Controls.Add(this.txtMaBN);
            this.groupBox2.Controls.Add(this.lblNVPhuTrach);
            this.groupBox2.Controls.Add(this.txtNVPhuTrach);
            this.groupBox2.Controls.Add(this.lblGiaTien);
            this.groupBox2.Controls.Add(this.txtMaKham);
            this.groupBox2.Controls.Add(this.lblPKB);
            this.groupBox2.Controls.Add(this.lblMaKham);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 507);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đăng Ký Khám";
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrieuChung.Location = new System.Drawing.Point(777, 323);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(116, 25);
            this.lblTrieuChung.TabIndex = 31;
            this.lblTrieuChung.Text = "Triệu chứng";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrieuChung.Location = new System.Drawing.Point(978, 320);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.ReadOnly = true;
            this.txtTrieuChung.Size = new System.Drawing.Size(321, 30);
            this.txtTrieuChung.TabIndex = 32;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBN.Location = new System.Drawing.Point(978, 203);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(321, 30);
            this.txtMaBN.TabIndex = 26;
            // 
            // lblNVPhuTrach
            // 
            this.lblNVPhuTrach.AutoSize = true;
            this.lblNVPhuTrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVPhuTrach.Location = new System.Drawing.Point(85, 249);
            this.lblNVPhuTrach.Name = "lblNVPhuTrach";
            this.lblNVPhuTrach.Size = new System.Drawing.Size(186, 25);
            this.lblNVPhuTrach.TabIndex = 7;
            this.lblNVPhuTrach.Text = "Nhân viên phụ trách";
            // 
            // txtNVPhuTrach
            // 
            this.txtNVPhuTrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVPhuTrach.Location = new System.Drawing.Point(289, 307);
            this.txtNVPhuTrach.Name = "txtNVPhuTrach";
            this.txtNVPhuTrach.ReadOnly = true;
            this.txtNVPhuTrach.Size = new System.Drawing.Size(321, 30);
            this.txtNVPhuTrach.TabIndex = 8;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(777, 203);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(107, 25);
            this.lblGiaTien.TabIndex = 6;
            this.lblGiaTien.Text = "Bệnh nhân";
            // 
            // txtMaKham
            // 
            this.txtMaKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKham.Location = new System.Drawing.Point(289, 86);
            this.txtMaKham.Name = "txtMaKham";
            this.txtMaKham.ReadOnly = true;
            this.txtMaKham.Size = new System.Drawing.Size(448, 30);
            this.txtMaKham.TabIndex = 1;
            // 
            // lblPKB
            // 
            this.lblPKB.AutoSize = true;
            this.lblPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPKB.Location = new System.Drawing.Point(85, 172);
            this.lblPKB.Name = "lblPKB";
            this.lblPKB.Size = new System.Drawing.Size(164, 25);
            this.lblPKB.TabIndex = 4;
            this.lblPKB.Text = "Phiếu khám bệnh";
            // 
            // lblMaKham
            // 
            this.lblMaKham.AutoSize = true;
            this.lblMaKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKham.Location = new System.Drawing.Point(85, 89);
            this.lblMaKham.Name = "lblMaKham";
            this.lblMaKham.Size = new System.Drawing.Size(93, 25);
            this.lblMaKham.TabIndex = 0;
            this.lblMaKham.Text = "Mã khám";
            // 
            // btnPhanGiuong
            // 
            this.btnPhanGiuong.AutoSize = true;
            this.btnPhanGiuong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPhanGiuong.FlatAppearance.BorderSize = 0;
            this.btnPhanGiuong.Location = new System.Drawing.Point(1132, 41);
            this.btnPhanGiuong.Name = "btnPhanGiuong";
            this.btnPhanGiuong.Size = new System.Drawing.Size(134, 41);
            this.btnPhanGiuong.TabIndex = 9;
            this.btnPhanGiuong.Text = "Phân gường";
            this.btnPhanGiuong.UseVisualStyleBackColor = false;
            this.btnPhanGiuong.Click += new System.EventHandler(this.btnPhanGiuong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnPhanGiuong);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnChuanDoan);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 673);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 111);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoSize = true;
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Location = new System.Drawing.Point(1284, 41);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(123, 41);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnChuanDoan
            // 
            this.btnChuanDoan.AutoSize = true;
            this.btnChuanDoan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChuanDoan.FlatAppearance.BorderSize = 0;
            this.btnChuanDoan.Location = new System.Drawing.Point(939, 41);
            this.btnChuanDoan.Name = "btnChuanDoan";
            this.btnChuanDoan.Size = new System.Drawing.Size(174, 41);
            this.btnChuanDoan.TabIndex = 7;
            this.btnChuanDoan.Text = "Chuẩn đoán";
            this.btnChuanDoan.UseVisualStyleBackColor = false;
            this.btnChuanDoan.Click += new System.EventHandler(this.btnChuanDoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(530, 41);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(186, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát màn hình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = true;
            this.btnTim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Location = new System.Drawing.Point(741, 41);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(174, 41);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Location = new System.Drawing.Point(361, 41);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 41);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(187, 41);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(6, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDKK
            // 
            this.dgvDKK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDKK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDKK.Location = new System.Drawing.Point(3, 26);
            this.dgvDKK.Name = "dgvDKK";
            this.dgvDKK.RowHeadersWidth = 62;
            this.dgvDKK.RowTemplate.Height = 28;
            this.dgvDKK.Size = new System.Drawing.Size(1407, 414);
            this.dgvDKK.TabIndex = 0;
            this.dgvDKK.SelectionChanged += new System.EventHandler(this.dgvDKK_SelectionChanged);
            this.dgvDKK.Click += new System.EventHandler(this.dgvDKK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDKK);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(39, 809);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 443);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Đăng Ký Khám";
            // 
            // lblDKKHAM
            // 
            this.lblDKKHAM.AutoSize = true;
            this.lblDKKHAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKKHAM.ForeColor = System.Drawing.Color.Red;
            this.lblDKKHAM.Location = new System.Drawing.Point(557, 38);
            this.lblDKKHAM.Name = "lblDKKHAM";
            this.lblDKKHAM.Size = new System.Drawing.Size(394, 69);
            this.lblDKKHAM.TabIndex = 47;
            this.lblDKKHAM.Text = "KHÁM BỆNH";
            // 
            // DangKyKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1504, 981);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblDKKHAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKyKham";
            this.Text = "DangKyKham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DangKyKham_Load);
            this.Click += new System.EventHandler(this.DangKyKham_Click);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKK)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cboNVYeuCau;
        private System.Windows.Forms.Label lblNVYeuCau;
        private System.Windows.Forms.TextBox txtNVYeuCau;
        private System.Windows.Forms.ComboBox cboNVPhuTrach;
        private System.Windows.Forms.ComboBox cboPhieuKhamBenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label lblNVPhuTrach;
        private System.Windows.Forms.TextBox txtNVPhuTrach;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.TextBox txtMaKham;
        private System.Windows.Forms.Label lblPKB;
        private System.Windows.Forms.Label lblMaKham;
        private System.Windows.Forms.Button btnPhanGiuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnChuanDoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDKK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDKKHAM;
    }
}