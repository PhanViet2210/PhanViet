
namespace BANHANG
{
    partial class frmNhaSanXuat
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dataGridNSX = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSDTNSX = new System.Windows.Forms.TextBox();
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.txtMaNSX = new System.Windows.Forms.TextBox();
            this.lblSDTNSX = new System.Windows.Forms.Label();
            this.lblTenNSX = new System.Windows.Forms.Label();
            this.lblMaNSX = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNSX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(744, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 29);
            this.txtEmail.TabIndex = 135;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(648, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 134;
            this.lblEmail.Text = "Email";
            // 
            // dataGridNSX
            // 
            this.dataGridNSX.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNSX.EnableHeadersVisualStyles = false;
            this.dataGridNSX.Location = new System.Drawing.Point(380, 278);
            this.dataGridNSX.Name = "dataGridNSX";
            this.dataGridNSX.RowHeadersWidth = 51;
            this.dataGridNSX.RowTemplate.Height = 24;
            this.dataGridNSX.Size = new System.Drawing.Size(454, 241);
            this.dataGridNSX.TabIndex = 133;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(398, 597);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 38);
            this.btnLuu.TabIndex = 132;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSDTNSX
            // 
            this.txtSDTNSX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSDTNSX.Location = new System.Drawing.Point(744, 152);
            this.txtSDTNSX.Name = "txtSDTNSX";
            this.txtSDTNSX.Size = new System.Drawing.Size(167, 29);
            this.txtSDTNSX.TabIndex = 131;
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenNSX.Location = new System.Drawing.Point(357, 211);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(167, 29);
            this.txtTenNSX.TabIndex = 130;
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaNSX.Location = new System.Drawing.Point(357, 152);
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Size = new System.Drawing.Size(167, 29);
            this.txtMaNSX.TabIndex = 129;
            // 
            // lblSDTNSX
            // 
            this.lblSDTNSX.AutoSize = true;
            this.lblSDTNSX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSDTNSX.Location = new System.Drawing.Point(638, 155);
            this.lblSDTNSX.Name = "lblSDTNSX";
            this.lblSDTNSX.Size = new System.Drawing.Size(101, 21);
            this.lblSDTNSX.TabIndex = 128;
            this.lblSDTNSX.Text = "Số điện thoại";
            // 
            // lblTenNSX
            // 
            this.lblTenNSX.AutoSize = true;
            this.lblTenNSX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenNSX.Location = new System.Drawing.Point(218, 214);
            this.lblTenNSX.Name = "lblTenNSX";
            this.lblTenNSX.Size = new System.Drawing.Size(124, 21);
            this.lblTenNSX.TabIndex = 127;
            this.lblTenNSX.Text = "Tên nhà sản xuất";
            // 
            // lblMaNSX
            // 
            this.lblMaNSX.AutoSize = true;
            this.lblMaNSX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaNSX.Location = new System.Drawing.Point(218, 155);
            this.lblMaNSX.Name = "lblMaNSX";
            this.lblMaNSX.Size = new System.Drawing.Size(123, 21);
            this.lblMaNSX.TabIndex = 126;
            this.lblMaNSX.Text = "Mã nhà sản xuất";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(838, 596);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 38);
            this.btnThoat.TabIndex = 125;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(544, 597);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 38);
            this.btnXoa.TabIndex = 124;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(693, 597);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 38);
            this.btnSua.TabIndex = 123;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(252, 597);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 38);
            this.btnThem.TabIndex = 122;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 69);
            this.panel1.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(494, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "NHÀ SẢN XUẤT";
            // 
            // frmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dataGridNSX);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSDTNSX);
            this.Controls.Add(this.txtTenNSX);
            this.Controls.Add(this.txtMaNSX);
            this.Controls.Add(this.lblSDTNSX);
            this.Controls.Add(this.lblTenNSX);
            this.Controls.Add(this.lblMaNSX);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "frmNhaSanXuat";
            this.Text = "frmNhaSanXuat";
            this.Load += new System.EventHandler(this.FrmDMNSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNSX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dataGridNSX;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSDTNSX;
        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.TextBox txtMaNSX;
        private System.Windows.Forms.Label lblSDTNSX;
        private System.Windows.Forms.Label lblTenNSX;
        private System.Windows.Forms.Label lblMaNSX;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}