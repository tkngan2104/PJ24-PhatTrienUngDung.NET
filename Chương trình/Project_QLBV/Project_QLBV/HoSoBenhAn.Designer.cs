namespace Project_QLBV
{
    partial class HoSoBenhAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoSoBenhAn));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDKyPhieuKhamBenh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.dtpNgTao = new System.Windows.Forms.DateTimePicker();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lblNgTao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblBenhNhan = new System.Windows.Forms.Label();
            this.lblMaHSBA = new System.Windows.Forms.Label();
            this.lblHSBenhAn = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaHSBA = new System.Windows.Forms.TextBox();
            this.dgvDSHSBA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSBA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(424, 42);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(233, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát màn hình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDKyPhieuKhamBenh
            // 
            this.btnDKyPhieuKhamBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDKyPhieuKhamBenh.FlatAppearance.BorderSize = 0;
            this.btnDKyPhieuKhamBenh.Location = new System.Drawing.Point(701, 42);
            this.btnDKyPhieuKhamBenh.Name = "btnDKyPhieuKhamBenh";
            this.btnDKyPhieuKhamBenh.Size = new System.Drawing.Size(233, 41);
            this.btnDKyPhieuKhamBenh.TabIndex = 5;
            this.btnDKyPhieuKhamBenh.Text = "Đăng ký phiếu khám";
            this.btnDKyPhieuKhamBenh.UseVisualStyleBackColor = false;
            this.btnDKyPhieuKhamBenh.Click += new System.EventHandler(this.btnDKyPhieuKhamBenh_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(140, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBN.Location = new System.Drawing.Point(462, 174);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(208, 30);
            this.txtMaBN.TabIndex = 11;
            // 
            // dtpNgTao
            // 
            this.dtpNgTao.Enabled = false;
            this.dtpNgTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgTao.Location = new System.Drawing.Point(884, 70);
            this.dtpNgTao.Name = "dtpNgTao";
            this.dtpNgTao.Size = new System.Drawing.Size(222, 30);
            this.dtpNgTao.TabIndex = 10;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(770, 174);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.ReadOnly = true;
            this.txtTenBN.Size = new System.Drawing.Size(336, 30);
            this.txtTenBN.TabIndex = 9;
            // 
            // lblNgTao
            // 
            this.lblNgTao.AutoSize = true;
            this.lblNgTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgTao.Location = new System.Drawing.Point(755, 75);
            this.lblNgTao.Name = "lblNgTao";
            this.lblNgTao.Size = new System.Drawing.Size(90, 25);
            this.lblNgTao.TabIndex = 6;
            this.lblNgTao.Text = "Ngày tạo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnDKyPhieuKhamBenh);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 106);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Location = new System.Drawing.Point(983, 42);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(233, 41);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblBenhNhan
            // 
            this.lblBenhNhan.AutoSize = true;
            this.lblBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenhNhan.Location = new System.Drawing.Point(287, 176);
            this.lblBenhNhan.Name = "lblBenhNhan";
            this.lblBenhNhan.Size = new System.Drawing.Size(107, 25);
            this.lblBenhNhan.TabIndex = 4;
            this.lblBenhNhan.Text = "Bệnh nhân";
            // 
            // lblMaHSBA
            // 
            this.lblMaHSBA.AutoSize = true;
            this.lblMaHSBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHSBA.Location = new System.Drawing.Point(287, 77);
            this.lblMaHSBA.Name = "lblMaHSBA";
            this.lblMaHSBA.Size = new System.Drawing.Size(169, 25);
            this.lblMaHSBA.TabIndex = 2;
            this.lblMaHSBA.Text = "Mã hồ sơ bệnh án";
            // 
            // lblHSBenhAn
            // 
            this.lblHSBenhAn.AutoSize = true;
            this.lblHSBenhAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSBenhAn.ForeColor = System.Drawing.Color.Red;
            this.lblHSBenhAn.Location = new System.Drawing.Point(490, 23);
            this.lblHSBenhAn.Name = "lblHSBenhAn";
            this.lblHSBenhAn.Size = new System.Drawing.Size(517, 69);
            this.lblHSBenhAn.TabIndex = 20;
            this.lblHSBenhAn.Text = "HỒ SƠ BỆNH ÁN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaBN);
            this.groupBox3.Controls.Add(this.dtpNgTao);
            this.groupBox3.Controls.Add(this.txtTenBN);
            this.groupBox3.Controls.Add(this.lblNgTao);
            this.groupBox3.Controls.Add(this.lblBenhNhan);
            this.groupBox3.Controls.Add(this.txtMaHSBA);
            this.groupBox3.Controls.Add(this.lblMaHSBA);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1416, 249);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Hồ Sơ Bệnh Án";
            // 
            // txtMaHSBA
            // 
            this.txtMaHSBA.Enabled = false;
            this.txtMaHSBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHSBA.Location = new System.Drawing.Point(462, 72);
            this.txtMaHSBA.Name = "txtMaHSBA";
            this.txtMaHSBA.Size = new System.Drawing.Size(208, 30);
            this.txtMaHSBA.TabIndex = 3;
            // 
            // dgvDSHSBA
            // 
            this.dgvDSHSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHSBA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHSBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHSBA.Location = new System.Drawing.Point(3, 26);
            this.dgvDSHSBA.Name = "dgvDSHSBA";
            this.dgvDSHSBA.RowHeadersWidth = 62;
            this.dgvDSHSBA.RowTemplate.Height = 28;
            this.dgvDSHSBA.Size = new System.Drawing.Size(1407, 416);
            this.dgvDSHSBA.TabIndex = 0;
            this.dgvDSHSBA.Click += new System.EventHandler(this.dgvDSHSBA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSHSBA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 582);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 445);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hồ Sơ Bệnh Án";
            // 
            // HoSoBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1520, 762);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblHSBenhAn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoSoBenhAn";
            this.Text = "HoSoBenhAn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HoSoBenhAn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHSBA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDKyPhieuKhamBenh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.DateTimePicker dtpNgTao;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lblNgTao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBenhNhan;
        private System.Windows.Forms.Label lblMaHSBA;
        private System.Windows.Forms.Label lblHSBenhAn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaHSBA;
        private System.Windows.Forms.DataGridView dgvDSHSBA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
    }
}