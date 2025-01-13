namespace Project_QLBV
{
    partial class BenhLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenhLy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSBenhLy = new System.Windows.Forms.DataGridView();
            this.lblQLBenhLy = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenBL = new System.Windows.Forms.TextBox();
            this.lblTenBL = new System.Windows.Forms.Label();
            this.txtMaBL = new System.Windows.Forms.TextBox();
            this.lblMaBL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhLy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSBenhLy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 445);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bệnh Lý";
            // 
            // dgvDSBenhLy
            // 
            this.dgvDSBenhLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBenhLy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSBenhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBenhLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBenhLy.Location = new System.Drawing.Point(3, 26);
            this.dgvDSBenhLy.Name = "dgvDSBenhLy";
            this.dgvDSBenhLy.RowHeadersWidth = 62;
            this.dgvDSBenhLy.RowTemplate.Height = 28;
            this.dgvDSBenhLy.Size = new System.Drawing.Size(1407, 416);
            this.dgvDSBenhLy.TabIndex = 0;
            this.dgvDSBenhLy.Click += new System.EventHandler(this.dgvDSBenhLy_Click);
            // 
            // lblQLBenhLy
            // 
            this.lblQLBenhLy.AutoSize = true;
            this.lblQLBenhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLBenhLy.ForeColor = System.Drawing.Color.Red;
            this.lblQLBenhLy.Location = new System.Drawing.Point(448, 86);
            this.lblQLBenhLy.Name = "lblQLBenhLy";
            this.lblQLBenhLy.Size = new System.Drawing.Size(578, 69);
            this.lblQLBenhLy.TabIndex = 27;
            this.lblQLBenhLy.Text = "QUẢN LÝ BỆNH LÝ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(921, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 249);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new System.Drawing.Point(280, 145);
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
            this.btnSua.Location = new System.Drawing.Point(280, 79);
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
            this.btnXoa.Location = new System.Drawing.Point(18, 145);
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
            this.btnThem.Location = new System.Drawing.Point(18, 79);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(233, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTenBL);
            this.groupBox3.Controls.Add(this.lblTenBL);
            this.groupBox3.Controls.Add(this.txtMaBL);
            this.groupBox3.Controls.Add(this.lblMaBL);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 249);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Bệnh Lý";
            // 
            // txtTenBL
            // 
            this.txtTenBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBL.Location = new System.Drawing.Point(331, 166);
            this.txtTenBL.Name = "txtTenBL";
            this.txtTenBL.Size = new System.Drawing.Size(300, 30);
            this.txtTenBL.TabIndex = 5;
            this.txtTenBL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenBL_KeyPress);
            // 
            // lblTenBL
            // 
            this.lblTenBL.AutoSize = true;
            this.lblTenBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBL.Location = new System.Drawing.Point(139, 171);
            this.lblTenBL.Name = "lblTenBL";
            this.lblTenBL.Size = new System.Drawing.Size(115, 25);
            this.lblTenBL.TabIndex = 4;
            this.lblTenBL.Text = "Tên bệnh lý";
            // 
            // txtMaBL
            // 
            this.txtMaBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBL.Location = new System.Drawing.Point(331, 64);
            this.txtMaBL.Name = "txtMaBL";
            this.txtMaBL.Size = new System.Drawing.Size(300, 30);
            this.txtMaBL.TabIndex = 3;
            this.txtMaBL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaBL_KeyPress);
            // 
            // lblMaBL
            // 
            this.lblMaBL.AutoSize = true;
            this.lblMaBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBL.Location = new System.Drawing.Point(154, 69);
            this.lblMaBL.Name = "lblMaBL";
            this.lblMaBL.Size = new System.Drawing.Size(108, 25);
            this.lblMaBL.TabIndex = 2;
            this.lblMaBL.Text = "Mã bệnh lý";
            // 
            // BenhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1487, 1019);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQLBenhLy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BenhLy";
            this.Text = "BenhLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BenhLy_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhLy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSBenhLy;
        private System.Windows.Forms.Label lblQLBenhLy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenBL;
        private System.Windows.Forms.Label lblTenBL;
        private System.Windows.Forms.TextBox txtMaBL;
        private System.Windows.Forms.Label lblMaBL;
    }
}