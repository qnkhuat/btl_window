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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtslmuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaTL = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(91, 106);
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
            this.view.Location = new System.Drawing.Point(65, 185);
            this.view.Name = "view";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.view.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.view.Size = new System.Drawing.Size(888, 343);
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
            this.btview.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btview.Location = new System.Drawing.Point(938, 42);
            this.btview.Name = "btview";
            this.btview.Size = new System.Drawing.Size(87, 44);
            this.btview.TabIndex = 3;
            this.btview.Text = "View All";
            this.btview.UseVisualStyleBackColor = false;
            this.btview.Click += new System.EventHandler(this.btview_Click_1);
            // 
            // bttrasach
            // 
            this.bttrasach.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttrasach.Location = new System.Drawing.Point(938, 98);
            this.bttrasach.Name = "bttrasach";
            this.bttrasach.Size = new System.Drawing.Size(87, 45);
            this.bttrasach.TabIndex = 4;
            this.bttrasach.Text = "Trả Sách";
            this.bttrasach.UseVisualStyleBackColor = false;
            this.bttrasach.Click += new System.EventHandler(this.bttrasach_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(624, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sô lượng mượn";
            // 
            // txtslmuon
            // 
            this.txtslmuon.Location = new System.Drawing.Point(721, 102);
            this.txtslmuon.Name = "txtslmuon";
            this.txtslmuon.Size = new System.Drawing.Size(192, 20);
            this.txtslmuon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(329, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã tài liệu";
            // 
            // txtmaTL
            // 
            this.txtmaTL.Location = new System.Drawing.Point(401, 104);
            this.txtmaTL.Name = "txtmaTL";
            this.txtmaTL.Size = new System.Drawing.Size(202, 20);
            this.txtmaTL.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(313, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 41);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(150, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trả Sách";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(67, 163);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(123, 13);
            this.lbstatus.TabIndex = 11;
            this.lbstatus.Text = "                             ";
            // 
            // traSach_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1037, 540);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtmaTL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtslmuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttrasach);
            this.Controls.Add(this.btview);
            this.Controls.Add(this.view);
            this.Controls.Add(this.txtmadg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(210, 120);
            this.Name = "traSach_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trả Tài Liệu";
            this.Load += new System.EventHandler(this.traSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Button btview;
        private System.Windows.Forms.Button bttrasach;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbstatus;
    }
}