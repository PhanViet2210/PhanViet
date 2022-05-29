namespace BANHANG
{
    partial class frmNhaCungCap
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
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.dataGridNCC = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblSDTNCC = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiachi.Location = new System.Drawing.Point(782, 209);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(210, 29);
            this.txtDiachi.TabIndex = 119;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiachi.Location = new System.Drawing.Point(684, 211);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(57, 21);
            this.lblDiachi.TabIndex = 118;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // dataGridNCC
            // 
            this.dataGridNCC.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNCC.EnableHeadersVisualStyles = false;
            this.dataGridNCC.Location = new System.Drawing.Point(397, 313);
            this.dataGridNCC.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridNCC.Name = "dataGridNCC";
            this.dataGridNCC.RowHeadersWidth = 51;
            this.dataGridNCC.RowTemplate.Height = 24;
            this.dataGridNCC.Size = new System.Drawing.Size(450, 209);
            this.dataGridNCC.TabIndex = 117;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(450, 608);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 40);
            this.btnLuu.TabIndex = 116;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSDTNCC.Location = new System.Drawing.Point(782, 171);
            this.txtSDTNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(210, 29);
            this.txtSDTNCC.TabIndex = 115;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenNCC.Location = new System.Drawing.Point(321, 212);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(210, 29);
            this.txtTenNCC.TabIndex = 114;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaNCC.Location = new System.Drawing.Point(321, 175);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(210, 29);
            this.txtMaNCC.TabIndex = 113;
            // 
            // lblSDTNCC
            // 
            this.lblSDTNCC.AutoSize = true;
            this.lblSDTNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSDTNCC.Location = new System.Drawing.Point(675, 175);
            this.lblSDTNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDTNCC.Name = "lblSDTNCC";
            this.lblSDTNCC.Size = new System.Drawing.Size(101, 21);
            this.lblSDTNCC.TabIndex = 112;
            this.lblSDTNCC.Text = "Số điện thoại";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenNCC.Location = new System.Drawing.Point(185, 215);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(129, 21);
            this.lblTenNCC.TabIndex = 111;
            this.lblTenNCC.Text = "Tên nhà cung cấp";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaNCC.Location = new System.Drawing.Point(185, 178);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(128, 21);
            this.lblMaNCC.TabIndex = 110;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(838, 608);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 109;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(577, 608);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 108;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(709, 608);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.TabIndex = 107;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(318, 608);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 106;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 69);
            this.panel1.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(492, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "NHÀ CUNG CẤP";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.dataGridNCC);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSDTNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lblSDTNCC);
            this.Controls.Add(this.lblTenNCC);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "frmNhaCungCap";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmDMNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.DataGridView dataGridNCC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblSDTNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}