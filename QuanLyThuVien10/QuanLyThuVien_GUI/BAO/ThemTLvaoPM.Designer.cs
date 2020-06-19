namespace QuanLyThuVien_GUI
{
    partial class ThemTLvaoPM
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
            this.txtmaTL = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btbo = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.DataGridView();
            this.maTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btsua = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.lbPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tài Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // txtmaTL
            // 
            this.txtmaTL.Location = new System.Drawing.Point(81, 25);
            this.txtmaTL.Name = "txtmaTL";
            this.txtmaTL.Size = new System.Drawing.Size(225, 20);
            this.txtmaTL.TabIndex = 2;
            this.txtmaTL.TextChanged += new System.EventHandler(this.txtmaTL_TextChanged_1);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(387, 26);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(237, 20);
            this.txtsl.TabIndex = 3;
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(468, 56);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 5;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click_1);
            // 
            // btbo
            // 
            this.btbo.Location = new System.Drawing.Point(387, 56);
            this.btbo.Name = "btbo";
            this.btbo.Size = new System.Drawing.Size(75, 23);
            this.btbo.TabIndex = 6;
            this.btbo.Text = "Bỏ";
            this.btbo.UseVisualStyleBackColor = true;
            this.btbo.Click += new System.EventHandler(this.btbo_Click_1);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(549, 56);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click_1);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(225, 56);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 10;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click_1);
            // 
            // view
            // 
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTL,
            this.tenTL,
            this.soLuongMuon});
            this.view.Location = new System.Drawing.Point(71, 85);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(498, 240);
            this.view.TabIndex = 11;
            this.view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_CellClick_1);
            // 
            // maTL
            // 
            this.maTL.DataPropertyName = "maTL";
            this.maTL.HeaderText = "Mã Tài Liệu";
            this.maTL.Name = "maTL";
            this.maTL.Width = 150;
            // 
            // tenTL
            // 
            this.tenTL.DataPropertyName = "tenTL";
            this.tenTL.HeaderText = "Tên Tài Liệu";
            this.tenTL.Name = "tenTL";
            this.tenTL.Width = 150;
            // 
            // soLuongMuon
            // 
            this.soLuongMuon.DataPropertyName = "soLuongMuon";
            this.soLuongMuon.HeaderText = "Số Lượng Mượn";
            this.soLuongMuon.Name = "soLuongMuon";
            this.soLuongMuon.Width = 150;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(306, 56);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 12;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btIn
            // 
            this.btIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btIn.Location = new System.Drawing.Point(574, 85);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(50, 47);
            this.btIn.TabIndex = 13;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click_1);
            // 
            // lbPM
            // 
            this.lbPM.AutoSize = true;
            this.lbPM.Location = new System.Drawing.Point(8, 69);
            this.lbPM.Name = "lbPM";
            this.lbPM.Size = new System.Drawing.Size(67, 13);
            this.lbPM.TabIndex = 9;
            this.lbPM.Text = "                    ";
            // 
            // ThemTLvaoPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 336);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.view);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.lbPM);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btbo);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtmaTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemTLvaoPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Chi Tiết Phiếu Mượn";
            this.Load += new System.EventHandler(this.ThemTLvaoPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaTL;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btbo;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongMuon;
        private System.Windows.Forms.Button btsua;
        //  private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Label lbPM;
    }
}