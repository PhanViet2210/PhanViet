namespace BANHANG
{
    partial class frmKhachHang
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSDTKH = new System.Windows.Forms.Label();
            this.dataGridKH = new System.Windows.Forms.DataGridView();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(448, 598);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 40);
            this.btnLuu.TabIndex = 121;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(815, 598);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(568, 598);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 119;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(689, 598);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.TabIndex = 118;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(327, 598);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 117;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(672, 130);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 116;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(737, 127);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 29);
            this.txtEmail.TabIndex = 115;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblSDTKH
            // 
            this.lblSDTKH.AutoSize = true;
            this.lblSDTKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSDTKH.Location = new System.Drawing.Point(212, 187);
            this.lblSDTKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDTKH.Name = "lblSDTKH";
            this.lblSDTKH.Size = new System.Drawing.Size(101, 21);
            this.lblSDTKH.TabIndex = 114;
            this.lblSDTKH.Text = "Số điện thoại";
            // 
            // dataGridKH
            // 
            this.dataGridKH.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKH.EnableHeadersVisualStyles = false;
            this.dataGridKH.Location = new System.Drawing.Point(334, 270);
            this.dataGridKH.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridKH.Name = "dataGridKH";
            this.dataGridKH.RowHeadersWidth = 51;
            this.dataGridKH.RowTemplate.Height = 24;
            this.dataGridKH.Size = new System.Drawing.Size(546, 247);
            this.dataGridKH.TabIndex = 113;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiachi.Location = new System.Drawing.Point(737, 165);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(210, 29);
            this.txtDiachi.TabIndex = 112;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSDTKH.Location = new System.Drawing.Point(334, 184);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(210, 29);
            this.txtSDTKH.TabIndex = 111;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenKH.Location = new System.Drawing.Point(334, 146);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(210, 29);
            this.txtTenKH.TabIndex = 110;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaKH.Location = new System.Drawing.Point(334, 107);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(210, 29);
            this.txtMaKH.TabIndex = 109;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiachi.Location = new System.Drawing.Point(672, 168);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(57, 21);
            this.lblDiachi.TabIndex = 108;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKH.Location = new System.Drawing.Point(212, 149);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 21);
            this.lblTenKH.TabIndex = 107;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaKH.Location = new System.Drawing.Point(212, 110);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(116, 21);
            this.lblMaKH.TabIndex = 106;
            this.lblMaKH.Text = "Mã khách hàng";
            this.lblMaKH.Click += new System.EventHandler(this.lblMaKH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 53);
            this.panel1.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(502, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSDTKH);
            this.Controls.Add(this.dataGridKH);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaKH);
            this.Name = "frmKhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.FrmDMKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSDTKH;
        private System.Windows.Forms.DataGridView dataGridKH;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}