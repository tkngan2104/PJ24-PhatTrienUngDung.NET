namespace Project_QLBV
{
    partial class BangGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangGia));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblLoaiXNPT = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblBangGia = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.dgvDSBangGia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBangGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(1032, 43);
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
            this.btnSua.Location = new System.Drawing.Point(754, 43);
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
            this.btnThem.Location = new System.Drawing.Point(188, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(958, 167);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(336, 33);
            this.cboLoai.TabIndex = 14;
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(958, 68);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(336, 33);
            this.cboKhoa.TabIndex = 13;
            // 
            // lblLoaiXNPT
            // 
            this.lblLoaiXNPT.AutoSize = true;
            this.lblLoaiXNPT.Location = new System.Drawing.Point(758, 175);
            this.lblLoaiXNPT.Name = "lblLoaiXNPT";
            this.lblLoaiXNPT.Size = new System.Drawing.Size(108, 25);
            this.lblLoaiXNPT.TabIndex = 12;
            this.lblLoaiXNPT.Text = "Loại XNPT";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(758, 76);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(59, 25);
            this.lblKhoa.TabIndex = 11;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaDV.Location = new System.Drawing.Point(306, 274);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(336, 30);
            this.txtGiaDV.TabIndex = 9;
            this.txtGiaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaDV_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 542);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 106);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(467, 43);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(233, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaDV.Location = new System.Drawing.Point(106, 277);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(109, 25);
            this.lblGiaDV.TabIndex = 8;
            this.lblGiaDV.Text = "Giá dịch vụ";
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDV.Location = new System.Drawing.Point(106, 175);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(114, 25);
            this.lblTenDV.TabIndex = 4;
            this.lblTenDV.Text = "Tên dịch vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(306, 73);
            this.txtMaDV.MaxLength = 110000;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(336, 30);
            this.txtMaDV.TabIndex = 3;
            this.txtMaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDV_KeyPress);
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDV.Location = new System.Drawing.Point(106, 76);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(107, 25);
            this.lblMaDV.TabIndex = 2;
            this.lblMaDV.Text = "Mã dịch vụ";
            // 
            // lblBangGia
            // 
            this.lblBangGia.AutoSize = true;
            this.lblBangGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangGia.ForeColor = System.Drawing.Color.Red;
            this.lblBangGia.Location = new System.Drawing.Point(541, 16);
            this.lblBangGia.Name = "lblBangGia";
            this.lblBangGia.Size = new System.Drawing.Size(328, 69);
            this.lblBangGia.TabIndex = 21;
            this.lblBangGia.Text = "BẢNG GIÁ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboLoai);
            this.groupBox3.Controls.Add(this.cboKhoa);
            this.groupBox3.Controls.Add(this.lblLoaiXNPT);
            this.groupBox3.Controls.Add(this.lblKhoa);
            this.groupBox3.Controls.Add(this.txtGiaDV);
            this.groupBox3.Controls.Add(this.lblGiaDV);
            this.groupBox3.Controls.Add(this.txtTenDV);
            this.groupBox3.Controls.Add(this.lblTenDV);
            this.groupBox3.Controls.Add(this.txtMaDV);
            this.groupBox3.Controls.Add(this.lblMaDV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 355);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Bảng Giá";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(306, 172);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(336, 30);
            this.txtTenDV.TabIndex = 5;
            this.txtTenDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDV_KeyPress);
            // 
            // dgvDSBangGia
            // 
            this.dgvDSBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBangGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBangGia.Location = new System.Drawing.Point(3, 26);
            this.dgvDSBangGia.Name = "dgvDSBangGia";
            this.dgvDSBangGia.RowHeadersWidth = 62;
            this.dgvDSBangGia.RowTemplate.Height = 28;
            this.dgvDSBangGia.Size = new System.Drawing.Size(1407, 416);
            this.dgvDSBangGia.TabIndex = 0;
            this.dgvDSBangGia.Click += new System.EventHandler(this.dgvDSBangGia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSBangGia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 696);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 445);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bảng Giá";
            // 
            // BangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1554, 829);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblBangGia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BangGia";
            this.Text = "BangGia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BangGia_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBangGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblLoaiXNPT;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblGiaDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lblBangGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.DataGridView dgvDSBangGia;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}