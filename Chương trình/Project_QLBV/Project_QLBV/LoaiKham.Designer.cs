namespace Project_QLBV
{
    partial class LoaiKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiKham));
            this.txtTenLoaiKham = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachLoaiKham = new System.Windows.Forms.DataGridView();
            this.lblQLLoaiKham = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenLoaiKham = new System.Windows.Forms.Label();
            this.txtMaLoaiKham = new System.Windows.Forms.TextBox();
            this.lblMaLoaiKham = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiKham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenLoaiKham
            // 
            this.txtTenLoaiKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiKham.Location = new System.Drawing.Point(302, 149);
            this.txtTenLoaiKham.Name = "txtTenLoaiKham";
            this.txtTenLoaiKham.Size = new System.Drawing.Size(336, 30);
            this.txtTenLoaiKham.TabIndex = 5;
            this.txtTenLoaiKham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLoaiKham_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachLoaiKham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 395);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Khám";
            // 
            // dgvDanhSachLoaiKham
            // 
            this.dgvDanhSachLoaiKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLoaiKham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachLoaiKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLoaiKham.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachLoaiKham.Name = "dgvDanhSachLoaiKham";
            this.dgvDanhSachLoaiKham.RowHeadersWidth = 62;
            this.dgvDanhSachLoaiKham.RowTemplate.Height = 28;
            this.dgvDanhSachLoaiKham.Size = new System.Drawing.Size(1407, 366);
            this.dgvDanhSachLoaiKham.TabIndex = 0;
            this.dgvDanhSachLoaiKham.Click += new System.EventHandler(this.dgvDanhSachLoaiKham_Click);
            // 
            // lblQLLoaiKham
            // 
            this.lblQLLoaiKham.AutoSize = true;
            this.lblQLLoaiKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLLoaiKham.ForeColor = System.Drawing.Color.Red;
            this.lblQLLoaiKham.Location = new System.Drawing.Point(416, 34);
            this.lblQLLoaiKham.Name = "lblQLLoaiKham";
            this.lblQLLoaiKham.Size = new System.Drawing.Size(651, 69);
            this.lblQLLoaiKham.TabIndex = 23;
            this.lblQLLoaiKham.Text = "QUẢN LÝ LOẠI KHÁM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(921, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 302);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(278, 144);
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
            this.btnSua.Location = new System.Drawing.Point(278, 53);
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
            this.btnXoa.Location = new System.Drawing.Point(16, 144);
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
            this.btnThem.Location = new System.Drawing.Point(16, 53);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGia);
            this.groupBox3.Controls.Add(this.lblGia);
            this.groupBox3.Controls.Add(this.txtTenLoaiKham);
            this.groupBox3.Controls.Add(this.lblTenLoaiKham);
            this.groupBox3.Controls.Add(this.txtMaLoaiKham);
            this.groupBox3.Controls.Add(this.lblMaLoaiKham);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 302);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Loại Khám";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(302, 224);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(336, 30);
            this.txtGia.TabIndex = 7;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(117, 227);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(42, 25);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Giá";
            // 
            // lblTenLoaiKham
            // 
            this.lblTenLoaiKham.AutoSize = true;
            this.lblTenLoaiKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiKham.Location = new System.Drawing.Point(117, 150);
            this.lblTenLoaiKham.Name = "lblTenLoaiKham";
            this.lblTenLoaiKham.Size = new System.Drawing.Size(135, 25);
            this.lblTenLoaiKham.TabIndex = 4;
            this.lblTenLoaiKham.Text = "Tên loại khám";
            // 
            // txtMaLoaiKham
            // 
            this.txtMaLoaiKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiKham.Location = new System.Drawing.Point(302, 64);
            this.txtMaLoaiKham.Name = "txtMaLoaiKham";
            this.txtMaLoaiKham.Size = new System.Drawing.Size(336, 30);
            this.txtMaLoaiKham.TabIndex = 3;
            this.txtMaLoaiKham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLoaiKham_KeyPress);
            // 
            // lblMaLoaiKham
            // 
            this.lblMaLoaiKham.AutoSize = true;
            this.lblMaLoaiKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiKham.Location = new System.Drawing.Point(117, 67);
            this.lblMaLoaiKham.Name = "lblMaLoaiKham";
            this.lblMaLoaiKham.Size = new System.Drawing.Size(128, 25);
            this.lblMaLoaiKham.TabIndex = 2;
            this.lblMaLoaiKham.Text = "Mã loại khám";
            // 
            // LoaiKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1487, 935);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQLLoaiKham);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaiKham";
            this.Text = "LoaiKham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoaiKham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiKham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLoaiKham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiKham;
        private System.Windows.Forms.Label lblQLLoaiKham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenLoaiKham;
        private System.Windows.Forms.TextBox txtMaLoaiKham;
        private System.Windows.Forms.Label lblMaLoaiKham;
    }
}