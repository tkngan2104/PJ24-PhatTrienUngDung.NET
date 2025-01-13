namespace Project_QLBV
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dtpNgXuatHD = new System.Windows.Forms.DateTimePicker();
            this.lblPhong = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTienPTXN = new System.Windows.Forms.TextBox();
            this.lblTienXNPT = new System.Windows.Forms.Label();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.txtTienGiuong = new System.Windows.Forms.TextBox();
            this.lblTienGiuong = new System.Windows.Forms.Label();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.lblBHYTCT = new System.Windows.Forms.Label();
            this.txtBHYTCT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBNThanhToan = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblMaToaThuoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaToaThuoc = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.lblMaTD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(642, 444);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(272, 35);
            this.txtTongTien.TabIndex = 63;
            // 
            // txtMaPK
            // 
            this.txtMaPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPK.Location = new System.Drawing.Point(51, 356);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.ReadOnly = true;
            this.txtMaPK.Size = new System.Drawing.Size(286, 30);
            this.txtMaPK.TabIndex = 53;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHoaDon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 848);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 443);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 26);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(1407, 414);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.Click += new System.EventHandler(this.dgvHoaDon_Click);
            // 
            // dtpNgXuatHD
            // 
            this.dtpNgXuatHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgXuatHD.Location = new System.Drawing.Point(52, 450);
            this.dtpNgXuatHD.Name = "dtpNgXuatHD";
            this.dtpNgXuatHD.Size = new System.Drawing.Size(285, 30);
            this.dtpNgXuatHD.TabIndex = 52;
            this.dtpNgXuatHD.ValueChanged += new System.EventHandler(this.dtpNgXuatHD_ValueChanged);
            this.dtpNgXuatHD.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgXuatHD_Validating);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(47, 413);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(176, 25);
            this.lblPhong.TabIndex = 43;
            this.lblPhong.Text = "Ngày xuất hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTienPTXN);
            this.groupBox4.Controls.Add(this.lblTienXNPT);
            this.groupBox4.Controls.Add(this.lblTienThuoc);
            this.groupBox4.Controls.Add(this.txtTienThuoc);
            this.groupBox4.Controls.Add(this.txtTienGiuong);
            this.groupBox4.Controls.Add(this.lblTienGiuong);
            this.groupBox4.Controls.Add(this.txtTienKham);
            this.groupBox4.Controls.Add(this.lblTienKham);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(457, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(986, 254);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Thanh Toán";
            // 
            // txtTienPTXN
            // 
            this.txtTienPTXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPTXN.Location = new System.Drawing.Point(737, 68);
            this.txtTienPTXN.Name = "txtTienPTXN";
            this.txtTienPTXN.ReadOnly = true;
            this.txtTienPTXN.Size = new System.Drawing.Size(187, 30);
            this.txtTienPTXN.TabIndex = 57;
            // 
            // lblTienXNPT
            // 
            this.lblTienXNPT.AutoSize = true;
            this.lblTienXNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienXNPT.Location = new System.Drawing.Point(470, 71);
            this.lblTienXNPT.Name = "lblTienXNPT";
            this.lblTienXNPT.Size = new System.Drawing.Size(248, 25);
            this.lblTienXNPT.TabIndex = 58;
            this.lblTienXNPT.Text = "Tiền xét nghiệm phẩu thuật";
            // 
            // lblTienThuoc
            // 
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThuoc.Location = new System.Drawing.Point(470, 159);
            this.lblTienThuoc.Name = "lblTienThuoc";
            this.lblTienThuoc.Size = new System.Drawing.Size(104, 25);
            this.lblTienThuoc.TabIndex = 49;
            this.lblTienThuoc.Text = "Tiền thuốc";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThuoc.Location = new System.Drawing.Point(602, 156);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.ReadOnly = true;
            this.txtTienThuoc.Size = new System.Drawing.Size(189, 30);
            this.txtTienThuoc.TabIndex = 42;
            // 
            // txtTienGiuong
            // 
            this.txtTienGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienGiuong.Location = new System.Drawing.Point(194, 156);
            this.txtTienGiuong.Name = "txtTienGiuong";
            this.txtTienGiuong.ReadOnly = true;
            this.txtTienGiuong.Size = new System.Drawing.Size(189, 30);
            this.txtTienGiuong.TabIndex = 55;
            // 
            // lblTienGiuong
            // 
            this.lblTienGiuong.AutoSize = true;
            this.lblTienGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienGiuong.Location = new System.Drawing.Point(62, 159);
            this.lblTienGiuong.Name = "lblTienGiuong";
            this.lblTienGiuong.Size = new System.Drawing.Size(115, 25);
            this.lblTienGiuong.TabIndex = 56;
            this.lblTienGiuong.Text = "Tiền giường";
            // 
            // txtTienKham
            // 
            this.txtTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKham.Location = new System.Drawing.Point(194, 68);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.ReadOnly = true;
            this.txtTienKham.Size = new System.Drawing.Size(189, 30);
            this.txtTienKham.TabIndex = 53;
            // 
            // lblTienKham
            // 
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienKham.Location = new System.Drawing.Point(62, 73);
            this.lblTienKham.Name = "lblTienKham";
            this.lblTienKham.Size = new System.Drawing.Size(104, 25);
            this.lblTienKham.TabIndex = 54;
            this.lblTienKham.Text = "Tiền khám";
            // 
            // lblBHYTCT
            // 
            this.lblBHYTCT.AutoSize = true;
            this.lblBHYTCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBHYTCT.ForeColor = System.Drawing.Color.Navy;
            this.lblBHYTCT.Location = new System.Drawing.Point(984, 450);
            this.lblBHYTCT.Name = "lblBHYTCT";
            this.lblBHYTCT.Size = new System.Drawing.Size(160, 29);
            this.lblBHYTCT.TabIndex = 65;
            this.lblBHYTCT.Text = "BHYT chi trả";
            // 
            // txtBHYTCT
            // 
            this.txtBHYTCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBHYTCT.Location = new System.Drawing.Point(1173, 444);
            this.txtBHYTCT.Name = "txtBHYTCT";
            this.txtBHYTCT.ReadOnly = true;
            this.txtBHYTCT.Size = new System.Drawing.Size(272, 35);
            this.txtBHYTCT.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(452, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "Bệnh nhân thanh toán";
            // 
            // txtBNThanhToan
            // 
            this.txtBNThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNThanhToan.Location = new System.Drawing.Point(756, 562);
            this.txtBNThanhToan.Name = "txtBNThanhToan";
            this.txtBNThanhToan.ReadOnly = true;
            this.txtBNThanhToan.Size = new System.Drawing.Size(388, 35);
            this.txtBNThanhToan.TabIndex = 68;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgay.Location = new System.Drawing.Point(1119, 84);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(322, 26);
            this.dtpNgay.TabIndex = 70;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // lblMaToaThuoc
            // 
            this.lblMaToaThuoc.AutoSize = true;
            this.lblMaToaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaToaThuoc.Location = new System.Drawing.Point(47, 187);
            this.lblMaToaThuoc.Name = "lblMaToaThuoc";
            this.lblMaToaThuoc.Size = new System.Drawing.Size(125, 25);
            this.lblMaToaThuoc.TabIndex = 7;
            this.lblMaToaThuoc.Text = "Mã toa thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1054, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 69;
            this.label3.Text = "Ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPK);
            this.groupBox2.Controls.Add(this.dtpNgXuatHD);
            this.groupBox2.Controls.Add(this.lblPhong);
            this.groupBox2.Controls.Add(this.lblMaToaThuoc);
            this.groupBox2.Controls.Add(this.txtMaToaThuoc);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.lblMaPK);
            this.groupBox2.Controls.Add(this.lblMaTD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 555);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tinh Hóa Đơn";
            // 
            // txtMaToaThuoc
            // 
            this.txtMaToaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaToaThuoc.Location = new System.Drawing.Point(51, 224);
            this.txtMaToaThuoc.Name = "txtMaToaThuoc";
            this.txtMaToaThuoc.ReadOnly = true;
            this.txtMaToaThuoc.Size = new System.Drawing.Size(286, 30);
            this.txtMaToaThuoc.TabIndex = 8;
            this.txtMaToaThuoc.TextChanged += new System.EventHandler(this.txtMaToaThuoc_TextChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(52, 111);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(285, 30);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHD_KeyPress);
            // 
            // lblMaPK
            // 
            this.lblMaPK.AutoSize = true;
            this.lblMaPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPK.Location = new System.Drawing.Point(47, 299);
            this.lblMaPK.Name = "lblMaPK";
            this.lblMaPK.Size = new System.Drawing.Size(146, 25);
            this.lblMaPK.TabIndex = 4;
            this.lblMaPK.Text = "Mã phiếu khám";
            // 
            // lblMaTD
            // 
            this.lblMaTD.AutoSize = true;
            this.lblMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTD.Location = new System.Drawing.Point(47, 73);
            this.lblMaTD.Name = "lblMaTD";
            this.lblMaTD.Size = new System.Drawing.Size(116, 25);
            this.lblMaTD.TabIndex = 0;
            this.lblMaTD.Text = "Mã hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 710);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 106);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(1017, 42);
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
            this.btnSua.Location = new System.Drawing.Point(739, 42);
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
            this.btnXoa.Location = new System.Drawing.Point(452, 42);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(233, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(173, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.Red;
            this.lblHoaDon.Location = new System.Drawing.Point(594, 22);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(316, 69);
            this.lblHoaDon.TabIndex = 59;
            this.lblHoaDon.Text = "HÓA ĐƠN";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Navy;
            this.lblTongTien.Location = new System.Drawing.Point(452, 450);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(124, 29);
            this.lblTongTien.TabIndex = 62;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1502, 1050);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblBHYTCT);
            this.Controls.Add(this.txtBHYTCT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBNThanhToan);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblTongTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgXuatHD;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTienPTXN;
        private System.Windows.Forms.Label lblTienXNPT;
        private System.Windows.Forms.Label lblTienThuoc;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.TextBox txtTienGiuong;
        private System.Windows.Forms.Label lblTienGiuong;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.Label lblTienKham;
        private System.Windows.Forms.Label lblBHYTCT;
        private System.Windows.Forms.TextBox txtBHYTCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBNThanhToan;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lblMaToaThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaToaThuoc;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaPK;
        private System.Windows.Forms.Label lblMaTD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblTongTien;
    }
}