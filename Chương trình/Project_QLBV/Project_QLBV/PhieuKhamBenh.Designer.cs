namespace Project_QLBV
{
    partial class PhieuKhamBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuKhamBenh));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaBN = new System.Windows.Forms.Label();
            this.dtpNgKham = new System.Windows.Forms.DateTimePicker();
            this.btnKham = new System.Windows.Forms.Button();
            this.cboMaBN = new System.Windows.Forms.ComboBox();
            this.txtMaHSBA = new System.Windows.Forms.TextBox();
            this.rtfTrieuChung = new System.Windows.Forms.RichTextBox();
            this.rtfBenhNen = new System.Windows.Forms.RichTextBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.lblBenhNen = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDKThamKham = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblLoaiKham = new System.Windows.Forms.Label();
            this.cboLKham = new System.Windows.Forms.ComboBox();
            this.lblNgKham = new System.Windows.Forms.Label();
            this.lblMSHSBenhAn = new System.Windows.Forms.Label();
            this.lblMSPhieuKham = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPKBenh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMSPhieuKham = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPKBenh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBN.Location = new System.Drawing.Point(570, 186);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(107, 25);
            this.lblMaBN.TabIndex = 15;
            this.lblMaBN.Text = "Bệnh nhân";
            // 
            // dtpNgKham
            // 
            this.dtpNgKham.Enabled = false;
            this.dtpNgKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgKham.Location = new System.Drawing.Point(699, 54);
            this.dtpNgKham.Name = "dtpNgKham";
            this.dtpNgKham.Size = new System.Drawing.Size(230, 30);
            this.dtpNgKham.TabIndex = 14;
            this.dtpNgKham.ValueChanged += new System.EventHandler(this.dtpNgKham_ValueChanged);
            // 
            // btnKham
            // 
            this.btnKham.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKham.FlatAppearance.BorderSize = 0;
            this.btnKham.Location = new System.Drawing.Point(1155, 41);
            this.btnKham.Name = "btnKham";
            this.btnKham.Size = new System.Drawing.Size(233, 41);
            this.btnKham.TabIndex = 5;
            this.btnKham.Text = "Khám";
            this.btnKham.UseVisualStyleBackColor = false;
            this.btnKham.Click += new System.EventHandler(this.btnKham_Click);
            // 
            // cboMaBN
            // 
            this.cboMaBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaBN.FormattingEnabled = true;
            this.cboMaBN.Location = new System.Drawing.Point(713, 178);
            this.cboMaBN.Name = "cboMaBN";
            this.cboMaBN.Size = new System.Drawing.Size(189, 33);
            this.cboMaBN.TabIndex = 20;
            this.cboMaBN.SelectedIndexChanged += new System.EventHandler(this.cboMaBN_SelectedIndexChanged);
            this.cboMaBN.SelectedValueChanged += new System.EventHandler(this.cboMaBN_SelectedValueChanged);
            // 
            // txtMaHSBA
            // 
            this.txtMaHSBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHSBA.Location = new System.Drawing.Point(236, 181);
            this.txtMaHSBA.Name = "txtMaHSBA";
            this.txtMaHSBA.ReadOnly = true;
            this.txtMaHSBA.Size = new System.Drawing.Size(253, 30);
            this.txtMaHSBA.TabIndex = 19;
            // 
            // rtfTrieuChung
            // 
            this.rtfTrieuChung.Location = new System.Drawing.Point(732, 338);
            this.rtfTrieuChung.Name = "rtfTrieuChung";
            this.rtfTrieuChung.Size = new System.Drawing.Size(662, 215);
            this.rtfTrieuChung.TabIndex = 18;
            this.rtfTrieuChung.Text = "";
            this.rtfTrieuChung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfTrieuChung_KeyPress);
            // 
            // rtfBenhNen
            // 
            this.rtfBenhNen.Location = new System.Drawing.Point(18, 338);
            this.rtfBenhNen.Name = "rtfBenhNen";
            this.rtfBenhNen.Size = new System.Drawing.Size(662, 215);
            this.rtfBenhNen.TabIndex = 17;
            this.rtfBenhNen.Text = "";
            this.rtfBenhNen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfBenhNen_KeyPress);
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrieuChung.Location = new System.Drawing.Point(727, 296);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(116, 25);
            this.lblTrieuChung.TabIndex = 11;
            this.lblTrieuChung.Text = "Triệu chứng";
            // 
            // lblBenhNen
            // 
            this.lblBenhNen.AutoSize = true;
            this.lblBenhNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenhNen.Location = new System.Drawing.Point(13, 296);
            this.lblBenhNen.Name = "lblBenhNen";
            this.lblBenhNen.Size = new System.Drawing.Size(96, 25);
            this.lblBenhNen.TabIndex = 9;
            this.lblBenhNen.Text = "Bệnh nền";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(974, 181);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(368, 30);
            this.txtTenBN.TabIndex = 8;
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
            // lblDKThamKham
            // 
            this.lblDKThamKham.AutoSize = true;
            this.lblDKThamKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKThamKham.ForeColor = System.Drawing.Color.Red;
            this.lblDKThamKham.Location = new System.Drawing.Point(372, 21);
            this.lblDKThamKham.Name = "lblDKThamKham";
            this.lblDKThamKham.Size = new System.Drawing.Size(705, 69);
            this.lblDKThamKham.TabIndex = 14;
            this.lblDKThamKham.Text = "ĐĂNG KÝ PHIẾU KHÁM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnKham);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 724);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 106);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
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
            // lblLoaiKham
            // 
            this.lblLoaiKham.AutoSize = true;
            this.lblLoaiKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiKham.Location = new System.Drawing.Point(1014, 59);
            this.lblLoaiKham.Name = "lblLoaiKham";
            this.lblLoaiKham.Size = new System.Drawing.Size(102, 25);
            this.lblLoaiKham.TabIndex = 6;
            this.lblLoaiKham.Text = "Loại khám";
            // 
            // cboLKham
            // 
            this.cboLKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLKham.FormattingEnabled = true;
            this.cboLKham.Location = new System.Drawing.Point(1162, 53);
            this.cboLKham.Name = "cboLKham";
            this.cboLKham.Size = new System.Drawing.Size(225, 30);
            this.cboLKham.TabIndex = 4;
            // 
            // lblNgKham
            // 
            this.lblNgKham.AutoSize = true;
            this.lblNgKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgKham.Location = new System.Drawing.Point(570, 59);
            this.lblNgKham.Name = "lblNgKham";
            this.lblNgKham.Size = new System.Drawing.Size(111, 25);
            this.lblNgKham.TabIndex = 2;
            this.lblNgKham.Text = "Ngày khám";
            // 
            // lblMSHSBenhAn
            // 
            this.lblMSHSBenhAn.AutoSize = true;
            this.lblMSHSBenhAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSHSBenhAn.Location = new System.Drawing.Point(13, 186);
            this.lblMSHSBenhAn.Name = "lblMSHSBenhAn";
            this.lblMSHSBenhAn.Size = new System.Drawing.Size(139, 25);
            this.lblMSHSBenhAn.TabIndex = 4;
            this.lblMSHSBenhAn.Text = "Hồ sơ bệnh án";
            // 
            // lblMSPhieuKham
            // 
            this.lblMSPhieuKham.AutoSize = true;
            this.lblMSPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSPhieuKham.Location = new System.Drawing.Point(13, 59);
            this.lblMSPhieuKham.Name = "lblMSPhieuKham";
            this.lblMSPhieuKham.Size = new System.Drawing.Size(172, 25);
            this.lblMSPhieuKham.TabIndex = 0;
            this.lblMSPhieuKham.Text = "Mã số phiếu khám";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPKBenh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 860);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1413, 443);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Khám";
            // 
            // dgvPKBenh
            // 
            this.dgvPKBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPKBenh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPKBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPKBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPKBenh.Location = new System.Drawing.Point(3, 26);
            this.dgvPKBenh.Name = "dgvPKBenh";
            this.dgvPKBenh.RowHeadersWidth = 62;
            this.dgvPKBenh.RowTemplate.Height = 28;
            this.dgvPKBenh.Size = new System.Drawing.Size(1407, 414);
            this.dgvPKBenh.TabIndex = 0;
            this.dgvPKBenh.Click += new System.EventHandler(this.dgvPKBenh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboMaBN);
            this.groupBox2.Controls.Add(this.txtMaHSBA);
            this.groupBox2.Controls.Add(this.rtfTrieuChung);
            this.groupBox2.Controls.Add(this.rtfBenhNen);
            this.groupBox2.Controls.Add(this.lblMaBN);
            this.groupBox2.Controls.Add(this.dtpNgKham);
            this.groupBox2.Controls.Add(this.lblTrieuChung);
            this.groupBox2.Controls.Add(this.lblBenhNen);
            this.groupBox2.Controls.Add(this.txtTenBN);
            this.groupBox2.Controls.Add(this.lblLoaiKham);
            this.groupBox2.Controls.Add(this.cboLKham);
            this.groupBox2.Controls.Add(this.lblNgKham);
            this.groupBox2.Controls.Add(this.txtMSPhieuKham);
            this.groupBox2.Controls.Add(this.lblMSHSBenhAn);
            this.groupBox2.Controls.Add(this.lblMSPhieuKham);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1413, 588);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Khám";
            // 
            // txtMSPhieuKham
            // 
            this.txtMSPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSPhieuKham.Location = new System.Drawing.Point(236, 53);
            this.txtMSPhieuKham.Name = "txtMSPhieuKham";
            this.txtMSPhieuKham.ReadOnly = true;
            this.txtMSPhieuKham.Size = new System.Drawing.Size(253, 30);
            this.txtMSPhieuKham.TabIndex = 1;
            this.txtMSPhieuKham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSPhieuKham_KeyPress);
            // 
            // PhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1500, 1050);
            this.Controls.Add(this.lblDKThamKham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhieuKhamBenh";
            this.Text = "PhieuKhamBenh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhieuKhamBenh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPKBenh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.DateTimePicker dtpNgKham;
        private System.Windows.Forms.Button btnKham;
        private System.Windows.Forms.ComboBox cboMaBN;
        private System.Windows.Forms.TextBox txtMaHSBA;
        private System.Windows.Forms.RichTextBox rtfTrieuChung;
        private System.Windows.Forms.RichTextBox rtfBenhNen;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.Label lblBenhNen;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblDKThamKham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblLoaiKham;
        private System.Windows.Forms.ComboBox cboLKham;
        private System.Windows.Forms.Label lblNgKham;
        private System.Windows.Forms.Label lblMSHSBenhAn;
        private System.Windows.Forms.Label lblMSPhieuKham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPKBenh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMSPhieuKham;
    }
}