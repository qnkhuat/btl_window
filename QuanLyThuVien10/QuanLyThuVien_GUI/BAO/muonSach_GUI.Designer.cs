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
            this.laTLmuon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btsuapmct = new System.Windows.Forms.Button();
            this.btdonpm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.viewphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên độc giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên nhân viên";
            // 
            // txtmapm
            // 
            this.txtmapm.Location = new System.Drawing.Point(95, 13);
            this.txtmapm.Name = "txtmapm";
            this.txtmapm.Size = new System.Drawing.Size(291, 20);
            this.txtmapm.TabIndex = 7;
            this.txtmapm.TextChanged += new System.EventHandler(this.txtmapm_TextChanged_1);
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(95, 41);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(291, 20);
            this.txtmadg.TabIndex = 8;
            this.txtmadg.TextChanged += new System.EventHandler(this.txtmadg_TextChanged_1);
            // 
            // txttendg
            // 
            this.txttendg.Location = new System.Drawing.Point(95, 71);
            this.txttendg.Name = "txttendg";
            this.txttendg.Size = new System.Drawing.Size(291, 20);
            this.txttendg.TabIndex = 9;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(624, 67);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(299, 20);
            this.txttennv.TabIndex = 10;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(624, 17);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(299, 20);
            this.txtmanv.TabIndex = 11;
            this.txtmanv.TextChanged += new System.EventHandler(this.txtmanv_TextChanged_1);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(429, 20);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 23);
            this.bttim.TabIndex = 13;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click_1);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(36, 132);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 14;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(117, 132);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(198, 132);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 16;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click_1);
            // 
            // btxem
            // 
            this.btxem.Location = new System.Drawing.Point(429, 65);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(75, 23);
            this.btxem.TabIndex = 17;
            this.btxem.Text = "Load_PM";
            this.btxem.UseVisualStyleBackColor = true;
            this.btxem.Click += new System.EventHandler(this.btxem_Click_1);
            // 
            // btnhaplai
            // 
            this.btnhaplai.Location = new System.Drawing.Point(714, 132);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnhaplai.TabIndex = 19;
            this.btnhaplai.Text = "Nhập Lại";
            this.btnhaplai.UseVisualStyleBackColor = true;
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click_1);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(848, 132);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 20;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click_1);
            // 
            // viewphieumuon
            // 
            this.viewphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewphieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPM,
            this.maDG,
            this.hotenDG,
            this.maNV,
            this.hotenNV,
            this.ngayMuon});
            this.viewphieumuon.Location = new System.Drawing.Point(83, 182);
            this.viewphieumuon.Name = "viewphieumuon";
            this.viewphieumuon.Size = new System.Drawing.Size(765, 304);
            this.viewphieumuon.TabIndex = 21;
            this.viewphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewphieumuon_CellClick_1);
            // 
            // maPM
            // 
            this.maPM.DataPropertyName = "maPM";
            this.maPM.HeaderText = "Mã Phiếu";
            this.maPM.Name = "maPM";
            this.maPM.Width = 120;
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
            this.maNV.Width = 120;
            // 
            // hotenNV
            // 
            this.hotenNV.DataPropertyName = "hotenNV";
            this.hotenNV.HeaderText = "Tên Nhân Viên";
            this.hotenNV.Name = "hotenNV";
            this.hotenNV.Width = 120;
            // 
            // ngayMuon
            // 
            this.ngayMuon.DataPropertyName = "ngayMuon";
            this.ngayMuon.HeaderText = "Ngày Mượn";
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Width = 120;
            // 
            // laTLmuon
            // 
            this.laTLmuon.AutoSize = true;
            this.laTLmuon.Location = new System.Drawing.Point(92, 166);
            this.laTLmuon.Name = "laTLmuon";
            this.laTLmuon.Size = new System.Drawing.Size(115, 13);
            this.laTLmuon.TabIndex = 22;
            this.laTLmuon.Text = "                                    ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thông Tin Các Phiếu Mượn";
            // 
            // btsuapmct
            // 
            this.btsuapmct.Location = new System.Drawing.Point(292, 132);
            this.btsuapmct.Name = "btsuapmct";
            this.btsuapmct.Size = new System.Drawing.Size(179, 23);
            this.btsuapmct.TabIndex = 24;
            this.btsuapmct.Text = "Chi tiết phiếu mượn";
            this.btsuapmct.UseVisualStyleBackColor = true;
            this.btsuapmct.Click += new System.EventHandler(this.btsuapmct_Click_1);
            // 
            // btdonpm
            // 
            this.btdonpm.Location = new System.Drawing.Point(504, 132);
            this.btdonpm.Name = "btdonpm";
            this.btdonpm.Size = new System.Drawing.Size(179, 23);
            this.btdonpm.TabIndex = 25;
            this.btdonpm.Text = "Dọn phiếu mượn";
            this.btdonpm.UseVisualStyleBackColor = true;
            this.btdonpm.Click += new System.EventHandler(this.btdonpm_Click_1);
            // 
            // muonSach_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 501);
            this.Controls.Add(this.btdonpm);
            this.Controls.Add(this.btsuapmct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.laTLmuon);
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
            this.Name = "muonSach_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Chỉnh Sửa Phiếu Mượn";
            this.Load += new System.EventHandler(this.muonSach_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewphieumuon)).EndInit();
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
        private System.Windows.Forms.Label laTLmuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuon;
        private System.Windows.Forms.Button btsuapmct;
        private System.Windows.Forms.Button btdonpm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
      //  private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}