namespace Project_QLBV
{
    partial class ChuanDoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuanDoan));
            this.btnKeToaThuoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaYC = new System.Windows.Forms.TextBox();
            this.txtMSPhieuKhamBenh = new System.Windows.Forms.TextBox();
            this.rtfLoiKhuyen = new System.Windows.Forms.RichTextBox();
            this.lblLoiKhuyen = new System.Windows.Forms.Label();
            this.cboLoaiBA = new System.Windows.Forms.ComboBox();
            this.lblLoaiBA = new System.Windows.Forms.Label();
            this.rtfTrieuChung = new System.Windows.Forms.RichTextBox();
            this.txtNVYC = new System.Windows.Forms.TextBox();
            this.txtMaBenh = new System.Windows.Forms.TextBox();
            this.lblNVYC = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.lblMaBenh = new System.Windows.Forms.Label();
            this.lblMaYC = new System.Windows.Forms.Label();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.lblMaPKB = new System.Windows.Forms.Label();
            this.lblMaCD = new System.Windows.Forms.Label();
            this.btnTimChuaKeTT = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.btnTimDaKeTT = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChuanDoan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblChuanDoan = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuanDoan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKeToaThuoc
            // 
            this.btnKeToaThuoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKeToaThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKeToaThuoc.FlatAppearance.BorderSize = 0;
            this.btnKeToaThuoc.Location = new System.Drawing.Point(721, 39);
            this.btnKeToaThuoc.Name = "btnKeToaThuoc";
            this.btnKeToaThuoc.Size = new System.Drawing.Size(143, 41);
            this.btnKeToaThuoc.TabIndex = 7;
            this.btnKeToaThuoc.Text = "Kê toa thuốc";
            this.btnKeToaThuoc.UseVisualStyleBackColor = false;
            this.btnKeToaThuoc.Click += new System.EventHandler(this.btnKeToaThuoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1011, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ngày khám";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.txtMaYC);
            this.groupBox2.Controls.Add(this.txtMSPhieuKhamBenh);
            this.groupBox2.Controls.Add(this.rtfLoiKhuyen);
            this.groupBox2.Controls.Add(this.lblLoiKhuyen);
            this.groupBox2.Controls.Add(this.cboLoaiBA);
            this.groupBox2.Controls.Add(this.lblLoaiBA);
            this.groupBox2.Controls.Add(this.rtfTrieuChung);
            this.groupBox2.Controls.Add(this.txtNVYC);
            this.groupBox2.Controls.Add(this.txtMaBenh);
            this.groupBox2.Controls.Add(this.lblNVYC);
            this.groupBox2.Controls.Add(this.lblTenPhong);
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.txtKetLuan);
            this.groupBox2.Controls.Add(this.lblMaBenh);
            this.groupBox2.Controls.Add(this.lblMaYC);
            this.groupBox2.Controls.Add(this.lblKetLuan);
            this.groupBox2.Controls.Add(this.lblTrieuChung);
            this.groupBox2.Controls.Add(this.txtMaCD);
            this.groupBox2.Controls.Add(this.lblMaPKB);
            this.groupBox2.Controls.Add(this.lblMaCD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 600);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chuẩn Đoán";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(293, 419);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(324, 30);
            this.txtTenNV.TabIndex = 48;
            // 
            // txtMaYC
            // 
            this.txtMaYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaYC.Location = new System.Drawing.Point(293, 301);
            this.txtMaYC.Name = "txtMaYC";
            this.txtMaYC.ReadOnly = true;
            this.txtMaYC.Size = new System.Drawing.Size(324, 30);
            this.txtMaYC.TabIndex = 47;
            this.txtMaYC.TextChanged += new System.EventHandler(this.txtMaYC_TextChanged);
            // 
            // txtMSPhieuKhamBenh
            // 
            this.txtMSPhieuKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSPhieuKhamBenh.Location = new System.Drawing.Point(296, 139);
            this.txtMSPhieuKhamBenh.Name = "txtMSPhieuKhamBenh";
            this.txtMSPhieuKhamBenh.ReadOnly = true;
            this.txtMSPhieuKhamBenh.Size = new System.Drawing.Size(321, 30);
            this.txtMSPhieuKhamBenh.TabIndex = 46;
            // 
            // rtfLoiKhuyen
            // 
            this.rtfLoiKhuyen.Location = new System.Drawing.Point(293, 469);
            this.rtfLoiKhuyen.Name = "rtfLoiKhuyen";
            this.rtfLoiKhuyen.Size = new System.Drawing.Size(1010, 105);
            this.rtfLoiKhuyen.TabIndex = 45;
            this.rtfLoiKhuyen.Text = "";
            this.rtfLoiKhuyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfLoiKhuyen_KeyPress);
            // 
            // lblLoiKhuyen
            // 
            this.lblLoiKhuyen.AutoSize = true;
            this.lblLoiKhuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiKhuyen.Location = new System.Drawing.Point(92, 469);
            this.lblLoiKhuyen.Name = "lblLoiKhuyen";
            this.lblLoiKhuyen.Size = new System.Drawing.Size(107, 25);
            this.lblLoiKhuyen.TabIndex = 44;
            this.lblLoiKhuyen.Text = "Lời khuyên";
            // 
            // cboLoaiBA
            // 
            this.cboLoaiBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBA.FormattingEnabled = true;
            this.cboLoaiBA.Location = new System.Drawing.Point(980, 55);
            this.cboLoaiBA.Name = "cboLoaiBA";
            this.cboLoaiBA.Size = new System.Drawing.Size(324, 33);
            this.cboLoaiBA.TabIndex = 43;
            // 
            // lblLoaiBA
            // 
            this.lblLoaiBA.AutoSize = true;
            this.lblLoaiBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiBA.Location = new System.Drawing.Point(782, 61);
            this.lblLoaiBA.Name = "lblLoaiBA";
            this.lblLoaiBA.Size = new System.Drawing.Size(125, 25);
            this.lblLoaiBA.TabIndex = 42;
            this.lblLoaiBA.Text = "Loại bệnh án";
            // 
            // rtfTrieuChung
            // 
            this.rtfTrieuChung.Location = new System.Drawing.Point(979, 224);
            this.rtfTrieuChung.Name = "rtfTrieuChung";
            this.rtfTrieuChung.ReadOnly = true;
            this.rtfTrieuChung.Size = new System.Drawing.Size(324, 105);
            this.rtfTrieuChung.TabIndex = 41;
            this.rtfTrieuChung.Text = "";
            // 
            // txtNVYC
            // 
            this.txtNVYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVYC.Location = new System.Drawing.Point(293, 365);
            this.txtNVYC.Name = "txtNVYC";
            this.txtNVYC.ReadOnly = true;
            this.txtNVYC.Size = new System.Drawing.Size(324, 30);
            this.txtNVYC.TabIndex = 40;
            this.txtNVYC.TextChanged += new System.EventHandler(this.txtNVYC_TextChanged);
            // 
            // txtMaBenh
            // 
            this.txtMaBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenh.Location = new System.Drawing.Point(293, 224);
            this.txtMaBenh.Name = "txtMaBenh";
            this.txtMaBenh.Size = new System.Drawing.Size(324, 30);
            this.txtMaBenh.TabIndex = 38;
            // 
            // lblNVYC
            // 
            this.lblNVYC.AutoSize = true;
            this.lblNVYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVYC.Location = new System.Drawing.Point(92, 368);
            this.lblNVYC.Name = "lblNVYC";
            this.lblNVYC.Size = new System.Drawing.Size(174, 25);
            this.lblNVYC.TabIndex = 36;
            this.lblNVYC.Text = "Nhân viên yêu cầu";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(781, 144);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(107, 25);
            this.lblTenPhong.TabIndex = 31;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(979, 141);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(324, 30);
            this.txtTenPhong.TabIndex = 32;
            // 
            // txtKetLuan
            // 
            this.txtKetLuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetLuan.Location = new System.Drawing.Point(979, 383);
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.Size = new System.Drawing.Size(324, 30);
            this.txtKetLuan.TabIndex = 26;
            this.txtKetLuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKetLuan_KeyPress);
            // 
            // lblMaBenh
            // 
            this.lblMaBenh.AutoSize = true;
            this.lblMaBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenh.Location = new System.Drawing.Point(92, 224);
            this.lblMaBenh.Name = "lblMaBenh";
            this.lblMaBenh.Size = new System.Drawing.Size(89, 25);
            this.lblMaBenh.TabIndex = 7;
            this.lblMaBenh.Text = "Mã bệnh";
            // 
            // lblMaYC
            // 
            this.lblMaYC.AutoSize = true;
            this.lblMaYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaYC.Location = new System.Drawing.Point(92, 306);
            this.lblMaYC.Name = "lblMaYC";
            this.lblMaYC.Size = new System.Drawing.Size(114, 25);
            this.lblMaYC.TabIndex = 20;
            this.lblMaYC.Text = "Mã yêu cầu";
            // 
            // lblKetLuan
            // 
            this.lblKetLuan.AutoSize = true;
            this.lblKetLuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetLuan.Location = new System.Drawing.Point(781, 388);
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.Size = new System.Drawing.Size(84, 25);
            this.lblKetLuan.TabIndex = 6;
            this.lblKetLuan.Text = "Kết luận";
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrieuChung.Location = new System.Drawing.Point(782, 224);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(116, 25);
            this.lblTrieuChung.TabIndex = 2;
            this.lblTrieuChung.Text = "Triệu chứng";
            // 
            // txtMaCD
            // 
            this.txtMaCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCD.Location = new System.Drawing.Point(296, 58);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.ReadOnly = true;
            this.txtMaCD.Size = new System.Drawing.Size(321, 30);
            this.txtMaCD.TabIndex = 1;
            this.txtMaCD.TextChanged += new System.EventHandler(this.txtMaCD_TextChanged);
            this.txtMaCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaCD_KeyPress);
            // 
            // lblMaPKB
            // 
            this.lblMaPKB.AutoSize = true;
            this.lblMaPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPKB.Location = new System.Drawing.Point(92, 144);
            this.lblMaPKB.Name = "lblMaPKB";
            this.lblMaPKB.Size = new System.Drawing.Size(195, 25);
            this.lblMaPKB.TabIndex = 4;
            this.lblMaPKB.Text = "Mã phiếu khám bệnh";
            // 
            // lblMaCD
            // 
            this.lblMaCD.AutoSize = true;
            this.lblMaCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCD.Location = new System.Drawing.Point(92, 61);
            this.lblMaCD.Name = "lblMaCD";
            this.lblMaCD.Size = new System.Drawing.Size(148, 25);
            this.lblMaCD.TabIndex = 0;
            this.lblMaCD.Text = "Mã chuẩn đoán";
            // 
            // btnTimChuaKeTT
            // 
            this.btnTimChuaKeTT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimChuaKeTT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimChuaKeTT.FlatAppearance.BorderSize = 0;
            this.btnTimChuaKeTT.Location = new System.Drawing.Point(1058, 39);
            this.btnTimChuaKeTT.Name = "btnTimChuaKeTT";
            this.btnTimChuaKeTT.Size = new System.Drawing.Size(143, 41);
            this.btnTimChuaKeTT.TabIndex = 8;
            this.btnTimChuaKeTT.Text = "Chưa kê toa";
            this.btnTimChuaKeTT.UseVisualStyleBackColor = false;
            this.btnTimChuaKeTT.Click += new System.EventHandler(this.btnTimChuaKeTT_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(1115, 79);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(307, 26);
            this.dtpNgay.TabIndex = 36;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(540, 39);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát màn hình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemDS);
            this.groupBox1.Controls.Add(this.btnTimChuaKeTT);
            this.groupBox1.Controls.Add(this.btnKeToaThuoc);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTimDaKeTT);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 747);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 106);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            // 
            // btnXemDS
            // 
            this.btnXemDS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXemDS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemDS.FlatAppearance.BorderSize = 0;
            this.btnXemDS.Location = new System.Drawing.Point(1226, 39);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(158, 41);
            this.btnXemDS.TabIndex = 9;
            this.btnXemDS.Text = "Xem danh sách";
            this.btnXemDS.UseVisualStyleBackColor = false;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // btnTimDaKeTT
            // 
            this.btnTimDaKeTT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimDaKeTT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimDaKeTT.FlatAppearance.BorderSize = 0;
            this.btnTimDaKeTT.Location = new System.Drawing.Point(890, 39);
            this.btnTimDaKeTT.Name = "btnTimDaKeTT";
            this.btnTimDaKeTT.Size = new System.Drawing.Size(143, 41);
            this.btnTimDaKeTT.TabIndex = 5;
            this.btnTimDaKeTT.Text = "Đã kê toa";
            this.btnTimDaKeTT.UseVisualStyleBackColor = false;
            this.btnTimDaKeTT.Click += new System.EventHandler(this.btnTimDaKeTT_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Location = new System.Drawing.Point(370, 39);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 41);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(199, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(28, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(143, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvChuanDoan
            // 
            this.dgvChuanDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuanDoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChuanDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuanDoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuanDoan.Location = new System.Drawing.Point(3, 26);
            this.dgvChuanDoan.Name = "dgvChuanDoan";
            this.dgvChuanDoan.RowHeadersWidth = 62;
            this.dgvChuanDoan.RowTemplate.Height = 28;
            this.dgvChuanDoan.Size = new System.Drawing.Size(1407, 414);
            this.dgvChuanDoan.TabIndex = 0;
            this.dgvChuanDoan.Click += new System.EventHandler(this.dgvChuanDoan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvChuanDoan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 883);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 443);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Chuẩn Đoán";
            // 
            // lblChuanDoan
            // 
            this.lblChuanDoan.AutoSize = true;
            this.lblChuanDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuanDoan.ForeColor = System.Drawing.Color.Red;
            this.lblChuanDoan.Location = new System.Drawing.Point(498, 16);
            this.lblChuanDoan.Name = "lblChuanDoan";
            this.lblChuanDoan.Size = new System.Drawing.Size(441, 69);
            this.lblChuanDoan.TabIndex = 32;
            this.lblChuanDoan.Text = "CHUẨN ĐOÁN";
            // 
            // ChuanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1489, 1017);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblChuanDoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChuanDoan";
            this.Text = "ChuanDoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChuanDoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuanDoan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeToaThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaYC;
        private System.Windows.Forms.TextBox txtMSPhieuKhamBenh;
        private System.Windows.Forms.RichTextBox rtfLoiKhuyen;
        private System.Windows.Forms.Label lblLoiKhuyen;
        private System.Windows.Forms.ComboBox cboLoaiBA;
        private System.Windows.Forms.Label lblLoaiBA;
        private System.Windows.Forms.RichTextBox rtfTrieuChung;
        private System.Windows.Forms.TextBox txtNVYC;
        private System.Windows.Forms.TextBox txtMaBenh;
        private System.Windows.Forms.Label lblNVYC;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtKetLuan;
        private System.Windows.Forms.Label lblMaBenh;
        private System.Windows.Forms.Label lblMaYC;
        private System.Windows.Forms.Label lblKetLuan;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.Label lblMaPKB;
        private System.Windows.Forms.Label lblMaCD;
        private System.Windows.Forms.Button btnTimChuaKeTT;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimDaKeTT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChuanDoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblChuanDoan;
        private System.Windows.Forms.Button btnXemDS;
    }
}