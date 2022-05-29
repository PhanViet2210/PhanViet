
namespace BANHANG
{
    partial class frmBaoCaoBanHang
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalRV
            // 
            this.crystalRV.ActiveViewIndex = -1;
            this.crystalRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalRV.Location = new System.Drawing.Point(0, 162);
            this.crystalRV.Name = "crystalRV";
            this.crystalRV.Size = new System.Drawing.Size(1164, 541);
            this.crystalRV.TabIndex = 0;
            this.crystalRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(90, 32);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 25);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(425, 30);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(116, 25);
            this.dtpTo.TabIndex = 2;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBaoCao.Location = new System.Drawing.Point(859, 93);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(104, 27);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "&Xem báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 164);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnBaoCao);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 144);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(259, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày bán hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(14, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 53);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO BÁN HÀNG";
            // 
            // frmBaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalRV);
            this.Name = "frmBaoCaoBanHang";
            this.Text = "BÁO CÁO BÁN HÀNG";
            this.Load += new System.EventHandler(this.frmBaoCao1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalRV;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}