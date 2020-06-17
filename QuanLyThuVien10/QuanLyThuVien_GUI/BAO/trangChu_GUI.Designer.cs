namespace QuanLyThuVien_GUI
{
    partial class trangChu_GUI
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
            this.btmuon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmuon
            // 
            this.btmuon.Location = new System.Drawing.Point(427, 12);
            this.btmuon.Name = "btmuon";
            this.btmuon.Size = new System.Drawing.Size(75, 23);
            this.btmuon.TabIndex = 7;
            this.btmuon.Text = "Mượn Sách";
            this.btmuon.UseVisualStyleBackColor = true;
            this.btmuon.Click += new System.EventHandler(this.btmuon_Click);
            // 
            // trangChu_GUI
            // 
            this.ClientSize = new System.Drawing.Size(1047, 749);
            this.Controls.Add(this.btmuon);
            this.IsMdiContainer = true;
            this.Name = "trangChu_GUI";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btmuon;
    }
}