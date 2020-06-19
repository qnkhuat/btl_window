namespace QuanLyThuVien_GUI
{
    partial class traSach_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.DataGridView();
            this.maPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btview = new System.Windows.Forms.Button();
            this.bttrasach = new System.Windows.Forms.Button();
            this.lbstatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtslmuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaTL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(79, 12);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(195, 20);
            this.txtmadg.TabIndex = 1;
            this.txtmadg.TextChanged += new System.EventHandler(this.txtmadg_TextChanged_1);
            // 
            // view
            // 
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPM,
            this.maTL,
            this.maDG,
            this.maNV,
            this.soLuongMuon,
            this.ngayMuon,
            this.ngayTra});
            this.view.Location = new System.Drawing.Point(12, 70);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(875, 343);
            this.view.TabIndex = 2;
            this.view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_CellClick_1);
            // 
            // maPM
            // 
            this.maPM.DataPropertyName = "maPM";
            this.maPM.HeaderText = "Mã Phiếu Mượn";
            this.maPM.Name = "maPM";
            this.maPM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maPM.Width = 120;
            // 
            // maTL
            // 
            this.maTL.DataPropertyName = "maTL";
            this.maTL.HeaderText = "Mã Tài Liệu";
            this.maTL.Name = "maTL";
            this.maTL.Width = 120;
            // 
            // maDG
            // 
            this.maDG.DataPropertyName = "maDG";
            this.maDG.HeaderText = "Mã Độc Giả";
            this.maDG.Name = "maDG";
            this.maDG.Width = 120;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã Nhân Viên";
            this.maNV.Name = "maNV";
            this.maNV.Width = 120;
            // 
            // soLuongMuon
            // 
            this.soLuongMuon.DataPropertyName = "soLuongMuon";
            this.soLuongMuon.HeaderText = "Sô Lượng Mượn";
            this.soLuongMuon.Name = "soLuongMuon";
            this.soLuongMuon.Width = 120;
            // 
            // ngayMuon
            // 
            this.ngayMuon.DataPropertyName = "ngayMuon";
            this.ngayMuon.HeaderText = "Ngày Mượn";
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Width = 120;
            // 
            // ngayTra
            // 
            this.ngayTra.DataPropertyName = "ngayTra";
            this.ngayTra.HeaderText = "Ngày Trả";
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.Width = 120;
            // 
            // btview
            // 
            this.btview.Location = new System.Drawing.Point(789, 12);
            this.btview.Name = "btview";
            this.btview.Size = new System.Drawing.Size(75, 23);
            this.btview.TabIndex = 3;
            this.btview.Text = "View All";
            this.btview.UseVisualStyleBackColor = true;
            this.btview.Click += new System.EventHandler(this.btview_Click_1);
            // 
            // bttrasach
            // 
            this.bttrasach.Location = new System.Drawing.Point(789, 41);
            this.bttrasach.Name = "bttrasach";
            this.bttrasach.Size = new System.Drawing.Size(75, 23);
            this.bttrasach.TabIndex = 4;
            this.bttrasach.Text = "Trả Sách";
            this.bttrasach.UseVisualStyleBackColor = true;
            this.bttrasach.Click += new System.EventHandler(this.bttrasach_Click_1);
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(366, 54);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(91, 13);
            this.lbstatus.TabIndex = 5;
            this.lbstatus.Text = "                            ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sô lượng mượn";
            // 
            // txtslmuon
            // 
            this.txtslmuon.Location = new System.Drawing.Point(618, 12);
            this.txtslmuon.Name = "txtslmuon";
            this.txtslmuon.Size = new System.Drawing.Size(165, 20);
            this.txtslmuon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã tài liệu";
            // 
            // txtmaTL
            // 
            this.txtmaTL.Location = new System.Drawing.Point(341, 12);
            this.txtmaTL.Name = "txtmaTL";
            this.txtmaTL.Size = new System.Drawing.Size(187, 20);
            this.txtmaTL.TabIndex = 9;
            // 
            // traSach_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 429);
            this.Controls.Add(this.txtmaTL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtslmuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.bttrasach);
            this.Controls.Add(this.btview);
            this.Controls.Add(this.view);
            this.Controls.Add(this.txtmadg);
            this.Controls.Add(this.label1);
            this.Name = "traSach_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Tài Liệu";
            this.Load += new System.EventHandler(this.traSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Button btview;
        private System.Windows.Forms.Button bttrasach;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtslmuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaTL;
    }
}