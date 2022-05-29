using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmHoaDonNhapHang : Form
    {
        public frmHoaDonNhapHang()
        {
            InitializeComponent();

            txtID_HDN.Text = SqlExecute.CreateUniqueID("HDN", DateTime.Now);
            dgvHoaDonNhapHang.Rows.Add();

            cbbID_NV.DropDown += new EventHandler(new frmHoaDonBanHang().cbbID_NV_DropDown);
            cbbID_NCC.DropDown += new EventHandler(new frmHoaDonBanHang().cbbID_TT_DropDown);
            cbbID_TT.DropDown += new EventHandler(new frmHoaDonBanHang().cbbID_TT_DropDown);
            txtSoLuong.Leave += new EventHandler(new frmHoaDonBanHang().txtSoLuong_Leave);
        }

        private void frmHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtSoLuong.Enabled = false;

            txtID_HDN.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtGiaNhap.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            txtID_HDN.Text = SqlExecute.CreateUniqueID("HDN", dtpNgayNhap.Value);
        }        

        private void cbbID_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = SqlExecute.GetFieldValues("SELECT TenNhanVien FROM NhanVien WHERE ID_NV = '" + cbbID_NV.Text + "'");
        }

        private void cbbID_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNCC.Text = SqlExecute.GetFieldValues("SELECT TenNCC FROM NhaCungCap WHERE ID_NCC = '" + cbbID_NCC.Text + "'");
            txtDiaChi.Text = SqlExecute.GetFieldValues("SELECT DiaChi FROM NhaCungCap WHERE ID_NCC = '" + cbbID_NCC.Text + "'");
            txtSDT.Text = SqlExecute.GetFieldValues("SELECT SDT FROM NhaCungCap WHERE ID_NCC = '" + cbbID_NCC.Text + "'");
        }

        private void cbbID_SP_DropDown(object sender, EventArgs e)
        {
            cbbID_SP.DataSource = SqlExecute.ExecuteDataTable("SELECT ID_SP FROM SanPham");
            cbbID_SP.ValueMember = "ID_SP";
            cbbID_SP.SelectedIndex = -1;
            txtGiaNhap.Text = "";
        }

        private void cbbID_SP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbbID_SP.Text))
            {
                txtSoLuong.Enabled = false;
            }
            else
            {
                txtSoLuong.Enabled = true;
            }

            txtTenSP.Text = SqlExecute.GetFieldValues("SELECT TenSP FROM SanPham WHERE ID_SP = N'" + cbbID_SP.Text + "'");
            double db = Double.TryParse(SqlExecute.GetFieldValues(@"SELECT GiaNhap FROM SanPham WHERE ID_SP = N'" + cbbID_SP.Text + "'"), out db) ? db : 0;
            txtGiaNhap.Text = String.Format("{0:n}", db);
        }       

        private void txtGia_SoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Tính thành tiền
                double thanhTien = Convert.ToDouble(txtGiaNhap.Text) * Convert.ToInt16(txtSoLuong.Text);
                txtThanhTien.Text = String.Format("{0:n}", thanhTien);
            }
            catch (Exception ex)
            {
                txtThanhTien.Text = "0.00";
            }
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

            int lastRow = dgvHoaDonNhapHang.Rows.Count - 1;

            dgvHoaDonNhapHang.Rows[lastRow].Cells[0].Value = cbbID_SP.Text;
            dgvHoaDonNhapHang.Rows[lastRow].Cells[1].Value = txtSoLuong.Text;
            dgvHoaDonNhapHang.Rows[lastRow].Cells[2].Value = txtGiaNhap.Text;
            dgvHoaDonNhapHang.Rows[lastRow].Cells[3].Value = txtThanhTien.Text;

            dgvHoaDonNhapHang.Rows.Add();

            new frmHoaDonBanHang().calculateTongTien(txtTongTien, dgvHoaDonNhapHang);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHoaDonNhapHang.SelectedRows)
            {
                dgvHoaDonNhapHang.Rows.RemoveAt(row.Index);
            }

            new frmHoaDonBanHang().calculateTongTien(txtTongTien, dgvHoaDonNhapHang);
        }

        private void Reload()
        {
            dtpNgayNhap.Value = DateTime.Now;
            cbbID_NV.SelectedIndex = -1;
            cbbID_NCC.SelectedIndex = -1;
            cbbID_SP.SelectedIndex = -1;
            txtSoLuong.Text = "0";
            dgvHoaDonNhapHang.Rows.Clear();
            dgvHoaDonNhapHang.Rows.Add();
            dgvHoaDonNhapHang.Refresh();
            txtTongTien.Text = "0.00";
            cbbID_TT.SelectedIndex = -1;
            txtGhiChu.Text = "";
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Check mã hóa đơn
            if (!String.IsNullOrEmpty(SqlExecute.GetFieldValues("SELECT ID_HDN FROM HoaDonNhap WHERE ID_HDN = '" + txtID_HDN.Text + "'")))
            {
                MessageBox.Show("Hóa đơn " + txtID_HDN.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check thông tin nhân viên
            if (String.IsNullOrEmpty(cbbID_NV.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check thông tin khách hàng
            if (String.IsNullOrEmpty(cbbID_NCC.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Đồng ý lưu hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();

                //Hóa đơn
                try
                {
                    cmd.CommandText = @"INSERT INTO HoaDonNhap(ID_HDN, NgayNhap, TrangThai, TongTien, ID_NCC, ID_NV, GhiChu, ID_TT) 
                                            VALUES(@ID_HDN, @NgayNhap, @TrangThai, @TongTien, @ID_NCC, @ID_NV, @GhiChu, @ID_TT)";
                    cmd.Parameters.AddWithValue("@ID_HDN", txtID_HDN.Text);
                    cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value.Date);
                    cmd.Parameters.AddWithValue("@TrangThai", cbbID_TT.Text == "" || cbbID_TT.Text == "0" ? "Chưa thanh toán" : "Đã thanh toán");
                    cmd.Parameters.AddWithValue("@TongTien", Convert.ToDouble(txtTongTien.Text));
                    cmd.Parameters.AddWithValue("@ID_NCC", cbbID_NCC.Text);
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
                    for (int i = 0; i < dgvHoaDonNhapHang.Rows.Count - 1; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"INSERT INTO CT_HoaDonNhap(ID_CT_HDN, SoLuong, ThanhTien, ID_HDN, ID_SP) 
                                            VALUES(@ID_CT_HDN, @SoLuong, @ThanhTien, @ID_HDN, @ID_SP)";
                        cmd.Parameters.AddWithValue("@ID_CT_HDN", "No" + i + "." + txtID_HDN.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(dgvHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ThanhTien", Convert.ToDouble(dgvHoaDonNhapHang.Rows[i].Cells[3].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ID_SP", dgvHoaDonNhapHang.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@ID_HDN", txtID_HDN.Text);                        

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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
