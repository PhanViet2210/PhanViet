using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BANHANG
{
    public partial class FrmTaiKhoan : Form
    {
        public static string hoten, sdt, diachi;
        public FrmTaiKhoan()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void Load_DuLieu_TaiKhoan()
        {
            string sql = "select TenNhanVien, SDT, DiaChi,TaiKhoan.Email,LoaiTK from NhanVien,TaiKhoan where NhanVien.ID_TK = TaiKhoan.ID_TK and NhanVien.ID_TK = '" + frmDangNhap.id_tk + "'";
            DataTable dt;
            dt = SqlExecute.ExecuteDataTable(sql);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txtHoTen.Text = dr["TenNhanVien"].ToString().Trim();
                    txtSoDT.Text = dr["SDT"].ToString();
                    txtDiaChi.Text = dr["DiaChi"].ToString().Trim();
                    txtEmail.Text = dr["Email"].ToString().Trim();
                    txtVaiTro.Text = dr["LoaiTK"].ToString().Trim();

                    hoten = dr["TenNhanVien"].ToString().Trim();
                    sdt = dr["SDT"].ToString();
                    diachi = dr["DiaChi"].ToString().Trim();

                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản", "Thông báo !");
            }
        }
    
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (txtHoTen.Text != hoten || txtSoDT.Text != sdt || txtDiaChi.Text != diachi)
            {
                    string sql_sua = "update NhanVien set TenNhanVien =N'" + txtHoTen.Text + "' ";
                    sql_sua = sql_sua + ", SDT ='" + txtSoDT.Text + "'";
                    sql_sua = sql_sua + ", DiaChi =N'" + txtDiaChi.Text + "'" + " where ID_TK = '" + frmDangNhap.id_tk + "'";
                    SqlExecute.ExecuteCommand(sql_sua);
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo !");
                    Load_DuLieu_TaiKhoan();
            }
            else MessageBox.Show("Bạn chưa chỉnh sửa thông tin cần cập nhật !");
            
 
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            string no = txtSoDT.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                err.Clear();
                btnCapNhat.Enabled = true;
            }
            else
            {
                err.SetError(txtSoDT, "Bạn phải nhập đúng định dạng số điện thoại !");
                btnCapNhat.Enabled = false;
            }

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            
            Form f = new frmDoiMatKhau();
            f.Show();
            
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtVaiTro.Enabled = false;
            Load_DuLieu_TaiKhoan();
        }
    }
    
}
