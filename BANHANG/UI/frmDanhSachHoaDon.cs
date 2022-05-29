using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmDanhSachHoaDon : Form
    {
        public static string ID_HD;

        public frmDanhSachHoaDon()
        {
            InitializeComponent();

            cbbDanhMuc.SelectedIndex = 0;

            grbSanPham.Visible = grbThanhToan.Visible = grbSanPham.Visible = btnThem.Visible = btnXoa.Visible = btnQuayLai.Visible = btnIn.Visible = false;

            txtGiamGia.KeyDown += new KeyEventHandler(new frmHoaDonBanHang().txtGiamGia_SoLuong_KeyDown);
            txtSoLuong.KeyDown += new KeyEventHandler(new frmHoaDonBanHang().txtGiamGia_SoLuong_KeyDown);
            txtSoLuong.Leave += new EventHandler(new frmHoaDonBanHang().txtSoLuong_Leave);
            txtGiamGia.Leave += new EventHandler(new frmHoaDonBanHang().txtGiamGia_Leave);            
        }

        private void display()
        {
            if (cbbDanhMuc.SelectedIndex == 0)
            {
                
                btnChiTiet.Visible = true;
                grbThanhToan.Visible = false;
                btnThem.Visible = false;
                dgvDanhSachHoaDon.DataSource = SqlExecute.ExecuteDataTable(@"SELECT
                                                                                ID_HDB AS [Mã hóa đơn],
                                                                                NgayBan AS [Ngày bán],
                                                                                TrangThai AS [Trạng thái],
                                                                                TongTien AS [Tổng thanh toán],
                                                                                ID_KH AS [Mã khách hàng],
                                                                                ID_NV AS [Mã nhân viên],
                                                                                ID_TT AS [Mã thanh toán],
                                                                                GhiChu AS [Ghi chú]
                                                                                    FROM HoaDonBan");
                dgvDanhSachHoaDon.Columns["Mã hóa đơn"].DisplayIndex = 0;
                dgvDanhSachHoaDon.Columns["Ngày bán"].DisplayIndex = 1;
                dgvDanhSachHoaDon.Columns["Trạng thái"].DisplayIndex = 2;
                dgvDanhSachHoaDon.Columns["Tổng thanh toán"].DisplayIndex = 3;
                dgvDanhSachHoaDon.Columns["Mã khách hàng"].DisplayIndex = 4;
                dgvDanhSachHoaDon.Columns["Mã nhân viên"].DisplayIndex = 5;
                dgvDanhSachHoaDon.Columns["Mã thanh toán"].DisplayIndex = 6;
                dgvDanhSachHoaDon.Columns["Ghi chú"].DisplayIndex = 7;
            }
            else if (cbbDanhMuc.SelectedIndex == 1)
            {
                btnChiTiet.Visible = true;
                grbThanhToan.Visible = false;
                btnThem.Visible = false;
                dgvDanhSachHoaDon.DataSource = SqlExecute.ExecuteDataTable(@"SELECT
                                                                                ID_HDN AS [Mã hóa đơn],
                                                                                NgayNhap AS [Ngày nhập],
                                                                                TrangThai AS [Trạng thái],
                                                                                TongTien AS [Tổng tiền],
                                                                                ID_NCC AS [Mã nhà cung cấp],
                                                                                ID_NV AS [Mã nhân viên],
                                                                                ID_TT AS [Mã thanh toán],
                                                                                GhiChu AS [Ghi chú]
                                                                                    FROM HoaDonNhap");
                dgvDanhSachHoaDon.Columns["Mã hóa đơn"].DisplayIndex = 0;
                dgvDanhSachHoaDon.Columns["Ngày nhập"].DisplayIndex = 1;
                dgvDanhSachHoaDon.Columns["Trạng thái"].DisplayIndex = 2;
                dgvDanhSachHoaDon.Columns["Tổng tiền"].DisplayIndex = 3;
                dgvDanhSachHoaDon.Columns["Mã nhà cung cấp"].DisplayIndex = 4;
                dgvDanhSachHoaDon.Columns["Mã nhân viên"].DisplayIndex = 5;
                dgvDanhSachHoaDon.Columns["Mã thanh toán"].DisplayIndex = 6;
                dgvDanhSachHoaDon.Columns["Ghi chú"].DisplayIndex = 7;
            }
            else
            {
                btnChiTiet.Visible = false;
                grbSanPham.Visible = false;
                txtID_TT.Text = SqlExecute.CreateUniqueID("TT", DateTime.Now);
                grbThanhToan.Visible = true;                
                btnThem.Visible = true;
                dgvDanhSachHoaDon.DataSource = SqlExecute.ExecuteDataTable(@"SELECT
                                                                                ID_TT AS [Mã thanh toán],
                                                                                LoaiThanhToan AS [Loại thanh toán],
                                                                                GhiChu AS [Ghi chú]
                                                                                    FROM ThanhToan");
                dgvDanhSachHoaDon.Columns["Mã thanh toán"].DisplayIndex = 0;
                dgvDanhSachHoaDon.Columns["Loại thanh toán"].DisplayIndex = 1;
                dgvDanhSachHoaDon.Columns["Ghi chú"].DisplayIndex = 2;
            }

            //Chỉ cho phép thay đổi cột Mã thanh toán
            for (int i = 0; i < dgvDanhSachHoaDon.Columns.Count; i++)
            {
                if (i == 6)
                {
                    dgvDanhSachHoaDon.Columns[i].ReadOnly = false;
                }
                else
                {
                    dgvDanhSachHoaDon.Columns[i].ReadOnly = true;
                }
            }
        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            grbThanhToan.Visible = false;
            cbbDanhMuc.Focus();

            if (cbbDanhMuc.SelectedIndex == 0)
            {
                if (dgvDanhSachHoaDon.SelectedRows.Count == 1)
                {
                    lblGiamGia.Visible = txtGiamGia.Visible = lblGiaBan.Visible = txtGiaBan.Visible = true;
                    grbThanhToan.Visible = lblGiaNhap.Visible = txtGiaNhap.Visible = false;

                    ID_HD = dgvDanhSachHoaDon.SelectedRows[0].Cells[0].Value.ToString();

                    displayCTB();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 hóa đơn!.");
                    return;
                }
            }
            else if (cbbDanhMuc.SelectedIndex == 1)
            {
                if (dgvDanhSachHoaDon.SelectedRows.Count == 1)
                {
                    grbThanhToan.Visible = lblGiamGia.Visible = txtGiamGia.Visible = lblGiaBan.Visible = txtGiaBan.Visible = false;
                    lblGiaNhap.Visible = txtGiaNhap.Visible = true;

                    ID_HD = dgvDanhSachHoaDon.SelectedRows[0].Cells[0].Value.ToString();

                    displayCTN();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 hóa đơn!.");
                    return;
                }
            }

            btnIn.Visible = true;
            cbbDanhMuc.Enabled = false;
            btnChiTiet.Visible = false;
            btnThem.Visible = btnXoa.Visible = btnQuayLai.Visible = true;
            grbSanPham.Visible = true;
        }

        private void displayCTB()
        {
            DataGridViewRow r = dgvDanhSachHoaDon.SelectedRows[0];

            dgvDanhSachHoaDon.DataSource = SqlExecute.ExecuteDataTable(@"SELECT
                                                                            ID_CT_HDB AS [ID],
                                                                            ID_SP AS [Mã sản phẩm],
                                                                            SoLuong AS [Số lượng],
                                                                            GiamGia AS [Giảm giá (%)],
                                                                            ThanhTien AS [Thành tiền],
                                                                            HanBaoHanh AS [Hạn bảo hành]
                                                                                FROM CT_HoaDonBan
                                                                                WHERE ID_HDB = '" + r.Cells[0].Value.ToString() + "'");            
        }

        private void displayCTN()
        {
            DataGridViewRow r = dgvDanhSachHoaDon.SelectedRows[0];

            dgvDanhSachHoaDon.DataSource = SqlExecute.ExecuteDataTable(@"SELECT
                                                                            ID_CT_HDN AS [ID],
                                                                            ID_SP AS [Mã sản phẩm],
                                                                            SoLuong AS [Số lượng],
                                                                            ThanhTien AS [Thành tiền]
                                                                                FROM CT_HoaDonNhap
                                                                                WHERE ID_HDN = '" + r.Cells[0].Value.ToString() + "'");
        }

        private void cbbID_SP_DropDown(object sender, EventArgs e)
        {
            cbbID_SP.DataSource = SqlExecute.ExecuteDataTable("SELECT ID_SP FROM SanPham");
            cbbID_SP.ValueMember = "ID_SP";
            cbbID_SP.SelectedIndex = -1;
            txtGiaBan.Text = txtGiaNhap.Text = "";
        }

        private void cbbID_SP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbbID_SP.Text))
            {
                txtSoLuong.Enabled = txtGiamGia.Enabled = false;
            }
            else
            {
                txtSoLuong.Enabled = txtGiamGia.Enabled = true;
            }

            txtTenSP.Text = SqlExecute.GetFieldValues("SELECT TenSP FROM SanPham WHERE ID_SP = N'" + cbbID_SP.Text + "'");

            if (cbbDanhMuc.SelectedIndex == 0)
            {
                double dbb = Double.TryParse(SqlExecute.GetFieldValues(@"SELECT GiaBan FROM SanPham WHERE ID_SP = N'" + cbbID_SP.Text + "'"), out dbb) ? dbb : 0;
                txtGiaBan.Text = String.Format("{0:n}", dbb);
            }
            else
            {
                double dbn = Double.TryParse(SqlExecute.GetFieldValues(@"SELECT GiaNhap FROM SanPham WHERE ID_SP = N'" + cbbID_SP.Text + "'"), out dbn) ? dbn : 0;
                txtGiaNhap.Text = String.Format("{0:n}", dbn);
            }                       
        }

        private void txtGia_GiamGia_SoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbDanhMuc.SelectedIndex == 0)
                {
                    //Tính thành tiền
                    double thanhTien = (Convert.ToDouble(txtGiaBan.Text) - Convert.ToDouble(txtGiaBan.Text) * Convert.ToDouble(txtGiamGia.Text) / 100) * Convert.ToInt16(txtSoLuong.Text);
                    txtThanhTien.Text = String.Format("{0:n}", thanhTien);
                }
                else
                {
                    //Tính thành tiền
                    double thanhTien = Convert.ToDouble(txtGiaNhap.Text) * Convert.ToInt16(txtSoLuong.Text);
                    txtThanhTien.Text = String.Format("{0:n}", thanhTien);
                }
            }
            catch (Exception ex)
            {
                txtThanhTien.Text = "0.00";
            }
        }

        private void updateTongTien()
        {
            double congTienHang = 0.0, VAT = 0.1, tongThanhToan = 0.0;
            for (int i = 0; i < dgvDanhSachHoaDon.Rows.Count - 1; i++)
            {
                congTienHang += Convert.ToDouble(dgvDanhSachHoaDon.Rows[i].Cells[cbbDanhMuc.SelectedIndex == 0 ? 4 : 3].Value.ToString());                
            }

            tongThanhToan = congTienHang * VAT;

            if (cbbDanhMuc.SelectedIndex == 0)
            {
                SqlExecute.ExecuteCommand(@"UPDATE HoaDonBan SET TongTien = " + tongThanhToan + " WHERE ID_HDB = '" + ID_HD + "'");
            }
            else if (cbbDanhMuc.SelectedIndex == 1)
            {
                SqlExecute.ExecuteCommand(@"UPDATE HoaDonNhap SET TongTien = " + congTienHang + " WHERE ID_HDN = '" + ID_HD + "'");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbDanhMuc.SelectedIndex != 2)
            {
                //Check thông tin sản phẩm
                if (String.IsNullOrEmpty(cbbID_SP.Text))
                {
                    MessageBox.Show("Vui lòng nhập thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbID_SP.Focus();
                    return;
                }

                if (cbbDanhMuc.SelectedIndex == 0)
                {
                    addValueDgvB();
                }
                else if (cbbDanhMuc.SelectedIndex == 1)
                {
                    addValueDgvN();
                }
            }
            else
            {
                //Insert into ThanhToan
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO ThanhToan(ID_TT, LoaiThanhToan, GhiChu)
                                                VALUES(@ID_TT, @LoaiThanhToan, @GhiChu)";
                cmd.Parameters.AddWithValue("@ID_TT", txtID_TT.Text);
                cmd.Parameters.AddWithValue("@LoaiThanhToan", txtLoaiThanhToan.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                SqlExecute.ExecuteCommand(cmd);

                //Insert into DataGridView
                int lastRow = dgvDanhSachHoaDon.Rows.Count - 1;

                dgvDanhSachHoaDon.Rows[lastRow].Cells[0].Value = cmd.Parameters["@ID_TT"].Value;
                dgvDanhSachHoaDon.Rows[lastRow].Cells[1].Value = cmd.Parameters["@LoaiThanhToan"].Value;
                dgvDanhSachHoaDon.Rows[lastRow].Cells[2].Value = cmd.Parameters["@GhiChu"].Value;

                addNewRow();
            }
        }

        private void addValueDgvB()
        {
            //Thêm vào chi tiết hóa đơn
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO CT_HoaDonBan(ID_CT_HDB, SoLuong, GiamGia, ThanhTien, ID_HDB, ID_SP, HanBaoHanh)
                                            VALUES(@ID_CT_HDB, @SoLuong, @GiamGia, @ThanhTien, @ID_HDB, @ID_SP, @HanBaoHanh)";
            cmd.Parameters.AddWithValue("@ID_CT_HDB", "No" + (dgvDanhSachHoaDon.Rows.Count - 1) + ID_HD);
            cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSoLuong.Text));
            cmd.Parameters.AddWithValue("@GiamGia", Convert.ToDouble(txtGiamGia.Text));
            cmd.Parameters.AddWithValue("@ThanhTien", Convert.ToDouble(txtThanhTien.Text));
            cmd.Parameters.AddWithValue("@ID_HDB", ID_HD);
            cmd.Parameters.AddWithValue("@ID_SP", cbbID_SP.Text);

            Int16 baoHanh = Convert.ToInt16(SqlExecute.GetFieldValues(@"SELECT BaoHanh FROM SanPham WHERE ID_SP = '" + cbbID_SP.Text + "'"));
            string NgayBan = SqlExecute.GetFieldValues(@"SELECT NgayBan FROM HoaDonBan WHERE ID_HDB = '" + ID_HD + "'");
            cmd.Parameters.AddWithValue("@HanBaoHanh", DateTime.Parse(NgayBan).AddMonths(baoHanh).ToShortDateString());

            SqlExecute.ExecuteCommand(cmd);

            //Thêm sản phẩm vào DataGridView
            int lastRow = dgvDanhSachHoaDon.Rows.Count - 1;
            
            dgvDanhSachHoaDon.Rows[lastRow].Cells[0].Value = cmd.Parameters["@ID_CT_HDB"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[1].Value = cmd.Parameters["@ID_SP"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[2].Value = cmd.Parameters["@SoLuong"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[3].Value = cmd.Parameters["@GiamGia"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[4].Value = cmd.Parameters["@ThanhTien"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[5].Value = cmd.Parameters["@HanBaoHanh"].Value;

            //Update Tổng Tiền ở hóa đơn
            updateTongTien();

            addNewRow();
        }

        private void addNewRow()
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dgvDanhSachHoaDon.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in dgvDanhSachHoaDon.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            dgvDanhSachHoaDon.DataSource = dt;
        }

        private void addValueDgvN()
        {
            //Thêm vào chi tiết hóa đơn
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO CT_HoaDonNhap(ID_CT_HDN, SoLuong, ThanhTien, ID_HDN, ID_SP)
                                            VALUES(@ID_CT_HDN, @SoLuong, @ThanhTien, @ID_HDN, @ID_SP)";
            cmd.Parameters.AddWithValue("@ID_CT_HDN", "No" + (dgvDanhSachHoaDon.Rows.Count - 1) + ID_HD);
            cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSoLuong.Text));
            cmd.Parameters.AddWithValue("@ThanhTien", Convert.ToDouble(txtThanhTien.Text));
            cmd.Parameters.AddWithValue("@ID_HDN", ID_HD);
            cmd.Parameters.AddWithValue("@ID_SP", cbbID_SP.Text);

            SqlExecute.ExecuteCommand(cmd);

            //Thêm sản phẩm vào DataGridView
            int lastRow = dgvDanhSachHoaDon.Rows.Count - 1;

            dgvDanhSachHoaDon.Rows[lastRow].Cells[0].Value = cmd.Parameters["@ID_CT_HDN"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[1].Value = cmd.Parameters["@ID_SP"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[2].Value = cmd.Parameters["@SoLuong"].Value;
            dgvDanhSachHoaDon.Rows[lastRow].Cells[3].Value = cmd.Parameters["@ThanhTien"].Value;

            //Update Tổng Tiền ở hóa đơn
            updateTongTien();

            addNewRow();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachHoaDon.SelectedRows)
            {
                //Xóa ở chi tiết hóa đơn
                if (cbbDanhMuc.SelectedIndex == 0)
                {
                    SqlExecute.ExecuteCommand(@"DELETE FROM CT_HoaDonBan WHERE ID_CT_HDB = '" + row.Cells[0].Value.ToString() + "'");
                }
                else
                {
                    SqlExecute.ExecuteCommand(@"DELETE FROM CT_HoaDonNhap WHERE ID_CT_HDN = '" + row.Cells[0].Value.ToString() + "'");
                }

                //Xóa ở DataGridView
                dgvDanhSachHoaDon.Rows.RemoveAt(row.Index);                
            }

            updateTongTien();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {            
            cbbDanhMuc.Enabled = true;
            cbbDanhMuc.Focus();
            display();

            grbSanPham.Visible = btnThem.Visible = btnXoa.Visible = btnQuayLai.Visible = btnIn.Visible = false;
            btnChiTiet.Visible = true;

            reloadGrbSanPham();
        }

        private void reloadGrbSanPham()
        {
            cbbID_SP.SelectedIndex = -1;
            txtSoLuong.Text = "0";
        }              

        private string oldValue, newValue;

        private void dgvDanhSachHoaDon_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = dgvDanhSachHoaDon[e.ColumnIndex, e.RowIndex].Value.ToString();
        }        

        private void dgvDanhSachHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            newValue = dgvDanhSachHoaDon[e.ColumnIndex, e.RowIndex].Value.ToString();

            if (String.IsNullOrEmpty(SqlExecute.GetFieldValues(@"SELECT ID_TT FROM ThanhToan WHERE ID_TT = '" + newValue + "'")))
            {
                MessageBox.Show("Mã thanh toán không tồn tại!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvDanhSachHoaDon[e.ColumnIndex, e.RowIndex].Value = oldValue;
                return;
            }
            else
            {
                //Update trạng thái đơn hàng                
                if (newValue != "0")
                {
                    dgvDanhSachHoaDon[2, e.RowIndex].Value = "Đã thanh toán";
                }
                else
                {
                    dgvDanhSachHoaDon[2, e.RowIndex].Value = "Chưa thanh toán";
                }

                if (cbbDanhMuc.SelectedIndex == 0)
                {
                    SqlExecute.ExecuteCommand(@"UPDATE HoaDonBan SET ID_TT = '" + newValue + "' WHERE ID_HDB = '" + dgvDanhSachHoaDon[0, e.RowIndex].Value.ToString() + "'");
                    SqlExecute.ExecuteCommand(@"UPDATE HoaDonBan SET TrangThai = N'" + dgvDanhSachHoaDon[2, e.RowIndex].Value.ToString() + "' WHERE ID_HDB = '" + dgvDanhSachHoaDon[0, e.RowIndex].Value.ToString() + "'");
                }
                else if (cbbDanhMuc.SelectedIndex == 1)
                {
                    SqlExecute.ExecuteCommand(@"UPDATE HoaDonNhap SET ID_TT = '" + newValue + "' WHERE ID_HDN = '" + dgvDanhSachHoaDon[0, e.RowIndex].Value.ToString() + "'");
                    SqlExecute.ExecuteCommand(@"UPDATE HoaDonNhap SET TrangThai = N'" + dgvDanhSachHoaDon[2, e.RowIndex].Value.ToString() + "' WHERE ID_HDN = '" + dgvDanhSachHoaDon[0, e.RowIndex].Value.ToString() + "'");
                }

            }
        }

        private void txtLoaiThanhToan_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLoaiThanhToan.Text))
            {
                txtLoaiThanhToan.Text = "Chưa thanh toán";
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmBaoCaoTonKho.HDBH = true;
            frmBaoCaoTonKho f = new frmBaoCaoTonKho();
            f.Show();
        }

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
