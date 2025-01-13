namespace Project_QLBV
{
    partial class _login
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
            this.pnlLOGIN = new System.Windows.Forms.Panel();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblPASSWORD = new System.Windows.Forms.Label();
            this.lblUSER = new System.Windows.Forms.Label();
            this.pnlLOGIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLOGIN
            // 
            this.pnlLOGIN.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLOGIN.Controls.Add(this.cboDatabase);
            this.pnlLOGIN.Controls.Add(this.btnEXIT);
            this.pnlLOGIN.Controls.Add(this.btnLOGIN);
            this.pnlLOGIN.Controls.Add(this.txtServer);
            this.pnlLOGIN.Controls.Add(this.lblPASSWORD);
            this.pnlLOGIN.Controls.Add(this.lblUSER);
            this.pnlLOGIN.Location = new System.Drawing.Point(432, -7);
            this.pnlLOGIN.Name = "pnlLOGIN";
            this.pnlLOGIN.Size = new System.Drawing.Size(910, 836);
            this.pnlLOGIN.TabIndex = 2;
            this.pnlLOGIN.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLOGIN_Paint);
            // 
            // cboDatabase
            // 
            this.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(309, 517);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(494, 40);
            this.cboDatabase.TabIndex = 10;
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.White;
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEXIT.Location = new System.Drawing.Point(494, 636);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(309, 49);
            this.btnEXIT.TabIndex = 9;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.White;
            this.btnLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLOGIN.Location = new System.Drawing.Point(84, 636);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(309, 49);
            this.btnLOGIN.TabIndex = 8;
            this.btnLOGIN.Text = "LOGIN";
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(309, 403);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(494, 45);
            this.txtServer.TabIndex = 6;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // lblPASSWORD
            // 
            this.lblPASSWORD.AutoSize = true;
            this.lblPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASSWORD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPASSWORD.Location = new System.Drawing.Point(78, 525);
            this.lblPASSWORD.Name = "lblPASSWORD";
            this.lblPASSWORD.Size = new System.Drawing.Size(161, 32);
            this.lblPASSWORD.TabIndex = 5;
            this.lblPASSWORD.Text = "Database :";
            // 
            // lblUSER
            // 
            this.lblUSER.AutoSize = true;
            this.lblUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUSER.Location = new System.Drawing.Point(78, 416);
            this.lblUSER.Name = "lblUSER";
            this.lblUSER.Size = new System.Drawing.Size(207, 32);
            this.lblUSER.TabIndex = 4;
            this.lblUSER.Text = "Server Name :";
            // 
            // _login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_QLBV.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1745, 823);
            this.Controls.Add(this.pnlLOGIN);
            this.Name = "_login";
            this.Text = "_login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._login_Load);
            this.pnlLOGIN.ResumeLayout(false);
            this.pnlLOGIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLOGIN;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblPASSWORD;
        private System.Windows.Forms.Label lblUSER;
        private System.Windows.Forms.ComboBox cboDatabase;
    }
}