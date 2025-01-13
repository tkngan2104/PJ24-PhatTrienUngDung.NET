namespace Project_QLBV
{
    partial class LoaiBenhAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiBenhAn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSLoaiBA = new System.Windows.Forms.DataGridView();
            this.lblLoaiBenhAn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTLBA = new System.Windows.Forms.TextBox();
            this.lblTenBA = new System.Windows.Forms.Label();
            this.txtMLBA = new System.Windows.Forms.TextBox();
            this.lblLoaiBA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiBA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSLoaiBA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 445);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Bệnh Án";
            // 
            // dgvDSLoaiBA
            // 
            this.dgvDSLoaiBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLoaiBA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSLoaiBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLoaiBA.Location = new System.Drawing.Point(3, 26);
            this.dgvDSLoaiBA.Name = "dgvDSLoaiBA";
            this.dgvDSLoaiBA.RowHeadersWidth = 62;
            this.dgvDSLoaiBA.RowTemplate.Height = 28;
            this.dgvDSLoaiBA.Size = new System.Drawing.Size(1407, 416);
            this.dgvDSLoaiBA.TabIndex = 0;
            this.dgvDSLoaiBA.Click += new System.EventHandler(this.dgvDSLoaiBA_Click);
            // 
            // lblLoaiBenhAn
            // 
            this.lblLoaiBenhAn.AutoSize = true;
            this.lblLoaiBenhAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiBenhAn.ForeColor = System.Drawing.Color.Red;
            this.lblLoaiBenhAn.Location = new System.Drawing.Point(549, 26);
            this.lblLoaiBenhAn.Name = "lblLoaiBenhAn";
            this.lblLoaiBenhAn.Size = new System.Drawing.Size(460, 69);
            this.lblLoaiBenhAn.TabIndex = 23;
            this.lblLoaiBenhAn.Text = "LOẠI BỆNH ÁN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(941, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 249);
            this.groupBox2.TabIndex = 25;
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
            this.groupBox3.Controls.Add(this.txtTLBA);
            this.groupBox3.Controls.Add(this.lblTenBA);
            this.groupBox3.Controls.Add(this.txtMLBA);
            this.groupBox3.Controls.Add(this.lblLoaiBA);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(57, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 249);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Loại Bệnh Án";
            // 
            // txtTLBA
            // 
            this.txtTLBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLBA.Location = new System.Drawing.Point(331, 166);
            this.txtTLBA.Name = "txtTLBA";
            this.txtTLBA.Size = new System.Drawing.Size(300, 30);
            this.txtTLBA.TabIndex = 5;
            this.txtTLBA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTLBA_KeyPress);
            // 
            // lblTenBA
            // 
            this.lblTenBA.AutoSize = true;
            this.lblTenBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBA.Location = new System.Drawing.Point(154, 168);
            this.lblTenBA.Name = "lblTenBA";
            this.lblTenBA.Size = new System.Drawing.Size(123, 25);
            this.lblTenBA.TabIndex = 4;
            this.lblTenBA.Text = "Tên bệnh án";
            // 
            // txtMLBA
            // 
            this.txtMLBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLBA.Location = new System.Drawing.Point(331, 64);
            this.txtMLBA.Name = "txtMLBA";
            this.txtMLBA.Size = new System.Drawing.Size(300, 30);
            this.txtMLBA.TabIndex = 3;
            this.txtMLBA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMLBA_KeyPress);
            // 
            // lblLoaiBA
            // 
            this.lblLoaiBA.AutoSize = true;
            this.lblLoaiBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiBA.Location = new System.Drawing.Point(154, 69);
            this.lblLoaiBA.Name = "lblLoaiBA";
            this.lblLoaiBA.Size = new System.Drawing.Size(151, 25);
            this.lblLoaiBA.TabIndex = 2;
            this.lblLoaiBA.Text = "Mã loại bệnh án";
            // 
            // LoaiBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1566, 855);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLoaiBenhAn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaiBenhAn";
            this.Text = "LoaiBenhAn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoaiBenhAn_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiBA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSLoaiBA;
        private System.Windows.Forms.Label lblLoaiBenhAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTLBA;
        private System.Windows.Forms.Label lblTenBA;
        private System.Windows.Forms.TextBox txtMLBA;
        private System.Windows.Forms.Label lblLoaiBA;
    }
}