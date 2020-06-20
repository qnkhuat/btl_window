namespace QuanLyThuVien_GUI
{
    partial class muonSach_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(muonSach_GUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmapm = new System.Windows.Forms.TextBox();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.txttendg = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.bttim = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btxem = new System.Windows.Forms.Button();
            this.btnhaplai = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.viewphieumuon = new System.Windows.Forms.DataGridView();
            this.maPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btsuapmct = new System.Windows.Forms.Button();
            this.btdonpm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.viewphieumuon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên độc giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(620, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(620, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên nhân viên";
            // 
            // txtmapm
            // 
            this.txtmapm.Location = new System.Drawing.Point(155, 64);
            this.txtmapm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmapm.Name = "txtmapm";
            this.txtmapm.Size = new System.Drawing.Size(307, 22);
            this.txtmapm.TabIndex = 7;
            this.txtmapm.TextChanged += new System.EventHandler(this.txtmapm_TextChanged_1);
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(155, 110);
            this.txtmadg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(307, 22);
            this.txtmadg.TabIndex = 8;
            this.txtmadg.TextChanged += new System.EventHandler(this.txtmadg_TextChanged_1);
            // 
            // txttendg
            // 
            this.txttendg.Location = new System.Drawing.Point(155, 154);
            this.txttendg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttendg.Name = "txttendg";
            this.txttendg.Size = new System.Drawing.Size(307, 22);
            this.txttendg.TabIndex = 9;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(753, 139);
            this.txttennv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(282, 22);
            this.txttennv.TabIndex = 10;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(753, 85);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(282, 22);
            this.txtmanv.TabIndex = 11;
            this.txtmanv.TextChanged += new System.EventHandler(this.txtmanv_TextChanged_1);
            // 
            // bttim
            // 
            this.bttim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bttim.Image = ((System.Drawing.Image)(resources.GetObject("bttim.Image")));
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(494, 73);
            this.bttim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(99, 34);
            this.bttim.TabIndex = 13;
            this.bttim.Text = "Tìm";
            this.bttim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click_1);
            // 
            // btluu
            // 
            this.btluu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(28, 195);
            this.btluu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(85, 38);
            this.btluu.TabIndex = 14;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btsua
            // 
            this.btsua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btsua.Image = ((System.Drawing.Image)(resources.GetObject("btsua.Image")));
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(135, 195);
            this.btsua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(86, 38);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btxoa
            // 
            this.btxoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btxoa.Image = ((System.Drawing.Image)(resources.GetObject("btxoa.Image")));
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(252, 195);
            this.btxoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(83, 38);
            this.btxoa.TabIndex = 16;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click_1);
            // 
            // btxem
            // 
            this.btxem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btxem.Image = ((System.Drawing.Image)(resources.GetObject("btxem.Image")));
            this.btxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxem.Location = new System.Drawing.Point(494, 137);
            this.btxem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(101, 39);
            this.btxem.TabIndex = 17;
            this.btxem.Text = "Load_PM";
            this.btxem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxem.UseVisualStyleBackColor = true;
            this.btxem.Click += new System.EventHandler(this.btxem_Click_1);
            // 
            // btnhaplai
            // 
            this.btnhaplai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btnhaplai.Image")));
            this.btnhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhaplai.Location = new System.Drawing.Point(832, 195);
            this.btnhaplai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(101, 38);
            this.btnhaplai.TabIndex = 19;
            this.btnhaplai.Text = "Nhập Lại";
            this.btnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhaplai.UseVisualStyleBackColor = true;
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click_1);
            // 
            // btthoat
            // 
            this.btthoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btthoat.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.Image")));
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthoat.Location = new System.Drawing.Point(962, 195);
            this.btthoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(82, 38);
            this.btthoat.TabIndex = 20;
            this.btthoat.Text = "Thoát";
            this.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click_1);
            // 
            // viewphieumuon
            // 
            this.viewphieumuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewphieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPM,
            this.maDG,
            this.hotenDG,
            this.maNV,
            this.hotenNV,
            this.ngayMuon});
            this.viewphieumuon.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewphieumuon.Location = new System.Drawing.Point(101, 299);
            this.viewphieumuon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viewphieumuon.Name = "viewphieumuon";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.viewphieumuon.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.viewphieumuon.Size = new System.Drawing.Size(859, 252);
            this.viewphieumuon.TabIndex = 21;
            this.viewphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewphieumuon_CellClick_1);
            // 
            // maPM
            // 
            this.maPM.DataPropertyName = "maPM";
            this.maPM.HeaderText = "Mã Phiếu";
            this.maPM.Name = "maPM";
            this.maPM.Width = 150;
            // 
            // maDG
            // 
            this.maDG.DataPropertyName = "maDG";
            this.maDG.HeaderText = "Mã Độc Giả";
            this.maDG.Name = "maDG";
            this.maDG.Width = 120;
            // 
            // hotenDG
            // 
            this.hotenDG.DataPropertyName = "hotenDG";
            this.hotenDG.HeaderText = "Tên Độc Giả";
            this.hotenDG.Name = "hotenDG";
            this.hotenDG.Width = 120;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã Nhân Viên";
            this.maNV.Name = "maNV";
            this.maNV.Width = 150;
            // 
            // hotenNV
            // 
            this.hotenNV.DataPropertyName = "hotenNV";
            this.hotenNV.HeaderText = "Tên Nhân Viên";
            this.hotenNV.Name = "hotenNV";
            this.hotenNV.Width = 150;
            // 
            // ngayMuon
            // 
            this.ngayMuon.DataPropertyName = "ngayMuon";
            this.ngayMuon.HeaderText = "Ngày Mượn";
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Width = 120;
            // 
            // btsuapmct
            // 
            this.btsuapmct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btsuapmct.Location = new System.Drawing.Point(354, 195);
            this.btsuapmct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btsuapmct.Name = "btsuapmct";
            this.btsuapmct.Size = new System.Drawing.Size(239, 38);
            this.btsuapmct.TabIndex = 24;
            this.btsuapmct.Text = "Chi tiết phiếu mượn";
            this.btsuapmct.UseVisualStyleBackColor = true;
            this.btsuapmct.Click += new System.EventHandler(this.btsuapmct_Click_1);
            // 
            // btdonpm
            // 
            this.btdonpm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btdonpm.Image = ((System.Drawing.Image)(resources.GetObject("btdonpm.Image")));
            this.btdonpm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdonpm.Location = new System.Drawing.Point(613, 195);
            this.btdonpm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btdonpm.Name = "btdonpm";
            this.btdonpm.Size = new System.Drawing.Size(182, 38);
            this.btdonpm.TabIndex = 25;
            this.btdonpm.Text = "Dọn phiếu mượn";
            this.btdonpm.UseVisualStyleBackColor = true;
            this.btdonpm.Click += new System.EventHandler(this.btdonpm_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-5, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 55);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(491, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chỉnh Sửa Phiếu Mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thông Tin Các Phiếu Mượn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(101, 246);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 45);
            this.panel1.TabIndex = 26;
            // 
            // muonSach_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btdonpm);
            this.Controls.Add(this.btsuapmct);
            this.Controls.Add(this.viewphieumuon);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btnhaplai);
            this.Controls.Add(this.btxem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txttendg);
            this.Controls.Add(this.txtmadg);
            this.Controls.Add(this.txtmapm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(210, 110);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "muonSach_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Chỉnh Sửa Phiếu Mượn";
            this.Load += new System.EventHandler(this.muonSach_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewphieumuon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmapm;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.TextBox txttendg;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btxem;
        private System.Windows.Forms.Button btnhaplai;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridView viewphieumuon;
        private System.Windows.Forms.Button btsuapmct;
        private System.Windows.Forms.Button btdonpm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        //  private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}