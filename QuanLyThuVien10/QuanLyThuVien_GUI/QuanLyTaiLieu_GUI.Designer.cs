namespace QuanLyThuVien_GUI
{
    partial class QuanLyTaiLieu_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiLieu_GUI));
            this.dgvQuanLyTaiLieu = new System.Windows.Forms.DataGridView();
            this.maTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaThL = new System.Windows.Forms.ComboBox();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTaiLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLyTaiLieu
            // 
            this.dgvQuanLyTaiLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyTaiLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTL,
            this.tenTL,
            this.maThL,
            this.soLuong,
            this.nhaXB,
            this.namXB,
            this.tacGia});
            this.dgvQuanLyTaiLieu.Location = new System.Drawing.Point(12, 288);
            this.dgvQuanLyTaiLieu.Name = "dgvQuanLyTaiLieu";
            this.dgvQuanLyTaiLieu.Size = new System.Drawing.Size(743, 150);
            this.dgvQuanLyTaiLieu.TabIndex = 0;
            this.dgvQuanLyTaiLieu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyTaiLieu_RowEnter);
            // 
            // maTL
            // 
            this.maTL.DataPropertyName = "maTL";
            this.maTL.HeaderText = "Mã Tài Liệu";
            this.maTL.Name = "maTL";
            // 
            // tenTL
            // 
            this.tenTL.DataPropertyName = "tenTL";
            this.tenTL.HeaderText = "Tên Tài Liệu";
            this.tenTL.Name = "tenTL";
            // 
            // maThL
            // 
            this.maThL.DataPropertyName = "maThL";
            this.maThL.HeaderText = "Mã Thể Loại";
            this.maThL.Name = "maThL";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            // 
            // nhaXB
            // 
            this.nhaXB.DataPropertyName = "nhaXB";
            this.nhaXB.HeaderText = "Nhà XB";
            this.nhaXB.Name = "nhaXB";
            // 
            // namXB
            // 
            this.namXB.DataPropertyName = "namXB";
            this.namXB.HeaderText = "Năm XB";
            this.namXB.Name = "namXB";
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác Giả";
            this.tacGia.Name = "tacGia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Tài Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Tài Liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Thể Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhà XB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Năm XB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tác Giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(263, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quản Lý Tài Liệu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaThL
            // 
            this.cbMaThL.FormattingEnabled = true;
            this.cbMaThL.Location = new System.Drawing.Point(118, 129);
            this.cbMaThL.Name = "cbMaThL";
            this.cbMaThL.Size = new System.Drawing.Size(121, 21);
            this.cbMaThL.TabIndex = 9;
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(118, 66);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(121, 20);
            this.txtMaTL.TabIndex = 10;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(118, 103);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(121, 20);
            this.txtTenTL.TabIndex = 11;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(118, 163);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(121, 20);
            this.txtSL.TabIndex = 12;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(404, 83);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(117, 20);
            this.txtNhaXB.TabIndex = 13;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(404, 126);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(117, 20);
            this.txtNamXB.TabIndex = 14;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(405, 163);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(116, 20);
            this.txtTG.TabIndex = 15;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLai.Image")));
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(23, 214);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(103, 40);
            this.btnNhapLai.TabIndex = 16;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(143, 214);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(254, 214);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(357, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(514, 214);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 39);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(605, 59);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 40);
            this.btnXem.TabIndex = 21;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(605, 119);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(0, 0);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(605, 119);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(85, 41);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(605, 231);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(116, 20);
            this.txtTim.TabIndex = 25;
            // 
            // QuanLyTaiLieu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.txtTG);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.txtNhaXB);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenTL);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.cbMaThL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQuanLyTaiLieu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "QuanLyTaiLieu_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTaiLieu_GUI";
            this.Load += new System.EventHandler(this.QuanLyTaiLieu_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTaiLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThL;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaThL;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtTim;
    }
}