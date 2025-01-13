namespace Project_QLBV
{
    partial class GiuongBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiuongBenh));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachGiuongBenh = new System.Windows.Forms.DataGridView();
            this.lblQLGiuongBenh = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numSoGiuong = new System.Windows.Forms.NumericUpDown();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblSoGiuongBenh = new System.Windows.Forms.Label();
            this.txtMaGiuong = new System.Windows.Forms.TextBox();
            this.lblMaGiuong = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiuongBenh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGiuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachGiuongBenh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 395);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Giường Bệnh";
            // 
            // dgvDanhSachGiuongBenh
            // 
            this.dgvDanhSachGiuongBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachGiuongBenh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachGiuongBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiuongBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachGiuongBenh.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachGiuongBenh.Name = "dgvDanhSachGiuongBenh";
            this.dgvDanhSachGiuongBenh.RowHeadersWidth = 62;
            this.dgvDanhSachGiuongBenh.RowTemplate.Height = 28;
            this.dgvDanhSachGiuongBenh.Size = new System.Drawing.Size(1407, 366);
            this.dgvDanhSachGiuongBenh.TabIndex = 0;
            this.dgvDanhSachGiuongBenh.Click += new System.EventHandler(this.dgvDanhSachGiuongBenh_Click);
            // 
            // lblQLGiuongBenh
            // 
            this.lblQLGiuongBenh.AutoSize = true;
            this.lblQLGiuongBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLGiuongBenh.ForeColor = System.Drawing.Color.Red;
            this.lblQLGiuongBenh.Location = new System.Drawing.Point(346, 44);
            this.lblQLGiuongBenh.Name = "lblQLGiuongBenh";
            this.lblQLGiuongBenh.Size = new System.Drawing.Size(753, 69);
            this.lblQLGiuongBenh.TabIndex = 23;
            this.lblQLGiuongBenh.Text = "QUẢN LÝ GIƯỜNG BỆNH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(922, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 302);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(279, 181);
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
            this.btnSua.Location = new System.Drawing.Point(279, 92);
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
            this.btnXoa.Location = new System.Drawing.Point(17, 183);
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
            this.btnThem.Location = new System.Drawing.Point(17, 92);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numSoGiuong);
            this.groupBox3.Controls.Add(this.cboPhong);
            this.groupBox3.Controls.Add(this.lblPhong);
            this.groupBox3.Controls.Add(this.lblSoGiuongBenh);
            this.groupBox3.Controls.Add(this.txtMaGiuong);
            this.groupBox3.Controls.Add(this.lblMaGiuong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 302);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Giường Bệnh";
            // 
            // numSoGiuong
            // 
            this.numSoGiuong.Location = new System.Drawing.Point(302, 148);
            this.numSoGiuong.Name = "numSoGiuong";
            this.numSoGiuong.Size = new System.Drawing.Size(336, 30);
            this.numSoGiuong.TabIndex = 8;
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(302, 224);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(336, 33);
            this.cboPhong.TabIndex = 7;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(117, 227);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(69, 25);
            this.lblPhong.TabIndex = 6;
            this.lblPhong.Text = "Phòng";
            // 
            // lblSoGiuongBenh
            // 
            this.lblSoGiuongBenh.AutoSize = true;
            this.lblSoGiuongBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGiuongBenh.Location = new System.Drawing.Point(117, 150);
            this.lblSoGiuongBenh.Name = "lblSoGiuongBenh";
            this.lblSoGiuongBenh.Size = new System.Drawing.Size(150, 25);
            this.lblSoGiuongBenh.TabIndex = 4;
            this.lblSoGiuongBenh.Text = "Số giường bệnh";
            // 
            // txtMaGiuong
            // 
            this.txtMaGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiuong.Location = new System.Drawing.Point(302, 64);
            this.txtMaGiuong.Name = "txtMaGiuong";
            this.txtMaGiuong.Size = new System.Drawing.Size(336, 30);
            this.txtMaGiuong.TabIndex = 3;
            this.txtMaGiuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaGiuong_KeyPress);
            // 
            // lblMaGiuong
            // 
            this.lblMaGiuong.AutoSize = true;
            this.lblMaGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiuong.Location = new System.Drawing.Point(117, 67);
            this.lblMaGiuong.Name = "lblMaGiuong";
            this.lblMaGiuong.Size = new System.Drawing.Size(104, 25);
            this.lblMaGiuong.TabIndex = 2;
            this.lblMaGiuong.Text = "Mã giường";
            // 
            // GiuongBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1499, 852);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQLGiuongBenh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiuongBenh";
            this.Text = "GiuongBenh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GiuongBenh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiuongBenh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGiuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachGiuongBenh;
        private System.Windows.Forms.Label lblQLGiuongBenh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numSoGiuong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblSoGiuongBenh;
        private System.Windows.Forms.TextBox txtMaGiuong;
        private System.Windows.Forms.Label lblMaGiuong;
    }
}