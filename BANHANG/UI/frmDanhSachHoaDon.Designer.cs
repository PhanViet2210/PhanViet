namespace BANHANG
{
    partial class frmDanhSachHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dfcdfcd = new System.Windows.Forms.Label();
            this.grbThanhToan = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtID_TT = new System.Windows.Forms.TextBox();
            this.txtLoaiThanhToan = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblLoaiThanhToan = new System.Windows.Forms.Label();
            this.lblID_TT = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cbbID_SP = new System.Windows.Forms.ComboBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.dgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbThanhToan.SuspendLayout();
            this.grbSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grbThanhToan);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.cbbDanhMuc);
            this.splitContainer1.Panel1.Controls.Add(this.lblDanhMuc);
            this.splitContainer1.Panel1.Controls.Add(this.grbSanPham);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnIn);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuayLai);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnDong);
            this.splitContainer1.Panel2.Controls.Add(this.btnChiTiet);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDanhSachHoaDon);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 709);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.dfcdfcd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 53);
            this.panel1.TabIndex = 9;
            // 
            // dfcdfcd
            // 
            this.dfcdfcd.AutoSize = true;
            this.dfcdfcd.BackColor = System.Drawing.Color.Transparent;
            this.dfcdfcd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.dfcdfcd.ForeColor = System.Drawing.Color.White;
            this.dfcdfcd.Location = new System.Drawing.Point(456, 12);
            this.dfcdfcd.Name = "dfcdfcd";
            this.dfcdfcd.Size = new System.Drawing.Size(253, 30);
            this.dfcdfcd.TabIndex = 2;
            this.dfcdfcd.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // grbThanhToan
            // 
            this.grbThanhToan.Controls.Add(this.txtGhiChu);
            this.grbThanhToan.Controls.Add(this.txtID_TT);
            this.grbThanhToan.Controls.Add(this.txtLoaiThanhToan);
            this.grbThanhToan.Controls.Add(this.lblGhiChu);
            this.grbThanhToan.Controls.Add(this.lblLoaiThanhToan);
            this.grbThanhToan.Controls.Add(this.lblID_TT);
            this.grbThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThanhToan.Location = new System.Drawing.Point(274, 135);
            this.grbThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.grbThanhToan.Name = "grbThanhToan";
            this.grbThanhToan.Padding = new System.Windows.Forms.Padding(2);
            this.grbThanhToan.Size = new System.Drawing.Size(599, 127);
            this.grbThanhToan.TabIndex = 5;
            this.grbThanhToan.TabStop = false;
            this.grbThanhToan.Text = "Thông tin thanh toán mới";
            this.grbThanhToan.Visible = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(138, 90);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(430, 25);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtID_TT
            // 
            this.txtID_TT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID_TT.Location = new System.Drawing.Point(138, 28);
            this.txtID_TT.Margin = new System.Windows.Forms.Padding(2);
            this.txtID_TT.Name = "txtID_TT";
            this.txtID_TT.ReadOnly = true;
            this.txtID_TT.Size = new System.Drawing.Size(430, 25);
            this.txtID_TT.TabIndex = 3;
            // 
            // txtLoaiThanhToan
            // 
            this.txtLoaiThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiThanhToan.Location = new System.Drawing.Point(138, 59);
            this.txtLoaiThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoaiThanhToan.Name = "txtLoaiThanhToan";
            this.txtLoaiThanhToan.Size = new System.Drawing.Size(430, 25);
            this.txtLoaiThanhToan.TabIndex = 3;
            this.txtLoaiThanhToan.Text = "Chưa thanh toán";
            this.txtLoaiThanhToan.Leave += new System.EventHandler(this.txtLoaiThanhToan_Leave);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiChu.Location = new System.Drawing.Point(26, 93);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 19);
            this.lblGhiChu.TabIndex = 4;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblLoaiThanhToan
            // 
            this.lblLoaiThanhToan.AutoSize = true;
            this.lblLoaiThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiThanhToan.Location = new System.Drawing.Point(25, 61);
            this.lblLoaiThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiThanhToan.Name = "lblLoaiThanhToan";
            this.lblLoaiThanhToan.Size = new System.Drawing.Size(106, 19);
            this.lblLoaiThanhToan.TabIndex = 2;
            this.lblLoaiThanhToan.Text = "Loại thanh toán";
            // 
            // lblID_TT
            // 
            this.lblID_TT.AutoSize = true;
            this.lblID_TT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID_TT.Location = new System.Drawing.Point(26, 32);
            this.lblID_TT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID_TT.Name = "lblID_TT";
            this.lblID_TT.Size = new System.Drawing.Size(101, 19);
            this.lblID_TT.TabIndex = 0;
            this.lblID_TT.Text = "Mã thanh toán";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(554, 276);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 38);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Items.AddRange(new object[] {
            "Hóa đơn bán hàng",
            "Hóa đơn nhập hàng",
            "Thanh toán"});
            this.cbbDanhMuc.Location = new System.Drawing.Point(412, 71);
            this.cbbDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(430, 29);
            this.cbbDanhMuc.TabIndex = 3;
            this.cbbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbbDanhMuc_SelectedIndexChanged);
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDanhMuc.Location = new System.Drawing.Point(315, 76);
            this.lblDanhMuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(81, 21);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục";
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.txtThanhTien);
            this.grbSanPham.Controls.Add(this.txtGiamGia);
            this.grbSanPham.Controls.Add(this.txtSoLuong);
            this.grbSanPham.Controls.Add(this.txtTenSP);
            this.grbSanPham.Controls.Add(this.cbbID_SP);
            this.grbSanPham.Controls.Add(this.lblGiaNhap);
            this.grbSanPham.Controls.Add(this.txtGiaNhap);
            this.grbSanPham.Controls.Add(this.lblGiamGia);
            this.grbSanPham.Controls.Add(this.label14);
            this.grbSanPham.Controls.Add(this.lbl_SoLuong);
            this.grbSanPham.Controls.Add(this.label10);
            this.grbSanPham.Controls.Add(this.label9);
            this.grbSanPham.Controls.Add(this.txtGiaBan);
            this.grbSanPham.Controls.Add(this.lblGiaBan);
            this.grbSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grbSanPham.Location = new System.Drawing.Point(274, 135);
            this.grbSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.grbSanPham.Size = new System.Drawing.Size(599, 106);
            this.grbSanPham.TabIndex = 4;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Thông tin Sản phẩm";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThanhTien.Location = new System.Drawing.Point(488, 58);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(92, 25);
            this.txtThanhTien.TabIndex = 6;
            this.txtThanhTien.Text = "0.00";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiamGia.Location = new System.Drawing.Point(488, 25);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(92, 25);
            this.txtGiamGia.TabIndex = 5;
            this.txtGiamGia.Text = "0.00";
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGia_GiamGia_SoLuong_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(286, 26);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(97, 25);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtGia_GiamGia_SoLuong_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenSP.Location = new System.Drawing.Point(119, 58);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(92, 25);
            this.txtTenSP.TabIndex = 2;
            // 
            // cbbID_SP
            // 
            this.cbbID_SP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbID_SP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbID_SP.FormattingEnabled = true;
            this.cbbID_SP.Location = new System.Drawing.Point(119, 26);
            this.cbbID_SP.Margin = new System.Windows.Forms.Padding(2);
            this.cbbID_SP.Name = "cbbID_SP";
            this.cbbID_SP.Size = new System.Drawing.Size(92, 25);
            this.cbbID_SP.TabIndex = 1;
            this.cbbID_SP.DropDown += new System.EventHandler(this.cbbID_SP_DropDown);
            this.cbbID_SP.SelectedIndexChanged += new System.EventHandler(this.cbbID_SP_SelectedIndexChanged);
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaNhap.Location = new System.Drawing.Point(221, 61);
            this.lblGiaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(64, 19);
            this.lblGiaNhap.TabIndex = 6;
            this.lblGiaNhap.Text = "Giá nhập";
            this.lblGiaNhap.Visible = false;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaNhap.Location = new System.Drawing.Point(286, 58);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(97, 25);
            this.txtGiaNhap.TabIndex = 7;
            this.txtGiaNhap.Visible = false;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiamGia.Location = new System.Drawing.Point(401, 28);
            this.lblGiamGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(78, 19);
            this.lblGiamGia.TabIndex = 4;
            this.lblGiamGia.Text = "Giảm giá %";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(401, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "Thành tiền";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_SoLuong.Location = new System.Drawing.Point(221, 28);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(63, 19);
            this.lbl_SoLuong.TabIndex = 2;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(22, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(24, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên sản phẩm";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaBan.Location = new System.Drawing.Point(286, 58);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(97, 25);
            this.txtGiaBan.TabIndex = 4;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGia_GiamGia_SoLuong_TextChanged);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaBan.Location = new System.Drawing.Point(221, 61);
            this.lblGiaBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(56, 19);
            this.lblGiaBan.TabIndex = 3;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(897, 165);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(88, 38);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "&IN HÓA ĐƠN";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(897, 228);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(80, 38);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(897, 105);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 38);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Brown;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(545, 297);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 38);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(897, 105);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(80, 38);
            this.btnChiTiet.TabIndex = 1;
            this.btnChiTiet.Text = "CHI TIẾT";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoaDon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(274, 12);
            this.dgvDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.RowHeadersWidth = 51;
            this.dgvDanhSachHoaDon.RowTemplate.Height = 24;
            this.dgvDanhSachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(599, 270);
            this.dgvDanhSachHoaDon.TabIndex = 0;
            this.dgvDanhSachHoaDon.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDanhSachHoaDon_CellBeginEdit);
            this.dgvDanhSachHoaDon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellEndEdit);
            // 
            // frmDanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhSachHoaDon";
            this.Text = "frmDanhSachHoaDon";
            this.Load += new System.EventHandler(this.frmDanhSachHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbThanhToan.ResumeLayout(false);
            this.grbThanhToan.PerformLayout();
            this.grbSanPham.ResumeLayout(false);
            this.grbSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cbbID_SP;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dfcdfcd;
        private System.Windows.Forms.GroupBox grbThanhToan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtID_TT;
        private System.Windows.Forms.TextBox txtLoaiThanhToan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblLoaiThanhToan;
        private System.Windows.Forms.Label lblID_TT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.Button btnIn;
    }
}