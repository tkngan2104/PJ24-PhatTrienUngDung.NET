namespace Project_QLBV
{
    partial class LoaiPTXNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiPTXNCC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachLXNPT = new System.Windows.Forms.DataGridView();
            this.lblLXNPT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiXNPT = new System.Windows.Forms.TextBox();
            this.lblTenLoaiXNPT = new System.Windows.Forms.Label();
            this.txtLoaiXNPT = new System.Windows.Forms.TextBox();
            this.lblLoaiXNPT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLXNPT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachLXNPT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 445);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Xét Nghiệm - Phẫu Thuật";
            // 
            // dgvDanhSachLXNPT
            // 
            this.dgvDanhSachLXNPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLXNPT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachLXNPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLXNPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLXNPT.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachLXNPT.Name = "dgvDanhSachLXNPT";
            this.dgvDanhSachLXNPT.RowHeadersWidth = 62;
            this.dgvDanhSachLXNPT.RowTemplate.Height = 28;
            this.dgvDanhSachLXNPT.Size = new System.Drawing.Size(1407, 416);
            this.dgvDanhSachLXNPT.TabIndex = 0;
            this.dgvDanhSachLXNPT.Click += new System.EventHandler(this.dgvDanhSachLXNPT_Click);
            // 
            // lblLXNPT
            // 
            this.lblLXNPT.AutoSize = true;
            this.lblLXNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLXNPT.ForeColor = System.Drawing.Color.Red;
            this.lblLXNPT.Location = new System.Drawing.Point(258, 20);
            this.lblLXNPT.Name = "lblLXNPT";
            this.lblLXNPT.Size = new System.Drawing.Size(1018, 69);
            this.lblLXNPT.TabIndex = 19;
            this.lblLXNPT.Text = "LOẠI XÉT NGHIỆM - PHẪU THUẬT";
            this.lblLXNPT.Click += new System.EventHandler(this.lblLXNPT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(908, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 249);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(278, 119);
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
            this.btnXoa.Location = new System.Drawing.Point(16, 119);
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
            this.groupBox3.Controls.Add(this.txtTenLoaiXNPT);
            this.groupBox3.Controls.Add(this.lblTenLoaiXNPT);
            this.groupBox3.Controls.Add(this.txtLoaiXNPT);
            this.groupBox3.Controls.Add(this.lblLoaiXNPT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 249);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Loại Xét Nghiệm - Phẫu Thuật";
            // 
            // txtTenLoaiXNPT
            // 
            this.txtTenLoaiXNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiXNPT.Location = new System.Drawing.Point(331, 166);
            this.txtTenLoaiXNPT.Name = "txtTenLoaiXNPT";
            this.txtTenLoaiXNPT.Size = new System.Drawing.Size(300, 30);
            this.txtTenLoaiXNPT.TabIndex = 5;
            this.txtTenLoaiXNPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLoaiXNPT_KeyPress);
            // 
            // lblTenLoaiXNPT
            // 
            this.lblTenLoaiXNPT.AutoSize = true;
            this.lblTenLoaiXNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiXNPT.Location = new System.Drawing.Point(154, 168);
            this.lblTenLoaiXNPT.Name = "lblTenLoaiXNPT";
            this.lblTenLoaiXNPT.Size = new System.Drawing.Size(158, 25);
            this.lblTenLoaiXNPT.TabIndex = 4;
            this.lblTenLoaiXNPT.Text = "Tên loại XN - PT";
            // 
            // txtLoaiXNPT
            // 
            this.txtLoaiXNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiXNPT.Location = new System.Drawing.Point(331, 64);
            this.txtLoaiXNPT.Name = "txtLoaiXNPT";
            this.txtLoaiXNPT.Size = new System.Drawing.Size(300, 30);
            this.txtLoaiXNPT.TabIndex = 3;
            this.txtLoaiXNPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoaiXNPT_KeyPress);
            // 
            // lblLoaiXNPT
            // 
            this.lblLoaiXNPT.AutoSize = true;
            this.lblLoaiXNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiXNPT.Location = new System.Drawing.Point(154, 69);
            this.lblLoaiXNPT.Name = "lblLoaiXNPT";
            this.lblLoaiXNPT.Size = new System.Drawing.Size(125, 25);
            this.lblLoaiXNPT.TabIndex = 2;
            this.lblLoaiXNPT.Text = "Loại XN - PT";
            // 
            // LoaiPTXNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1494, 747);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLXNPT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaiPTXNCC";
            this.Text = "LoaiPTXNCC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoaiPTXNCC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLXNPT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachLXNPT;
        private System.Windows.Forms.Label lblLXNPT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenLoaiXNPT;
        private System.Windows.Forms.Label lblTenLoaiXNPT;
        private System.Windows.Forms.TextBox txtLoaiXNPT;
        private System.Windows.Forms.Label lblLoaiXNPT;
    }
}