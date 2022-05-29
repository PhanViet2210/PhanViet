using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmHoaDonBanHang : Form
    {
        public frmHoaDonBanHang()
        {
            InitializeComponent();

            txtID_HDB.Text = SqlExecute.CreateUniqueID("HDB", DateTime.Now);
            dgvHoaDonBanHang.Rows.Add();            
        }
    
        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiamGia.Enabled = false;

            txtID_HDB.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtTenKhachHang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtGiaBan.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtCongTienHang.ReadOnly = true;
            txtVAT.ReadOnly = true;
            txtTongThanhToan.ReadOnly = true;
        }

        private void dtpNgayMua_ValueChanged(object sender, EventArgs e)
        {
            txtID_HDB.Text = SqlExecute.CreateUniqueID("HDB", dtpNgayMua.Value);
        }

        internal void cbbID_NV_DropDown(object sender, EventArgs e)
        {
            ComboBox cbb_ID_NV = sender as ComboBox;

            cbb_ID_NV.DataSource = SqlExecute.ExecuteDataTable("SELECT ID_NV FROM NhanVien");
            cbb_ID_NV.ValueMember = "ID_NV";
            cbb_ID_NV.SelectedIndex = -1;
        }

        private void cbbID_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = SqlExecute.GetFieldValues("SELECT TenNhanVien FROM NhanVien WHERE ID_NV = '" + cbbID_NV.Text + "'");
        }

        internal void cbbIDKH_IDNCC_DropDown(object sender, EventArgs e)
        {
            ComboBox cbb_ID_KH_NCC = sender as ComboBox;

            cbb_ID_KH_NCC.DataSource = SqlExecute.ExecuteDataTable("SELECT ID_KH FROM KhachHang");
            cbb_ID_KH_NCC.ValueMember = "ID_KH";
            cbb_ID_KH_NCC.SelectedIndex = -1;
        }

        private void cbbID_KH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenKhachHang.Text = SqlExecute.GetFieldValues("SELECT TenKhachHang FROM KhachHang WHERE ID_KH = '" + cbbID_KH.Text + "'");
            txtDiaChi.Text = SqlExecute.GetFieldValues("SELECT DiaChi FROM KhachHang WHERE ID_KH = '" + cbbID_KH.Text + "'");
            txtSDT.Text = SqlExecute.GetFieldValues("SELECT SDT FROM KhachHang WHERE ID_KH = '" + cbbID_KH.Text + "'");
        }

        private void cbbID_SP_DropDown(object sender, EventArgs e)
        {            
            cbbID_SP.DataSource = SqlExecute.ExecuteDataTable("SELECT ID_SP FROM SanPham");
            cbbID_SP.ValueMember = "ID_SP";
            cbbID_SP.SelectedIndex = -1;
            txtGiaBan.Text = "";
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
            double db = Double.TryParse(SqlExecute.GetFieldValues(@"SELECT GiaBan FROM SanPham WHERE ID_SP = N'" + cbbID_SP.Text + "'"), out db) ? db : 0;
            txtGiaBan.Text = String.Format("{0:n}", db);            
        }        

        internal void cbbID_TT_DropDown(object sender, EventArgs e)
        {
            ComboBox cbb_ID_TT = sender as ComboBox;

            cbb_ID_TT.DataSource = SqlExecute.ExecuteDataTable("SELECT ID_TT FROM ThanhToan");
            cbb_ID_TT.ValueMember = "ID_TT";
            cbb_ID_TT.Text = null;
        }

        internal void txtGiamGia_SoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        internal void txtSoLuong_Leave(object sender, EventArgs e)
        {
            TextBox txtSoLuong = sender as TextBox;

            if (String.IsNullOrEmpty(txtSoLuong.Text.Trim()))
            {
                txtSoLuong.Text = "0";
            }
            else
            {
                txtSoLuong.Text = Convert.ToInt32(txtSoLuong.Text).ToString();
            }
        }

        internal void txtGiamGia_Leave(object sender, EventArgs e)
        {
            TextBox txtGiamGia = sender as TextBox;

            if (String.IsNullOrEmpty(txtGiamGia.Text.Trim()))
            {
                txtGiamGia.Text = "0.00";
            }
            else
            {
                txtGiamGia.Text = String.Format("{0:n}", Convert.ToDouble(txtGiamGia.Text));
            }
        }

        private void txtGia_GiamGia_SoLuong_TextChanged(object sender, EventArgs e)
        {                        
            try
            {
                //Tính thành tiền
                double thanhTien = (Convert.ToDouble(txtGiaBan.Text) - Convert.ToDouble(txtGiaBan.Text) * Convert.ToDouble(txtGiamGia.Text) / 100) * Convert.ToInt16(txtSoLuong.Text);
                txtThanhTien.Text = String.Format("{0:n}", thanhTien);
            }
            catch (Exception ex)
            {
                txtThanhTien.Text = "0.00";
            }
        }

        //Tính tổng tiền
        internal void calculateTongTien(TextBox txtTongTien, DataGridView dgv)
        {
            double congTienHang = 0;

            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                congTienHang += Convert.ToDouble(dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value);
            }

            txtCongTienHang.Text = String.Format("{0:n}", congTienHang);
            txtVAT.Text = String.Format("{0:n}", congTienHang * 0.1);
            txtTongThanhToan.Text = String.Format("{0:n}", congTienHang - congTienHang * 0.1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            //Check thông tin sản phẩm
            if (String.IsNullOrEmpty(cbbID_SP.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbID_SP.Focus();
                return;
            }

            btnLuu.Enabled = true;

            int lastRow = dgvHoaDonBanHang.Rows.Count - 1;

            dgvHoaDonBanHang.Rows[lastRow].Cells[0].Value = cbbID_SP.Text;
            dgvHoaDonBanHang.Rows[lastRow].Cells[1].Value = txtSoLuong.Text;
            dgvHoaDonBanHang.Rows[lastRow].Cells[2].Value = txtGiaBan.Text;
            dgvHoaDonBanHang.Rows[lastRow].Cells[3].Value = txtGiamGia.Text;
            dgvHoaDonBanHang.Rows[lastRow].Cells[4].Value = txtThanhTien.Text;

            dgvHoaDonBanHang.Rows.Add();

            calculateTongTien(txtCongTienHang, dgvHoaDonBanHang);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHoaDonBanHang.SelectedRows)
            {
                dgvHoaDonBanHang.Rows.RemoveAt(row.Index);
            }
            
            calculateTongTien(txtCongTienHang, dgvHoaDonBanHang);
        }

        private void Reload()
        {
            dtpNgayMua.Value = DateTime.Now;
            cbbID_NV.SelectedIndex = -1;
            cbbID_KH.SelectedIndex = -1;
            cbbID_SP.SelectedIndex = -1;
            txtSoLuong.Text = "0";
            txtGiamGia.Text = "0.00";
            dgvHoaDonBanHang.Rows.Clear();
            dgvHoaDonBanHang.Rows.Add();
            dgvHoaDonBanHang.Refresh();
            txtCongTienHang.Text = "0.00";
            cbbID_TT.SelectedIndex = -1;
            txtGhiChu.Text = "";
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Check mã hóa đơn
            if (!String.IsNullOrEmpty(SqlExecute.GetFieldValues("SELECT ID_HDB FROM HoaDonBan WHERE ID_HDB = '" + txtID_HDB.Text + "'")))
            {
                MessageBox.Show("Hóa đơn " + txtID_HDB + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check thông tin nhân viên
            if (String.IsNullOrEmpty(cbbID_NV.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check thông tin khách hàng
            if (String.IsNullOrEmpty(cbbID_KH.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Đồng ý lưu hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();

                //Hóa đơn
                try
                {
                    cmd.CommandText = @"INSERT INTO HoaDonBan(ID_HDB, NgayBan, TrangThai, TongTien, ID_KH, ID_NV, GhiChu, ID_TT) 
                                            VALUES(@ID_HDB, @NgayBan, @TrangThai, @TongTien, @ID_KH, @ID_NV, @GhiChu, @ID_TT)";
                    cmd.Parameters.AddWithValue("@ID_HDB", txtID_HDB.Text);
                    cmd.Parameters.AddWithValue("@NgayBan", dtpNgayMua.Value.Date);
                    cmd.Parameters.AddWithValue("@TrangThai", cbbID_TT.Text == "" || cbbID_TT.Text == "0" ? "Chưa thanh toán" : "Đã thanh toán");
                    cmd.Parameters.AddWithValue("@TongTien", Convert.ToDouble(txtCongTienHang.Text));
                    cmd.Parameters.AddWithValue("@ID_KH", cbbID_KH.Text);
                    cmd.Parameters.AddWithValue("@ID_NV", cbbID_NV.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    cmd.Parameters.AddWithValue("@ID_TT", cbbID_TT.Text == "" ? "0" : cbbID_TT.Text);

                    SqlExecute.ExecuteCommand(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Chi tiết hóa đơn
                try
                {
                    for (int i = 0; i < dgvHoaDonBanHang.Rows.Count - 1; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"INSERT INTO CT_HoaDonBan(ID_CT_HDB, SoLuong, GiamGia, ThanhTien, ID_HDB, ID_SP, HanBaoHanh) 
                                            VALUES(@ID_CT_HDB, @SoLuong, @GiamGia, @ThanhTien, @ID_HDB, @ID_SP, @HanBaoHanh)";
                        cmd.Parameters.AddWithValue("@ID_CT_HDB", "No" + i + "." + txtID_HDB.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(dgvHoaDonBanHang.Rows[i].Cells[1].Value.ToString()));
                        cmd.Parameters.AddWithValue("@GiamGia", Convert.ToDouble(dgvHoaDonBanHang.Rows[i].Cells[3].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ThanhTien", Convert.ToDouble(dgvHoaDonBanHang.Rows[i].Cells[4].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ID_SP", dgvHoaDonBanHang.Rows[i].Cells[0].Value.ToString());

                        cmd.Parameters.AddWithValue("@ID_HDB", txtID_HDB.Text);

                        Int16 baoHanh = Convert.ToInt16(SqlExecute.GetFieldValues(@"SELECT BaoHanh FROM SanPham WHERE ID_SP = '" + dgvHoaDonBanHang.Rows[i].Cells[0].Value.ToString() + "'"));

                        cmd.Parameters.AddWithValue("@HanBaoHanh", dtpNgayMua.Value.AddMonths(baoHanh).ToShortDateString());

                        SqlExecute.ExecuteCommand(cmd);                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
