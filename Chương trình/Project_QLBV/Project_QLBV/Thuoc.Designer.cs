namespace Project_QLBV
{
    partial class Thuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thuoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDuocPham = new System.Windows.Forms.DataGridView();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.lblQLDuocPham = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblXuatXu = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDVTinh = new System.Windows.Forms.TextBox();
            this.lblDVTinh = new System.Windows.Forms.Label();
            this.txtDangThuoc = new System.Windows.Forms.TextBox();
            this.lblDangThuoc = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.txtMSThuoc = new System.Windows.Forms.TextBox();
            this.lblMSThuoc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDuocPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachDuocPham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 371);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Dược Phẩm";
            // 
            // dgvDanhSachDuocPham
            // 
            this.dgvDanhSachDuocPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDuocPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachDuocPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDuocPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachDuocPham.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachDuocPham.Name = "dgvDanhSachDuocPham";
            this.dgvDanhSachDuocPham.RowHeadersWidth = 62;
            this.dgvDanhSachDuocPham.RowTemplate.Height = 28;
            this.dgvDanhSachDuocPham.Size = new System.Drawing.Size(1407, 342);
            this.dgvDanhSachDuocPham.TabIndex = 0;
            this.dgvDanhSachDuocPham.Click += new System.EventHandler(this.dgvDanhSachDuocPham_Click);
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatXu.Location = new System.Drawing.Point(970, 216);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(336, 30);
            this.txtXuatXu.TabIndex = 14;
            this.txtXuatXu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXuatXu_KeyPress);
            // 
            // lblQLDuocPham
            // 
            this.lblQLDuocPham.AutoSize = true;
            this.lblQLDuocPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLDuocPham.ForeColor = System.Drawing.Color.Red;
            this.lblQLDuocPham.Location = new System.Drawing.Point(393, 22);
            this.lblQLDuocPham.Name = "lblQLDuocPham";
            this.lblQLDuocPham.Size = new System.Drawing.Size(690, 69);
            this.lblQLDuocPham.TabIndex = 28;
            this.lblQLDuocPham.Text = "QUẢN LÝ DƯỢC PHẨM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtXuatXu);
            this.groupBox3.Controls.Add(this.lblXuatXu);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.lblDonGia);
            this.groupBox3.Controls.Add(this.txtDVTinh);
            this.groupBox3.Controls.Add(this.lblDVTinh);
            this.groupBox3.Controls.Add(this.txtDangThuoc);
            this.groupBox3.Controls.Add(this.lblDangThuoc);
            this.groupBox3.Controls.Add(this.txtTenThuoc);
            this.groupBox3.Controls.Add(this.lblTenThuoc);
            this.groupBox3.Controls.Add(this.txtMSThuoc);
            this.groupBox3.Controls.Add(this.lblMSThuoc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(45, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 274);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Dược Phẩm";
            // 
            // lblXuatXu
            // 
            this.lblXuatXu.AutoSize = true;
            this.lblXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXuatXu.Location = new System.Drawing.Point(797, 219);
            this.lblXuatXu.Name = "lblXuatXu";
            this.lblXuatXu.Size = new System.Drawing.Size(79, 25);
            this.lblXuatXu.TabIndex = 13;
            this.lblXuatXu.Text = "Xuất xứ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(970, 131);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(336, 30);
            this.txtDonGia.TabIndex = 12;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(797, 134);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(79, 25);
            this.lblDonGia.TabIndex = 11;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtDVTinh
            // 
            this.txtDVTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVTinh.Location = new System.Drawing.Point(970, 48);
            this.txtDVTinh.Name = "txtDVTinh";
            this.txtDVTinh.Size = new System.Drawing.Size(336, 30);
            this.txtDVTinh.TabIndex = 10;
            this.txtDVTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDVTinh_KeyPress);
            // 
            // lblDVTinh
            // 
            this.lblDVTinh.AutoSize = true;
            this.lblDVTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVTinh.Location = new System.Drawing.Point(797, 51);
            this.lblDVTinh.Name = "lblDVTinh";
            this.lblDVTinh.Size = new System.Drawing.Size(103, 25);
            this.lblDVTinh.TabIndex = 9;
            this.lblDVTinh.Text = "Đơn vị tính";
            // 
            // txtDangThuoc
            // 
            this.txtDangThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangThuoc.Location = new System.Drawing.Point(272, 216);
            this.txtDangThuoc.Name = "txtDangThuoc";
            this.txtDangThuoc.Size = new System.Drawing.Size(336, 30);
            this.txtDangThuoc.TabIndex = 8;
            this.txtDangThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDangThuoc_KeyPress);
            // 
            // lblDangThuoc
            // 
            this.lblDangThuoc.AutoSize = true;
            this.lblDangThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangThuoc.Location = new System.Drawing.Point(99, 219);
            this.lblDangThuoc.Name = "lblDangThuoc";
            this.lblDangThuoc.Size = new System.Drawing.Size(112, 25);
            this.lblDangThuoc.TabIndex = 7;
            this.lblDangThuoc.Text = "Dạng thuốc";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.Location = new System.Drawing.Point(272, 131);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(336, 30);
            this.txtTenThuoc.TabIndex = 6;
            this.txtTenThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenThuoc_KeyPress);
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenThuoc.Location = new System.Drawing.Point(99, 134);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(100, 25);
            this.lblTenThuoc.TabIndex = 5;
            this.lblTenThuoc.Text = "Tên thuốc";
            // 
            // txtMSThuoc
            // 
            this.txtMSThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSThuoc.Location = new System.Drawing.Point(272, 48);
            this.txtMSThuoc.Name = "txtMSThuoc";
            this.txtMSThuoc.Size = new System.Drawing.Size(336, 30);
            this.txtMSThuoc.TabIndex = 4;
            this.txtMSThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSThuoc_KeyPress);
            // 
            // lblMSThuoc
            // 
            this.lblMSThuoc.AutoSize = true;
            this.lblMSThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSThuoc.Location = new System.Drawing.Point(99, 51);
            this.lblMSThuoc.Name = "lblMSThuoc";
            this.lblMSThuoc.Size = new System.Drawing.Size(119, 25);
            this.lblMSThuoc.TabIndex = 2;
            this.lblMSThuoc.Text = "Mã số thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 106);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(1024, 41);
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
            this.btnSua.Location = new System.Drawing.Point(746, 41);
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
            this.btnXoa.Location = new System.Drawing.Point(459, 41);
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
            this.btnThem.Location = new System.Drawing.Point(180, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1530, 852);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQLDuocPham);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Thuoc";
            this.Text = "Thuoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Thuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDuocPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachDuocPham;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label lblQLDuocPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblXuatXu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDVTinh;
        private System.Windows.Forms.Label lblDVTinh;
        private System.Windows.Forms.TextBox txtDangThuoc;
        private System.Windows.Forms.Label lblDangThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.TextBox txtMSThuoc;
        private System.Windows.Forms.Label lblMSThuoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}