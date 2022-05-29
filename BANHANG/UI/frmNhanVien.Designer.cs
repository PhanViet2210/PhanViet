namespace BANHANG
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboMaTK = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.dataGridNV = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblSDTNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblNhanVien";
            // 
            // cboMaTK
            // 
            this.cboMaTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboMaTK.FormattingEnabled = true;
            this.cboMaTK.Location = new System.Drawing.Point(771, 227);
            this.cboMaTK.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaTK.Name = "cboMaTK";
            this.cboMaTK.Size = new System.Drawing.Size(227, 29);
            this.cboMaTK.TabIndex = 129;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(771, 182);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 29);
            this.txtEmail.TabIndex = 128;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiachi.Location = new System.Drawing.Point(771, 135);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(227, 29);
            this.txtDiachi.TabIndex = 127;
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaTK.Location = new System.Drawing.Point(668, 230);
            this.lblMaTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(100, 21);
            this.lblMaTK.TabIndex = 126;
            this.lblMaTK.Text = "Mã tài khoản";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(671, 185);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 125;
            this.lblEmail.Text = "Email";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiachi.Location = new System.Drawing.Point(672, 138);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(57, 21);
            this.lblDiachi.TabIndex = 124;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // dataGridNV
            // 
            this.dataGridNV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNV.EnableHeadersVisualStyles = false;
            this.dataGridNV.Location = new System.Drawing.Point(236, 300);
            this.dataGridNV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridNV.Name = "dataGridNV";
            this.dataGridNV.RowHeadersWidth = 51;
            this.dataGridNV.RowTemplate.Height = 24;
            this.dataGridNV.Size = new System.Drawing.Size(650, 241);
            this.dataGridNV.TabIndex = 123;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(405, 605);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 38);
            this.btnLuu.TabIndex = 122;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSDTNV.Location = new System.Drawing.Point(207, 227);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(227, 29);
            this.txtSDTNV.TabIndex = 121;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenNV.Location = new System.Drawing.Point(207, 182);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(227, 29);
            this.txtTenNV.TabIndex = 120;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaNV.Location = new System.Drawing.Point(208, 135);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(227, 29);
            this.txtMaNV.TabIndex = 119;
            // 
            // lblSDTNV
            // 
            this.lblSDTNV.AutoSize = true;
            this.lblSDTNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSDTNV.Location = new System.Drawing.Point(89, 230);
            this.lblSDTNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDTNV.Name = "lblSDTNV";
            this.lblSDTNV.Size = new System.Drawing.Size(101, 21);
            this.lblSDTNV.TabIndex = 118;
            this.lblSDTNV.Text = "Số điện thoại";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenNV.Location = new System.Drawing.Point(89, 185);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(105, 21);
            this.lblTenNV.TabIndex = 117;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaNV.Location = new System.Drawing.Point(90, 138);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(104, 21);
            this.lblMaNV.TabIndex = 116;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(773, 605);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 38);
            this.btnThoat.TabIndex = 115;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(526, 605);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 38);
            this.btnXoa.TabIndex = 114;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(649, 605);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 38);
            this.btnSua.TabIndex = 113;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(284, 605);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 38);
            this.btnThem.TabIndex = 112;
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
            this.panel1.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(514, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboMaTK);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lblMaTK);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.dataGridNV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSDTNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblSDTNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "frmNhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.FrmDMNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cboMaTK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.DataGridView dataGridNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblSDTNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}