
namespace BANHANG
{
    partial class FrmTaiKhoan
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dfcdfcd = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(1008, 702);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(153, 49);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(468, 294);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(279, 34);
            this.txtHoTen.TabIndex = 1;
            // 
            // dfcdfcd
            // 
            this.dfcdfcd.AutoSize = true;
            this.dfcdfcd.BackColor = System.Drawing.Color.Transparent;
            this.dfcdfcd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.dfcdfcd.ForeColor = System.Drawing.Color.White;
            this.dfcdfcd.Location = new System.Drawing.Point(601, 14);
            this.dfcdfcd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dfcdfcd.Name = "dfcdfcd";
            this.dfcdfcd.Size = new System.Drawing.Size(322, 37);
            this.dfcdfcd.TabIndex = 2;
            this.dfcdfcd.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoDT.Location = new System.Drawing.Point(468, 358);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(279, 34);
            this.txtSoDT.TabIndex = 1;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(329, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(329, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(329, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(909, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vai trò";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(909, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(468, 421);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(279, 34);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(991, 326);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 34);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.Location = new System.Drawing.Point(409, 702);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(153, 49);
            this.btnDoiMK.TabIndex = 0;
            this.btnDoiMK.Text = "ĐỔI MẬT KHẨU";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtVaiTro.Location = new System.Drawing.Point(991, 389);
            this.txtVaiTro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(279, 34);
            this.txtVaiTro.TabIndex = 1;
            this.txtVaiTro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.dfcdfcd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 65);
            this.panel1.TabIndex = 7;
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 873);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVaiTro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnCapNhat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTaiKhoan";
            this.Text = "FrmTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label dfcdfcd;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Panel panel1;
    }
}