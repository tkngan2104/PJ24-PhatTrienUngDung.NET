namespace Project_QLBV
{
    partial class PhongKham
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.radPhongBenh = new System.Windows.Forms.RadioButton();
            this.radPhongKham = new System.Windows.Forms.RadioButton();
            this.radPhongChucNang = new System.Windows.Forms.RadioButton();
            this.numSoGiuong = new System.Windows.Forms.NumericUpDown();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblSoGiuong = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblQLPhongKham = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.dgvDanhSachPhongKham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGiuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhongKham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(863, 41);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(233, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát màn hình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Location = new System.Drawing.Point(1155, 41);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(233, 41);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Location = new System.Drawing.Point(585, 41);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(233, 41);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(19, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 106);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(298, 41);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(233, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // radPhongBenh
            // 
            this.radPhongBenh.AutoSize = true;
            this.radPhongBenh.Location = new System.Drawing.Point(1017, 230);
            this.radPhongBenh.Name = "radPhongBenh";
            this.radPhongBenh.Size = new System.Drawing.Size(143, 29);
            this.radPhongBenh.TabIndex = 23;
            this.radPhongBenh.Text = "Phòng bệnh";
            this.radPhongBenh.UseVisualStyleBackColor = true;
            // 
            // radPhongKham
            // 
            this.radPhongKham.AutoSize = true;
            this.radPhongKham.Checked = true;
            this.radPhongKham.Location = new System.Drawing.Point(235, 226);
            this.radPhongKham.Name = "radPhongKham";
            this.radPhongKham.Size = new System.Drawing.Size(147, 29);
            this.radPhongKham.TabIndex = 22;
            this.radPhongKham.TabStop = true;
            this.radPhongKham.Text = "Phòng khám";
            this.radPhongKham.UseVisualStyleBackColor = true;
            // 
            // radPhongChucNang
            // 
            this.radPhongChucNang.AutoSize = true;
            this.radPhongChucNang.Location = new System.Drawing.Point(608, 226);
            this.radPhongChucNang.Name = "radPhongChucNang";
            this.radPhongChucNang.Size = new System.Drawing.Size(190, 29);
            this.radPhongChucNang.TabIndex = 21;
            this.radPhongChucNang.Text = "Phòng chức năng";
            this.radPhongChucNang.UseVisualStyleBackColor = true;
            // 
            // numSoGiuong
            // 
            this.numSoGiuong.Location = new System.Drawing.Point(1136, 65);
            this.numSoGiuong.Name = "numSoGiuong";
            this.numSoGiuong.Size = new System.Drawing.Size(208, 30);
            this.numSoGiuong.TabIndex = 20;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(846, 149);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(493, 30);
            this.txtDiaDiem.TabIndex = 15;
            this.txtDiaDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaDiem_KeyPress);
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiem.Location = new System.Drawing.Point(690, 152);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(88, 25);
            this.lblDiaDiem.TabIndex = 14;
            this.lblDiaDiem.Text = "Địa điểm";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(50, 230);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(109, 25);
            this.lblLoaiPhong.TabIndex = 12;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // lblSoGiuong
            // 
            this.lblSoGiuong.AutoSize = true;
            this.lblSoGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGiuong.Location = new System.Drawing.Point(995, 68);
            this.lblSoGiuong.Name = "lblSoGiuong";
            this.lblSoGiuong.Size = new System.Drawing.Size(101, 25);
            this.lblSoGiuong.TabIndex = 10;
            this.lblSoGiuong.Text = "Số giường";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(608, 65);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(309, 33);
            this.cboKhoa.TabIndex = 7;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(501, 68);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(59, 25);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(50, 150);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(107, 25);
            this.lblTenPhong.TabIndex = 4;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(235, 65);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(208, 30);
            this.txtMaPhong.TabIndex = 3;
            this.txtMaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPhong_KeyPress);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(50, 68);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(100, 25);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // lblQLPhongKham
            // 
            this.lblQLPhongKham.AutoSize = true;
            this.lblQLPhongKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhongKham.ForeColor = System.Drawing.Color.Red;
            this.lblQLPhongKham.Location = new System.Drawing.Point(360, 44);
            this.lblQLPhongKham.Name = "lblQLPhongKham";
            this.lblQLPhongKham.Size = new System.Drawing.Size(735, 69);
            this.lblQLPhongKham.TabIndex = 24;
            this.lblQLPhongKham.Text = "QUẢN LÝ PHÒNG KHÁM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radPhongBenh);
            this.groupBox3.Controls.Add(this.radPhongKham);
            this.groupBox3.Controls.Add(this.radPhongChucNang);
            this.groupBox3.Controls.Add(this.numSoGiuong);
            this.groupBox3.Controls.Add(this.txtDiaDiem);
            this.groupBox3.Controls.Add(this.lblDiaDiem);
            this.groupBox3.Controls.Add(this.lblLoaiPhong);
            this.groupBox3.Controls.Add(this.lblSoGiuong);
            this.groupBox3.Controls.Add(this.cboKhoa);
            this.groupBox3.Controls.Add(this.lblKhoa);
            this.groupBox3.Controls.Add(this.txtTenPhong);
            this.groupBox3.Controls.Add(this.lblTenPhong);
            this.groupBox3.Controls.Add(this.txtMaPhong);
            this.groupBox3.Controls.Add(this.lblMaPhong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 302);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Phòng Khám";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(235, 149);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(341, 30);
            this.txtTenPhong.TabIndex = 5;
            this.txtTenPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenPhong_KeyPress);
            // 
            // dgvDanhSachPhongKham
            // 
            this.dgvDanhSachPhongKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhongKham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachPhongKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhongKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhongKham.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachPhongKham.Name = "dgvDanhSachPhongKham";
            this.dgvDanhSachPhongKham.RowHeadersWidth = 62;
            this.dgvDanhSachPhongKham.RowTemplate.Height = 28;
            this.dgvDanhSachPhongKham.Size = new System.Drawing.Size(1407, 330);
            this.dgvDanhSachPhongKham.TabIndex = 0;
            this.dgvDanhSachPhongKham.Click += new System.EventHandler(this.dgvDanhSachPhongKham_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachPhongKham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 613);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 359);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng Khám";
            // 
            // PhongKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1494, 853);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblQLPhongKham);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PhongKham";
            this.Text = "PhongKham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhongKham_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoGiuong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhongKham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton radPhongBenh;
        private System.Windows.Forms.RadioButton radPhongKham;
        private System.Windows.Forms.RadioButton radPhongChucNang;
        private System.Windows.Forms.NumericUpDown numSoGiuong;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblSoGiuong;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblQLPhongKham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.DataGridView dgvDanhSachPhongKham;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}