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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTLvaoPM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tài Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(443, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // txtmaTL
            // 
            this.txtmaTL.Location = new System.Drawing.Point(120, 68);
            this.txtmaTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaTL.Name = "txtmaTL";
            this.txtmaTL.Size = new System.Drawing.Size(258, 22);
            this.txtmaTL.TabIndex = 2;
            this.txtmaTL.TextChanged += new System.EventHandler(this.txtmaTL_TextChanged_1);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(531, 68);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(286, 22);
            this.txtsl.TabIndex = 3;
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btreset.Image = ((System.Drawing.Image)(resources.GetObject("btreset.Image")));
            this.btreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btreset.Location = new System.Drawing.Point(545, 129);
            this.btreset.Margin = new System.Windows.Forms.Padding(4);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(96, 40);
            this.btreset.TabIndex = 5;
            this.btreset.Text = "Reset";
            this.btreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click_1);
            // 
            // btbo
            // 
            this.btbo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btbo.Image = ((System.Drawing.Image)(resources.GetObject("btbo.Image")));
            this.btbo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbo.Location = new System.Drawing.Point(412, 129);
            this.btbo.Margin = new System.Windows.Forms.Padding(4);
            this.btbo.Name = "btbo";
            this.btbo.Size = new System.Drawing.Size(85, 40);
            this.btbo.TabIndex = 6;
            this.btbo.Text = "Bỏ";
            this.btbo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbo.UseVisualStyleBackColor = true;
            this.btbo.Click += new System.EventHandler(this.btbo_Click_1);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btthoat.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.Image")));
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthoat.Location = new System.Drawing.Point(699, 129);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 40);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click_1);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btthem.Image = ((System.Drawing.Image)(resources.GetObject("btthem.Image")));
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(144, 129);
            this.btthem.Margin = new System.Windows.Forms.Padding(4);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(89, 40);
            this.btthem.TabIndex = 10;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.view.Location = new System.Drawing.Point(196, 187);
            this.view.Margin = new System.Windows.Forms.Padding(4);
            this.view.Name = "view";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.view.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.view.Size = new System.Drawing.Size(499, 295);
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
            this.btsua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btsua.Image = ((System.Drawing.Image)(resources.GetObject("btsua.Image")));
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(278, 129);
            this.btsua.Margin = new System.Windows.Forms.Padding(4);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(87, 40);
            this.btsua.TabIndex = 12;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btIn
            // 
            this.btIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btIn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btIn.Location = new System.Drawing.Point(732, 187);
            this.btIn.Margin = new System.Windows.Forms.Padding(4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(67, 58);
            this.btIn.TabIndex = 13;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click_1);
            // 
            // lbPM
            // 
            this.lbPM.AutoSize = true;
            this.lbPM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbPM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPM.Location = new System.Drawing.Point(16, 105);
            this.lbPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPM.Name = "lbPM";
            this.lbPM.Size = new System.Drawing.Size(88, 16);
            this.lbPM.TabIndex = 9;
            this.lbPM.Text = "                    ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 47);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chi Tiết Phiếu Mượn";
            // 
            // ThemTLvaoPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(849, 486);
            this.Controls.Add(this.panel1);
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
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(210, 110);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemTLvaoPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chỉnh Chi Tiết Phiếu Mượn";
            this.Load += new System.EventHandler(this.ThemTLvaoPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}