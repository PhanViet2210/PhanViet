using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BANHANG
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        bool IsEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }


        private void Hienthi_Dulieu1()
        {
            txtIDTaiKhoan.DataBindings.Clear();
            txtIDTaiKhoan.DataBindings.Add("Text", dataGrid.DataSource, "ID_TK");

            txtLoaiTK.DataBindings.Clear();
            txtLoaiTK.DataBindings.Add("Text", dataGrid.DataSource, "LoaiTK");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGrid.DataSource, "Email");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dataGrid.DataSource, "MatKhau");

            cboQuyenTruyCap.DataBindings.Clear();
            cboQuyenTruyCap.DataBindings.Add("Text", dataGrid.DataSource, "QuyenTruyCap");


        }
        public void Load_Dulieu_TaiKhoan()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("select * from TaiKhoan");
            dataGrid.DataSource = dta;
            
            Hienthi_Dulieu1();
        }
        public void Load_Dulieu_QuyenTruyCap()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("select * from TaiKhoan");
            cboQuyenTruyCap.DataSource = dta;
            cboQuyenTruyCap.DisplayMember = "QuyenTruyCap";
            cboQuyenTruyCap.ValueMember = "QuyenTruyCap";
        }
        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_Dulieu_TaiKhoan();
            Load_Dulieu_QuyenTruyCap();
            Hienthi_Dulieu1();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtIDTaiKhoan.Text = "";
            txtLoaiTK.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
        //    cboQuyenTruyCap.Text = "";
            txtIDTaiKhoan.Focus();
        }
        private void btnChen_Click(object sender, EventArgs e)
        {
            if (txtIDTaiKhoan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ID tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDTaiKhoan.Focus();
                return;
            }
            if (txtLoaiTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoaiTK.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
          
            
            DataTable dt = new DataTable();
            dt = SqlExecute.ExecuteDataTable("Select * from TaiKhoan where ID_TK = "+txtIDTaiKhoan.Text+"");
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("ID tài khoản này đã tồn tại, hãy nhập ID tài khoản mới !");
                txtIDTaiKhoan.Focus();
            }
            else
            {
                if (IsEmail(txtEmail.ToString()) == true)
                {
                    DialogResult TBchen;
                    TBchen = MessageBox.Show("Bạn có chắc chắn muốn thêm tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (TBchen == DialogResult.Yes)
                    {
                        string sql_chen = "Insert into TaiKhoan values('" + txtIDTaiKhoan.Text + "' ,'" + txtLoaiTK.Text + "','" + txtEmail.Text + "' ,'" + txtMatKhau.Text + "','" + cboQuyenTruyCap.Text + "')";
                        SqlExecute.ExecuteCommand(sql_chen);
                        Load_Dulieu_TaiKhoan();
                    }
                }
                else MessageBox.Show("Bạn đã nhập sai định dạng Email");
            }
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (IsEmail(txtEmail.ToString()) == true)
            {
                DialogResult TBsua;
                TBsua = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (TBsua == DialogResult.Yes)
                {
                    string sql_sua = "update TaiKhoan set LoaiTK ='" + txtLoaiTK.Text + "' ";
                    sql_sua = sql_sua + ", Email ='" + txtEmail.Text + "'";
                    sql_sua = sql_sua + ", MatKhau ='" + txtMatKhau.Text + "'" + ", QuyenTruyCap ='" + cboQuyenTruyCap.Text + "' where ID_TK = '" + txtIDTaiKhoan.Text + "' ";
                    SqlExecute.ExecuteCommand(sql_sua);
                    Load_Dulieu_TaiKhoan();
                }
            }
            else MessageBox.Show("Bạn đã nhập sai định dạng Email");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult TBxoa;
            TBxoa = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBxoa == DialogResult.Yes)
            {
                SqlExecute.ExecuteCommand("Delete TaiKhoan where ID_TK = '" + txtIDTaiKhoan.Text + "'");
                Load_Dulieu_TaiKhoan();
            }
        }

    }
}
