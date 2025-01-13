namespace Project_QLBV
{
    partial class BaoHiemYTe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoHiemYTe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBHYT = new System.Windows.Forms.DataGridView();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.dtpNgHetHan = new System.Windows.Forms.DateTimePicker();
            this.lblNgHetHan = new System.Windows.Forms.Label();
            this.dtpNgCap = new System.Windows.Forms.DateTimePicker();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lblNgCap = new System.Windows.Forms.Label();
            this.lblBHYT = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBenhNhan = new System.Windows.Forms.Label();
            this.txtMaBHYT = new System.Windows.Forms.TextBox();
            this.lblMaBHYT = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBHYT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 561);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 356);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bảo Hiểm Y Tế";
            // 
            // dgvBHYT
            // 
            this.dgvBHYT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBHYT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBHYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBHYT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBHYT.Location = new System.Drawing.Point(3, 26);
            this.dgvBHYT.Name = "dgvBHYT";
            this.dgvBHYT.RowHeadersWidth = 62;
            this.dgvBHYT.RowTemplate.Height = 28;
            this.dgvBHYT.Size = new System.Drawing.Size(1407, 327);
            this.dgvBHYT.TabIndex = 0;
            this.dgvBHYT.Click += new System.EventHandler(this.dgvBHYT_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.Enabled = false;
            this.txtMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBN.Location = new System.Drawing.Point(254, 170);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(208, 30);
            this.txtMaBN.TabIndex = 14;
            // 
            // dtpNgHetHan
            // 
            this.dtpNgHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgHetHan.Location = new System.Drawing.Point(1108, 66);
            this.dtpNgHetHan.Name = "dtpNgHetHan";
            this.dtpNgHetHan.Size = new System.Drawing.Size(222, 30);
            this.dtpNgHetHan.TabIndex = 13;
            // 
            // lblNgHetHan
            // 
            this.lblNgHetHan.AutoSize = true;
            this.lblNgHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgHetHan.Location = new System.Drawing.Point(955, 71);
            this.lblNgHetHan.Name = "lblNgHetHan";
            this.lblNgHetHan.Size = new System.Drawing.Size(128, 25);
            this.lblNgHetHan.TabIndex = 12;
            this.lblNgHetHan.Text = "Ngày hết hạn";
            // 
            // dtpNgCap
            // 
            this.dtpNgCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgCap.Location = new System.Drawing.Point(687, 68);
            this.dtpNgCap.Name = "dtpNgCap";
            this.dtpNgCap.Size = new System.Drawing.Size(222, 30);
            this.dtpNgCap.TabIndex = 10;
            this.dtpNgCap.ValueChanged += new System.EventHandler(this.dtpNgCap_ValueChanged);
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(562, 170);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.ReadOnly = true;
            this.txtTenBN.Size = new System.Drawing.Size(336, 30);
            this.txtTenBN.TabIndex = 9;
            // 
            // lblNgCap
            // 
            this.lblNgCap.AutoSize = true;
            this.lblNgCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgCap.Location = new System.Drawing.Point(558, 73);
            this.lblNgCap.Name = "lblNgCap";
            this.lblNgCap.Size = new System.Drawing.Size(95, 25);
            this.lblNgCap.TabIndex = 6;
            this.lblNgCap.Text = "Ngày cấp";
            // 
            // lblBHYT
            // 
            this.lblBHYT.AutoSize = true;
            this.lblBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBHYT.ForeColor = System.Drawing.Color.Red;
            this.lblBHYT.Location = new System.Drawing.Point(491, 24);
            this.lblBHYT.Name = "lblBHYT";
            this.lblBHYT.Size = new System.Drawing.Size(485, 69);
            this.lblBHYT.TabIndex = 24;
            this.lblBHYT.Text = "BẢO HIỂM Y TẾ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaBN);
            this.groupBox3.Controls.Add(this.dtpNgHetHan);
            this.groupBox3.Controls.Add(this.lblNgHetHan);
            this.groupBox3.Controls.Add(this.dtpNgCap);
            this.groupBox3.Controls.Add(this.txtTenBN);
            this.groupBox3.Controls.Add(this.lblNgCap);
            this.groupBox3.Controls.Add(this.lblBenhNhan);
            this.groupBox3.Controls.Add(this.txtMaBHYT);
            this.groupBox3.Controls.Add(this.lblMaBHYT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1416, 249);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Bảo Hiểm Y Tế";
            // 
            // lblBenhNhan
            // 
            this.lblBenhNhan.AutoSize = true;
            this.lblBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenhNhan.Location = new System.Drawing.Point(79, 172);
            this.lblBenhNhan.Name = "lblBenhNhan";
            this.lblBenhNhan.Size = new System.Drawing.Size(107, 25);
            this.lblBenhNhan.TabIndex = 4;
            this.lblBenhNhan.Text = "Bệnh nhân";
            // 
            // txtMaBHYT
            // 
            this.txtMaBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBHYT.Location = new System.Drawing.Point(254, 68);
            this.txtMaBHYT.Name = "txtMaBHYT";
            this.txtMaBHYT.Size = new System.Drawing.Size(208, 30);
            this.txtMaBHYT.TabIndex = 3;
            this.txtMaBHYT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaBHYT_KeyPress);
            // 
            // lblMaBHYT
            // 
            this.lblMaBHYT.AutoSize = true;
            this.lblMaBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBHYT.Location = new System.Drawing.Point(79, 73);
            this.lblMaBHYT.Name = "lblMaBHYT";
            this.lblMaBHYT.Size = new System.Drawing.Size(161, 25);
            this.lblMaBHYT.TabIndex = 2;
            this.lblMaBHYT.Text = "Mã bảo hiểm y tế";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 106);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(1158, 43);
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
            this.btnTim.Location = new System.Drawing.Point(886, 41);
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
            // BaoHiemYTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1509, 854);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBHYT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoHiemYTe";
            this.Text = "BaoHiemYTe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoHiemYTe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBHYT;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.DateTimePicker dtpNgHetHan;
        private System.Windows.Forms.Label lblNgHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgCap;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lblNgCap;
        private System.Windows.Forms.Label lblBHYT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBenhNhan;
        private System.Windows.Forms.TextBox txtMaBHYT;
        private System.Windows.Forms.Label lblMaBHYT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}