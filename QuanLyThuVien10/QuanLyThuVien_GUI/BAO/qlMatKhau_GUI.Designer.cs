namespace QuanLyThuVien_GUI.BAO
{
    partial class qlMatKhau_GUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtconfirmmkmoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(124, 90);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(239, 20);
            this.txtmkmoi.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txtconfirmmkmoi
            // 
            this.txtconfirmmkmoi.Location = new System.Drawing.Point(124, 123);
            this.txtconfirmmkmoi.Name = "txtconfirmmkmoi";
            this.txtconfirmmkmoi.Size = new System.Drawing.Size(239, 20);
            this.txtconfirmmkmoi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập lại";
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(124, 24);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(239, 20);
            this.txttendn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(124, 57);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(239, 20);
            this.txtmkcu.TabIndex = 11;
            // 
            // qlMatKhau_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 194);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconfirmmkmoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txttendn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "qlMatKhau_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qlMatKhau_GUI";
            this.Load += new System.EventHandler(this.qlMatKhau_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtconfirmmkmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmkcu;
    }
}