
namespace BANHANG
{
    partial class frmTimKiemSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dfcdfcd = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgSPDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new BANHANG.DataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntDong = new System.Windows.Forms.Button();
            this.sanPhamTableAdapter = new BANHANG.DataSetTableAdapters.SanPhamTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bntTimKiem);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 195);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.dfcdfcd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 53);
            this.panel2.TabIndex = 41;
            // 
            // dfcdfcd
            // 
            this.dfcdfcd.AutoSize = true;
            this.dfcdfcd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.dfcdfcd.ForeColor = System.Drawing.Color.White;
            this.dfcdfcd.Location = new System.Drawing.Point(464, 12);
            this.dfcdfcd.Name = "dfcdfcd";
            this.dfcdfcd.Size = new System.Drawing.Size(237, 30);
            this.dfcdfcd.TabIndex = 2;
            this.dfcdfcd.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNhap.Location = new System.Drawing.Point(496, 127);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(250, 29);
            this.txtNhap.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(361, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nhập thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(361, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Chọn danh mục";
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bntTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKiem.Image = global::BANHANG.Properties.Resources.Search_icon;
            this.bntTimKiem.Location = new System.Drawing.Point(762, 123);
            this.bntTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(36, 36);
            this.bntTimKiem.TabIndex = 12;
            this.bntTimKiem.UseVisualStyleBackColor = false;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Giá nhập",
            "Giá bán",
            "Mã nhà sản xuất"});
            this.comboBox1.Location = new System.Drawing.Point(496, 80);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 29);
            this.comboBox1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.imgSPDataGridViewImageColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.iDNSXDataGridViewTextBoxColumn,
            this.baoHanhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sanPhamBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(54, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 357);
            this.dataGridView1.TabIndex = 27;
            // 
            // iDSPDataGridViewTextBoxColumn
            // 
            this.iDSPDataGridViewTextBoxColumn.DataPropertyName = "ID_SP";
            this.iDSPDataGridViewTextBoxColumn.FillWeight = 50.58815F;
            this.iDSPDataGridViewTextBoxColumn.HeaderText = "ID_SP";
            this.iDSPDataGridViewTextBoxColumn.Name = "iDSPDataGridViewTextBoxColumn";
            this.iDSPDataGridViewTextBoxColumn.Width = 57;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.FillWeight = 175.1905F;
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.Width = 198;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.FillWeight = 88.11823F;
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.Width = 99;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.FillWeight = 84.49411F;
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.Width = 96;
            // 
            // imgSPDataGridViewImageColumn
            // 
            this.imgSPDataGridViewImageColumn.DataPropertyName = "ImgSP";
            this.imgSPDataGridViewImageColumn.FillWeight = 114.2132F;
            this.imgSPDataGridViewImageColumn.HeaderText = "ImgSP";
            this.imgSPDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imgSPDataGridViewImageColumn.Name = "imgSPDataGridViewImageColumn";
            this.imgSPDataGridViewImageColumn.Width = 129;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.FillWeight = 182.9329F;
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.Width = 206;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.FillWeight = 69.88919F;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 79;
            // 
            // iDNSXDataGridViewTextBoxColumn
            // 
            this.iDNSXDataGridViewTextBoxColumn.DataPropertyName = "ID_NSX";
            this.iDNSXDataGridViewTextBoxColumn.FillWeight = 67.88089F;
            this.iDNSXDataGridViewTextBoxColumn.HeaderText = "ID_NSX";
            this.iDNSXDataGridViewTextBoxColumn.Name = "iDNSXDataGridViewTextBoxColumn";
            this.iDNSXDataGridViewTextBoxColumn.Width = 77;
            // 
            // baoHanhDataGridViewTextBoxColumn
            // 
            this.baoHanhDataGridViewTextBoxColumn.DataPropertyName = "BaoHanh";
            this.baoHanhDataGridViewTextBoxColumn.FillWeight = 66.69286F;
            this.baoHanhDataGridViewTextBoxColumn.HeaderText = "BaoHanh";
            this.baoHanhDataGridViewTextBoxColumn.Name = "baoHanhDataGridViewTextBoxColumn";
            this.baoHanhDataGridViewTextBoxColumn.Width = 75;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bntDong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 591);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 118);
            this.panel3.TabIndex = 28;
            // 
            // bntDong
            // 
            this.bntDong.BackColor = System.Drawing.Color.Brown;
            this.bntDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDong.ForeColor = System.Drawing.Color.White;
            this.bntDong.Location = new System.Drawing.Point(565, 31);
            this.bntDong.Margin = new System.Windows.Forms.Padding(2);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(80, 38);
            this.bntDong.TabIndex = 13;
            this.bntDong.Text = "ĐÓNG";
            this.bntDong.UseVisualStyleBackColor = false;
            this.bntDong.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // frmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTimKiemSanPham";
            this.Text = "frmTimKiemSanPham";
            this.Load += new System.EventHandler(this.frmTimKiemSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bntDong;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dfcdfcd;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgSPDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baoHanhDataGridViewTextBoxColumn;
    }
}