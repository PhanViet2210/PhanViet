
namespace BANHANG
{
    partial class frmQuanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIDTaiKhoan = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboQuyenTruyCap = new System.Windows.Forms.ComboBox();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDTaiKhoan
            // 
            this.txtIDTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIDTaiKhoan.Location = new System.Drawing.Point(437, 132);
            this.txtIDTaiKhoan.Name = "txtIDTaiKhoan";
            this.txtIDTaiKhoan.Size = new System.Drawing.Size(408, 29);
            this.txtIDTaiKhoan.TabIndex = 1;
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(309, 387);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(536, 256);
            this.dataGrid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(305, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(305, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(305, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLoaiTK.Location = new System.Drawing.Point(437, 176);
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.Size = new System.Drawing.Size(408, 29);
            this.txtLoaiTK.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(437, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(408, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(305, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(305, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quyền truy cập";
            // 
            // cboQuyenTruyCap
            // 
            this.cboQuyenTruyCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyenTruyCap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboQuyenTruyCap.FormattingEnabled = true;
            this.cboQuyenTruyCap.Location = new System.Drawing.Point(437, 307);
            this.cboQuyenTruyCap.Name = "cboQuyenTruyCap";
            this.cboQuyenTruyCap.Size = new System.Drawing.Size(408, 29);
            this.cboQuyenTruyCap.TabIndex = 3;
            // 
            // btnChen
            // 
            this.btnChen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnChen.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnChen.ForeColor = System.Drawing.Color.White;
            this.btnChen.Location = new System.Drawing.Point(934, 462);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(80, 38);
            this.btnChen.TabIndex = 2;
            this.btnChen.Text = "CHÈN";
            this.btnChen.UseVisualStyleBackColor = false;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(934, 527);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMatKhau.Location = new System.Drawing.Point(437, 264);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(408, 29);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(448, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 53);
            this.panel1.TabIndex = 6;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnTao.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTao.Location = new System.Drawing.Point(934, 398);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(80, 38);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "TẠO";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(934, 592);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.cboQuyenTruyCap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLoaiTK);
            this.Controls.Add(this.txtIDTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FrmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDTaiKhoan;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoaiTK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboQuyenTruyCap;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}