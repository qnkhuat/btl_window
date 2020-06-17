namespace QuanLyThuVien_GUI.BAO
{
    partial class PrintPM_GUI
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
            this.crrpview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crrpview
            // 
            this.crrpview.ActiveViewIndex = -1;
            this.crrpview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crrpview.Cursor = System.Windows.Forms.Cursors.Default;
            this.crrpview.DisplayStatusBar = false;
            this.crrpview.DisplayToolbar = false;
            this.crrpview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crrpview.Location = new System.Drawing.Point(0, 0);
            this.crrpview.Name = "crrpview";
            this.crrpview.Size = new System.Drawing.Size(800, 450);
            this.crrpview.TabIndex = 0;
            this.crrpview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crrpview.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // PrintPM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crrpview);
            this.Name = "PrintPM_GUI";
            this.Text = "PrintPM_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crrpview;
    }
}