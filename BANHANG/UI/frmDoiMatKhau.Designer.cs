
namespace BANHANG
{
    partial class frmDoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(645, 583);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 49);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMKCu.Location = new System.Drawing.Point(803, 267);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(409, 34);
            this.txtMKCu.TabIndex = 2;
            this.txtMKCu.TextChanged += new System.EventHandler(this.txtMKCu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(540, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(540, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(540, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xác nhận mật khẩu mới";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Brown;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(919, 583);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 49);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMKMoi.Location = new System.Drawing.Point(803, 342);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(409, 34);
            this.txtMKMoi.TabIndex = 2;
            this.txtMKMoi.TextChanged += new System.EventHandler(this.txtMKMoi_TextChanged);
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNhapLaiMK.Location = new System.Drawing.Point(803, 415);
            this.txtNhapLaiMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(409, 34);
            this.txtNhapLaiMK.TabIndex = 2;
            this.txtNhapLaiMK.TextChanged += new System.EventHandler(this.txtNhapLaiMK_TextChanged);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(1239, 353);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(0, 17);
            this.lblMatKhau.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1827, 65);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(796, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}