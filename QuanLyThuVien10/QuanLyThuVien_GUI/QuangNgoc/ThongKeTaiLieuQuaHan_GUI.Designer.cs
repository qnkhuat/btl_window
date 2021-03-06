﻿namespace QuanLyThuVien_GUI
{
    partial class ThongKeTaiLieuQuaHan_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeTaiLieuQuaHan_GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayM = new System.Windows.Forms.DateTimePicker();
            this.dtNgayT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(378, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Trả";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maDG,
            this.hoTenDG,
            this.tenTL,
            this.ngayMuon,
            this.soNgayQH});
            this.dgvThongKe.Location = new System.Drawing.Point(3, 0);
            this.dgvThongKe.Name = "dgvThongKe";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvThongKe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.Size = new System.Drawing.Size(714, 150);
            this.dgvThongKe.TabIndex = 4;
            this.dgvThongKe.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvThongKe_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 0.8519366F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 100;
            this.STT.Name = "STT";
            // 
            // maDG
            // 
            this.maDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maDG.DataPropertyName = "maDG";
            this.maDG.FillWeight = 304.5685F;
            this.maDG.HeaderText = "Mã Độc giả";
            this.maDG.MinimumWidth = 100;
            this.maDG.Name = "maDG";
            // 
            // hoTenDG
            // 
            this.hoTenDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hoTenDG.DataPropertyName = "hoTenDG";
            this.hoTenDG.FillWeight = 83.39095F;
            this.hoTenDG.HeaderText = "Tên Độc giả";
            this.hoTenDG.MinimumWidth = 150;
            this.hoTenDG.Name = "hoTenDG";
            this.hoTenDG.Width = 150;
            // 
            // tenTL
            // 
            this.tenTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenTL.DataPropertyName = "tenTL";
            this.tenTL.FillWeight = 22.84485F;
            this.tenTL.HeaderText = "Tên Tài Liệu";
            this.tenTL.MinimumWidth = 150;
            this.tenTL.Name = "tenTL";
            this.tenTL.Width = 150;
            // 
            // ngayMuon
            // 
            this.ngayMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngayMuon.DataPropertyName = "ngayMuon";
            this.ngayMuon.FillWeight = 112.8701F;
            this.ngayMuon.HeaderText = "Ngày Mượn";
            this.ngayMuon.MinimumWidth = 100;
            this.ngayMuon.Name = "ngayMuon";
            // 
            // soNgayQH
            // 
            this.soNgayQH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soNgayQH.DataPropertyName = "soNgayQH";
            this.soNgayQH.FillWeight = 75.47364F;
            this.soNgayQH.HeaderText = "Số Ngày Quá Hạn";
            this.soNgayQH.MinimumWidth = 100;
            this.soNgayQH.Name = "soNgayQH";
            // 
            // dtNgayM
            // 
            this.dtNgayM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayM.Location = new System.Drawing.Point(107, 13);
            this.dtNgayM.Name = "dtNgayM";
            this.dtNgayM.Size = new System.Drawing.Size(200, 20);
            this.dtNgayM.TabIndex = 7;
            this.dtNgayM.Value = new System.DateTime(1999, 2, 2, 0, 0, 0, 0);
            // 
            // dtNgayT
            // 
            this.dtNgayT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayT.Location = new System.Drawing.Point(506, 13);
            this.dtNgayT.Name = "dtNgayT";
            this.dtNgayT.Size = new System.Drawing.Size(200, 20);
            this.dtNgayT.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(256, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thống kê tài Liệu Quá Hạn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXuat.Location = new System.Drawing.Point(433, 155);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(125, 42);
            this.btnXuat.TabIndex = 10;
            this.btnXuat.Text = "Xuất Báo Cáo";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 44);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThongKe);
            this.panel2.Location = new System.Drawing.Point(2, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 152);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtNgayM);
            this.panel3.Controls.Add(this.dtNgayT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(2, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 62);
            this.panel3.TabIndex = 13;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(142, 155);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 42);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // ThongKeTaiLieuQuaHan_GUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(720, 417);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnTim);
            this.Name = "ThongKeTaiLieuQuaHan_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeTaiLieuQuaHan_GUI";
            this.Load += new System.EventHandler(this.ThongKeTaiLieuQuaHan_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtNgayM;
        private System.Windows.Forms.DateTimePicker dtNgayT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayQH;
    }
}