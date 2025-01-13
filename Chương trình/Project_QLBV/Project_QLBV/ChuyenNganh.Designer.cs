namespace Project_QLBV
{
    partial class ChuyenNganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuyenNganh));
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachChuyenNganh = new System.Windows.Forms.DataGridView();
            this.lblQLChuyenNganh = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblTenCN = new System.Windows.Forms.Label();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuyenNganh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenCN
            // 
            this.txtTenCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCN.Location = new System.Drawing.Point(302, 149);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(336, 30);
            this.txtTenCN.TabIndex = 5;
            this.txtTenCN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenCN_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachChuyenNganh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 395);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chuyên Ngành";
            // 
            // dgvDanhSachChuyenNganh
            // 
            this.dgvDanhSachChuyenNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChuyenNganh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachChuyenNganh.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachChuyenNganh.Name = "dgvDanhSachChuyenNganh";
            this.dgvDanhSachChuyenNganh.RowHeadersWidth = 62;
            this.dgvDanhSachChuyenNganh.RowTemplate.Height = 28;
            this.dgvDanhSachChuyenNganh.Size = new System.Drawing.Size(1407, 366);
            this.dgvDanhSachChuyenNganh.TabIndex = 0;
            this.dgvDanhSachChuyenNganh.Click += new System.EventHandler(this.dgvDanhSachChuyenNganh_Click);
            // 
            // lblQLChuyenNganh
            // 
            this.lblQLChuyenNganh.AutoSize = true;
            this.lblQLChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLChuyenNganh.ForeColor = System.Drawing.Color.Red;
            this.lblQLChuyenNganh.Location = new System.Drawing.Point(336, 27);
            this.lblQLChuyenNganh.Name = "lblQLChuyenNganh";
            this.lblQLChuyenNganh.Size = new System.Drawing.Size(812, 69);
            this.lblQLChuyenNganh.TabIndex = 19;
            this.lblQLChuyenNganh.Text = "QUẢN LÝ CHUYÊN NGÀNH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(912, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 302);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(278, 178);
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
            this.btnSua.Location = new System.Drawing.Point(278, 87);
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
            this.btnXoa.Location = new System.Drawing.Point(16, 178);
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
            this.btnThem.Location = new System.Drawing.Point(16, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboKhoa);
            this.groupBox3.Controls.Add(this.lblKhoa);
            this.groupBox3.Controls.Add(this.txtTenCN);
            this.groupBox3.Controls.Add(this.lblTenCN);
            this.groupBox3.Controls.Add(this.txtMaCN);
            this.groupBox3.Controls.Add(this.lblMaCN);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 302);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chuyên Ngành";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(302, 224);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(336, 33);
            this.cboKhoa.TabIndex = 7;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(117, 227);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(59, 25);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblTenCN
            // 
            this.lblTenCN.AutoSize = true;
            this.lblTenCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCN.Location = new System.Drawing.Point(117, 150);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(176, 25);
            this.lblTenCN.TabIndex = 4;
            this.lblTenCN.Text = "Tên chuyên ngành";
            // 
            // txtMaCN
            // 
            this.txtMaCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Location = new System.Drawing.Point(302, 64);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(336, 30);
            this.txtMaCN.TabIndex = 3;
            this.txtMaCN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaCN_KeyPress);
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCN.Location = new System.Drawing.Point(117, 67);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(169, 25);
            this.lblMaCN.TabIndex = 2;
            this.lblMaCN.Text = "Mã chuyên ngành";
            // 
            // ChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1495, 886);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQLChuyenNganh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChuyenNganh";
            this.Text = "ChuyenNganh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChuyenNganh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuyenNganh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachChuyenNganh;
        private System.Windows.Forms.Label lblQLChuyenNganh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label lblMaCN;
    }
}