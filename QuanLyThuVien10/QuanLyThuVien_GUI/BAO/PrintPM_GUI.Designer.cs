﻿namespace QuanLyThuVien_GUI.BAO
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
            this.reportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.ActiveViewIndex = -1;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.reportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // PrintPM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintPM_GUI";
            this.Text = "PrintPM_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer1;
    }
}