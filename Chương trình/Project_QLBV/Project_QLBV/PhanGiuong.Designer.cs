namespace Project_QLBV
{
    partial class PhanGiuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanGiuong));
            this.txtMaYeuCau = new System.Windows.Forms.TextBox();
            this.cboMaLCT = new System.Windows.Forms.ComboBox();
            this.lblMaLoaiCT = new System.Windows.Forms.Label();
            this.cboMaLBA = new System.Windows.Forms.ComboBox();
            this.dtpNgTraGiuong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgNhanGiuong = new System.Windows.Forms.DateTimePicker();
            this.txtTenGiuong = new System.Windows.Forms.TextBox();
            this.cboMaGiuong = new System.Windows.Forms.ComboBox();
            this.lblNgTraGiuong = new System.Windows.Forms.Label();
            this.lblMaPKB = new System.Windows.Forms.Label();
            this.txtMaPKB = new System.Windows.Forms.TextBox();
            this.lblMaGiuong = new System.Windows.Forms.Label();
            this.lblNgNhanGiuong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblMaLBA = new System.Windows.Forms.Label();
            this.lblTenGiuong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblMaYeuCau = new System.Windows.Forms.Label();
            this.dgvPhanGiuong = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblPhanGiuong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTheoDoiSK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanGiuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaYeuCau
            // 
            this.txtMaYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaYeuCau.Location = new System.Drawing.Point(302, 61);
            this.txtMaYeuCau.Multiline = true;
            this.txtMaYeuCau.Name = "txtMaYeuCau";
            this.txtMaYeuCau.ReadOnly = true;
            this.txtMaYeuCau.Size = new System.Drawing.Size(321, 30);
            this.txtMaYeuCau.TabIndex = 38;
            this.txtMaYeuCau.TextChanged += new System.EventHandler(this.txtMaYeuCau_TextChanged);
            // 
            // cboMaLCT
            // 
            this.cboMaLCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLCT.FormattingEnabled = true;
            this.cboMaLCT.Location = new System.Drawing.Point(994, 380);
            this.cboMaLCT.Name = "cboMaLCT";
            this.cboMaLCT.Size = new System.Drawing.Size(321, 33);
            this.cboMaLCT.TabIndex = 37;
            // 
            // lblMaLoaiCT
            // 
            this.lblMaLoaiCT.AutoSize = true;
            this.lblMaLoaiCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiCT.Location = new System.Drawing.Point(771, 388);
            this.lblMaLoaiCT.Name = "lblMaLoaiCT";
            this.lblMaLoaiCT.Size = new System.Drawing.Size(135, 25);
            this.lblMaLoaiCT.TabIndex = 36;
            this.lblMaLoaiCT.Text = "Mã loại chi tiết";
            // 
            // cboMaLBA
            // 
            this.cboMaLBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLBA.FormattingEnabled = true;
            this.cboMaLBA.Location = new System.Drawing.Point(994, 301);
            this.cboMaLBA.Name = "cboMaLBA";
            this.cboMaLBA.Size = new System.Drawing.Size(321, 33);
            this.cboMaLBA.TabIndex = 35;
            // 
            // dtpNgTraGiuong
            // 
            this.dtpNgTraGiuong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgTraGiuong.Location = new System.Drawing.Point(994, 142);
            this.dtpNgTraGiuong.Name = "dtpNgTraGiuong";
            this.dtpNgTraGiuong.Size = new System.Drawing.Size(321, 30);
            this.dtpNgTraGiuong.TabIndex = 34;
            this.dtpNgTraGiuong.ValueChanged += new System.EventHandler(this.dtpNgTraGiuong_ValueChanged);
            this.dtpNgTraGiuong.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgTraGiuong_Validating);
            // 
            // dtpNgNhanGiuong
            // 
            this.dtpNgNhanGiuong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgNhanGiuong.Location = new System.Drawing.Point(994, 56);
            this.dtpNgNhanGiuong.Name = "dtpNgNhanGiuong";
            this.dtpNgNhanGiuong.Size = new System.Drawing.Size(321, 30);
            this.dtpNgNhanGiuong.TabIndex = 33;
            this.dtpNgNhanGiuong.ValueChanged += new System.EventHandler(this.dtpNgNhanGiuong_ValueChanged);
            this.dtpNgNhanGiuong.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgNhanGiuong_Validating);
            // 
            // txtTenGiuong
            // 
            this.txtTenGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGiuong.Location = new System.Drawing.Point(302, 306);
            this.txtTenGiuong.Multiline = true;
            this.txtTenGiuong.Name = "txtTenGiuong";
            this.txtTenGiuong.ReadOnly = true;
            this.txtTenGiuong.Size = new System.Drawing.Size(321, 30);
            this.txtTenGiuong.TabIndex = 32;
            // 
            // cboMaGiuong
            // 
            this.cboMaGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaGiuong.FormattingEnabled = true;
            this.cboMaGiuong.Location = new System.Drawing.Point(302, 224);
            this.cboMaGiuong.Name = "cboMaGiuong";
            this.cboMaGiuong.Size = new System.Drawing.Size(321, 33);
            this.cboMaGiuong.TabIndex = 31;
            this.cboMaGiuong.SelectedIndexChanged += new System.EventHandler(this.cboMaGiuong_SelectedIndexChanged);
            // 
            // lblNgTraGiuong
            // 
            this.lblNgTraGiuong.AutoSize = true;
            this.lblNgTraGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgTraGiuong.Location = new System.Drawing.Point(771, 147);
            this.lblNgTraGiuong.Name = "lblNgTraGiuong";
            this.lblNgTraGiuong.Size = new System.Drawing.Size(149, 25);
            this.lblNgTraGiuong.TabIndex = 28;
            this.lblNgTraGiuong.Text = "Ngày trả giường";
            // 
            // lblMaPKB
            // 
            this.lblMaPKB.AutoSize = true;
            this.lblMaPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPKB.Location = new System.Drawing.Point(771, 227);
            this.lblMaPKB.Name = "lblMaPKB";
            this.lblMaPKB.Size = new System.Drawing.Size(195, 25);
            this.lblMaPKB.TabIndex = 7;
            this.lblMaPKB.Text = "Mã phiếu khám bệnh";
            // 
            // txtMaPKB
            // 
            this.txtMaPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPKB.Location = new System.Drawing.Point(994, 222);
            this.txtMaPKB.Name = "txtMaPKB";
            this.txtMaPKB.ReadOnly = true;
            this.txtMaPKB.Size = new System.Drawing.Size(321, 30);
            this.txtMaPKB.TabIndex = 8;
            this.txtMaPKB.TextChanged += new System.EventHandler(this.txtMaPKB_TextChanged);
            // 
            // lblMaGiuong
            // 
            this.lblMaGiuong.AutoSize = true;
            this.lblMaGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiuong.Location = new System.Drawing.Point(79, 227);
            this.lblMaGiuong.Name = "lblMaGiuong";
            this.lblMaGiuong.Size = new System.Drawing.Size(104, 25);
            this.lblMaGiuong.TabIndex = 20;
            this.lblMaGiuong.Text = "Mã giường";
            // 
            // lblNgNhanGiuong
            // 
            this.lblNgNhanGiuong.AutoSize = true;
            this.lblNgNhanGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgNhanGiuong.Location = new System.Drawing.Point(771, 61);
            this.lblNgNhanGiuong.Name = "lblNgNhanGiuong";
            this.lblNgNhanGiuong.Size = new System.Drawing.Size(171, 25);
            this.lblNgNhanGiuong.TabIndex = 15;
            this.lblNgNhanGiuong.Text = "Ngày nhận giường";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(302, 144);
            this.txtPhong.Multiline = true;
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(321, 30);
            this.txtPhong.TabIndex = 19;
            this.txtPhong.TextChanged += new System.EventHandler(this.txtPhong_TextChanged);
            // 
            // lblMaLBA
            // 
            this.lblMaLBA.AutoSize = true;
            this.lblMaLBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLBA.Location = new System.Drawing.Point(771, 309);
            this.lblMaLBA.Name = "lblMaLBA";
            this.lblMaLBA.Size = new System.Drawing.Size(151, 25);
            this.lblMaLBA.TabIndex = 6;
            this.lblMaLBA.Text = "Mã loại bệnh án";
            // 
            // lblTenGiuong
            // 
            this.lblTenGiuong.AutoSize = true;
            this.lblTenGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGiuong.Location = new System.Drawing.Point(79, 309);
            this.lblTenGiuong.Name = "lblTenGiuong";
            this.lblTenGiuong.Size = new System.Drawing.Size(111, 25);
            this.lblTenGiuong.TabIndex = 2;
            this.lblTenGiuong.Text = "Tên giường";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(79, 147);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(69, 25);
            this.lblPhong.TabIndex = 4;
            this.lblPhong.Text = "Phòng";
            // 
            // lblMaYeuCau
            // 
            this.lblMaYeuCau.AutoSize = true;
            this.lblMaYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaYeuCau.Location = new System.Drawing.Point(79, 64);
            this.lblMaYeuCau.Name = "lblMaYeuCau";
            this.lblMaYeuCau.Size = new System.Drawing.Size(114, 25);
            this.lblMaYeuCau.TabIndex = 0;
            this.lblMaYeuCau.Text = "Mã yêu cầu";
            // 
            // dgvPhanGiuong
            // 
            this.dgvPhanGiuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanGiuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhanGiuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanGiuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanGiuong.Location = new System.Drawing.Point(3, 26);
            this.dgvPhanGiuong.Name = "dgvPhanGiuong";
            this.dgvPhanGiuong.RowHeadersWidth = 62;
            this.dgvPhanGiuong.RowTemplate.Height = 28;
            this.dgvPhanGiuong.Size = new System.Drawing.Size(1407, 414);
            this.dgvPhanGiuong.TabIndex = 0;
            this.dgvPhanGiuong.Click += new System.EventHandler(this.dgvPhanGiuong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhanGiuong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(40, 734);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 443);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phân Giường";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXuatHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(1207, 42);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(183, 41);
            this.btnXuatHoaDon.TabIndex = 7;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Location = new System.Drawing.Point(461, 42);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(166, 41);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(242, 42);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblPhanGiuong
            // 
            this.lblPhanGiuong.AutoSize = true;
            this.lblPhanGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanGiuong.ForeColor = System.Drawing.Color.Red;
            this.lblPhanGiuong.Location = new System.Drawing.Point(490, 13);
            this.lblPhanGiuong.Name = "lblPhanGiuong";
            this.lblPhanGiuong.Size = new System.Drawing.Size(467, 69);
            this.lblPhanGiuong.TabIndex = 26;
            this.lblPhanGiuong.Text = "PHÂN GIƯỜNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTheoDoiSK);
            this.groupBox1.Controls.Add(this.btnXuatHoaDon);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 598);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 106);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            // 
            // btnTheoDoiSK
            // 
            this.btnTheoDoiSK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTheoDoiSK.FlatAppearance.BorderSize = 0;
            this.btnTheoDoiSK.Location = new System.Drawing.Point(921, 42);
            this.btnTheoDoiSK.Name = "btnTheoDoiSK";
            this.btnTheoDoiSK.Size = new System.Drawing.Size(229, 41);
            this.btnTheoDoiSK.TabIndex = 8;
            this.btnTheoDoiSK.Text = "Theo dõi sức khỏe";
            this.btnTheoDoiSK.UseVisualStyleBackColor = false;
            this.btnTheoDoiSK.Click += new System.EventHandler(this.btnTheoDoiSK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(690, 42);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(176, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát màn hình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(19, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(164, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaYeuCau);
            this.groupBox2.Controls.Add(this.cboMaLCT);
            this.groupBox2.Controls.Add(this.lblMaLoaiCT);
            this.groupBox2.Controls.Add(this.cboMaLBA);
            this.groupBox2.Controls.Add(this.dtpNgTraGiuong);
            this.groupBox2.Controls.Add(this.dtpNgNhanGiuong);
            this.groupBox2.Controls.Add(this.txtTenGiuong);
            this.groupBox2.Controls.Add(this.cboMaGiuong);
            this.groupBox2.Controls.Add(this.lblNgTraGiuong);
            this.groupBox2.Controls.Add(this.lblMaPKB);
            this.groupBox2.Controls.Add(this.txtMaPKB);
            this.groupBox2.Controls.Add(this.lblMaGiuong);
            this.groupBox2.Controls.Add(this.lblNgNhanGiuong);
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.lblMaLBA);
            this.groupBox2.Controls.Add(this.lblTenGiuong);
            this.groupBox2.Controls.Add(this.lblPhong);
            this.groupBox2.Controls.Add(this.lblMaYeuCau);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 451);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phân Giường";
            // 
            // PhanGiuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1550, 873);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblPhanGiuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhanGiuong";
            this.Text = "PhanGiuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhanGiuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanGiuong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaYeuCau;
        private System.Windows.Forms.ComboBox cboMaLCT;
        private System.Windows.Forms.Label lblMaLoaiCT;
        private System.Windows.Forms.ComboBox cboMaLBA;
        private System.Windows.Forms.DateTimePicker dtpNgTraGiuong;
        private System.Windows.Forms.DateTimePicker dtpNgNhanGiuong;
        private System.Windows.Forms.TextBox txtTenGiuong;
        private System.Windows.Forms.ComboBox cboMaGiuong;
        private System.Windows.Forms.Label lblNgTraGiuong;
        private System.Windows.Forms.Label lblMaPKB;
        private System.Windows.Forms.TextBox txtMaPKB;
        private System.Windows.Forms.Label lblMaGiuong;
        private System.Windows.Forms.Label lblNgNhanGiuong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblMaLBA;
        private System.Windows.Forms.Label lblTenGiuong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblMaYeuCau;
        private System.Windows.Forms.DataGridView dgvPhanGiuong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblPhanGiuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTheoDoiSK;
    }
}