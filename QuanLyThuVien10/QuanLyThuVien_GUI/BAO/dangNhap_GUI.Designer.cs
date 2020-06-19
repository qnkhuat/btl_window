namespace QuanLyThuVien_GUI
{
    partial class dangNhap_GUI
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
            this.btdangnhap = new System.Windows.Forms.Button();
            this.lbtendn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdangnhap.Location = new System.Drawing.Point(252, 168);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(90, 32);
            this.btdangnhap.TabIndex = 0;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = false;
            this.btdangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbtendn
            // 
            this.lbtendn.AutoSize = true;
            this.lbtendn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtendn.Location = new System.Drawing.Point(82, 65);
            this.lbtendn.Name = "lbtendn";
            this.lbtendn.Size = new System.Drawing.Size(107, 19);
            this.lbtendn.TabIndex = 1;
            this.lbtendn.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(195, 64);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(275, 20);
            this.txttendn.TabIndex = 3;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(195, 100);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(275, 20);
            this.txtmatkhau.TabIndex = 4;
            // 
            // dangNhap_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(577, 231);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtendn);
            this.Controls.Add(this.btdangnhap);
            this.Name = "dangNhap_GUI";
            this.Text = "dangNhap_GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Label lbtendn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatkhau;
        public System.Windows.Forms.TextBox txttendn;
    }
}