using System;
using System.Windows.Forms;
using System.Data;

namespace BANHANG
{
    public partial class frmDangNhap : Form
    {
        public static string id_tk = "",mk="";
        public static int quyentruycap;
               
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap1_Load(object sender, EventArgs e)
        {

        }
        
        public void getTK(string TK, string MK)
        {
           try
            {               
                DataTable dt = new DataTable();
                dt = SqlExecute.ExecuteDataTable("Select * from TaiKhoan where Email='" + TK + "'and MatKhau ='" + MK + "'");

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id_tk = dr["ID_TK"].ToString(); // col ID_TK

                        // Lấy Mật Khẩu, dùng do chức năng đổi mật khẩu
                         mk = dr["MatKhau"].ToString();
                        // mk = txtMK.Text;

                        // Lấy quyền truy cập
                        quyentruycap = (int)dr["QuyenTruyCap"]; ;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        { 
 
             if (txtTenDN.Text == string.Empty)
            {
                MessageBox.Show("Tài khoản không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDN.Focus();
                return;
            }

            if (txtMK.Text == string.Empty)
            {
                MessageBox.Show("Mật khẩu không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return;
            }

            getTK(txtTenDN.Text, txtMK.Text);

            try
            {
                if (id_tk != "")
                {
                    frmTrangChu m = new frmTrangChu();
                    m.mnuAdmin.Text = txtTenDN.Text;
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMK.Text = "";                  
                    txtTenDN.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
