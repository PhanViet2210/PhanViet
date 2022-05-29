
namespace BANHANG
{
    partial class frmBaoCaoTonKho
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
            this.crystalRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalRV
            // 
            this.crystalRV.ActiveViewIndex = -1;
            this.crystalRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalRV.Location = new System.Drawing.Point(0, 0);
            this.crystalRV.Margin = new System.Windows.Forms.Padding(4);
            this.crystalRV.Name = "crystalRV";
            this.crystalRV.Size = new System.Drawing.Size(1067, 554);
            this.crystalRV.TabIndex = 0;
            this.crystalRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalRV.Load += new System.EventHandler(this.crystalRV_Load);
            // 
            // frmBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.crystalRV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoCaoTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoTonKho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalRV;
    }
}