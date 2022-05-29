using System;
using System.Drawing;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmDoiMatKhau : Form
    {

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            txtMKMoi.Enabled = false;
            txtNhapLaiMK.Enabled = false;
        }

        private void txtMKCu_TextChanged(object sender, EventArgs e)
        {
            if (txtMKCu.Text == "")
            {
                txtMKMoi.Enabled = false;
                txtNhapLaiMK.Enabled = false;
                txtMKMoi.Text = "";
                txtNhapLaiMK.Text = "";
                lblMatKhau.Text = "";
                btnOK.Enabled = false;
            }
            else
            {
                if (txtMKCu.Text != frmDangNhap.mk)
                {
                    erp.SetError(txtMKCu, "Mật khẩu vừa nhập không đúng!");
                    txtMKMoi.Enabled = false;
                    txtNhapLaiMK.Enabled = false;
                    txtMKMoi.Text = "";
                    txtNhapLaiMK.Text = "";
                    lblMatKhau.Text = "";
                    btnOK.Enabled = false;
                }
                else
                {
                    txtMKMoi.Enabled = true;
                    erp.Clear();
                    btnOK.Enabled = false;
                }

            }
        }
        private void btnOK_Click(object sender, EventArgs e)
            {
                if (txtNhapLaiMK.Text == "")
                {
                    MessageBox.Show("Bạn phải xác nhận mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMKMoi.Text = "";
                    txtNhapLaiMK.Text = "";
                    lblMatKhau.Text = "";
                    txtMKMoi.Focus();
                    txtNhapLaiMK.Enabled = false;
                    btnOK.Enabled = false;
                    return;
                }
                else
                {
                    try
                    {
                    string capNhatMK = "update TaiKhoan set MatKhau = '" + txtMKMoi.Text + "' where ID_TK ='" + frmDangNhap.id_tk + "'";
                    SqlExecute.ExecuteCommand(capNhatMK);

                        MessageBox.Show("Đổi mật khẩu thành công!", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     //   frmDangNhap1.mk = "";
    
                }
                    catch (Exception)
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        Close();
                    }
                }
            }

        public static int CheckMK(TextBox txt)
            {
                int check = 0;
                if (txt.Text.Length < 6)
                {
                    check = 1;
                }
                else
                {
                    char[] wl = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                    char[] wu = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                    char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    bool tmp = false, tmp1 = false, tmp2 = false, tmp3 = false, tmp4 = false, tmp5 = false, tmp6 = false, tmp7 = false;
                    for (int i = 0; i < txt.TextLength; ++i)
                    {
                        for (int j = 0; j < wl.Length; ++j)
                        {
                            if (txt.Text.ToCharArray()[i] == wl[j])
                            {
                                tmp = true;
                                tmp4 = true;
                                break;
                            }
                            else
                            {
                                tmp = false;
                            }
                        }
                        if (tmp == false)
                        {
                            tmp3 = true;
                            for (int k = 0; k < wu.Length; ++k)
                            {
                                if (txt.Text.ToCharArray()[i] == wu[k])
                                {
                                    tmp1 = true;
                                    tmp5 = true;
                                    break;
                                }
                                else
                                {
                                    tmp1 = false;
                                }
                            }
                            if (tmp1 == false)
                            {
                                for (int k = 0; k < numbers.Length; ++k)
                                {
                                    if (txt.Text.ToCharArray()[i] == numbers[k])
                                    {
                                        tmp2 = true;
                                        tmp6 = true;
                                        break;
                                    }
                                    else
                                    {
                                        tmp2 = false;
                                    }
                                }
                                if (tmp2 == false)
                                {
                                    tmp7 = true;
                                }
                            }
                        }

                    }
                    if ((tmp == true && tmp3 == false) || (tmp1 == true && tmp4 == false && tmp6 == false && tmp7 == false) || (tmp2 == true && tmp4 == false && tmp5 == false && tmp7 == false))
                    {
                        check = 2;
                    }
                    if ((tmp4 == true && tmp5 == true) || (tmp4 == true && tmp6 == true) || (tmp5 == true && tmp6 == true))
                    {
                        check = 3;
                    }
                    if ((tmp7 == true && tmp4 == true) || (tmp7 == true && tmp5 == true) || (tmp7 == true && tmp6 == true) || (tmp7 == true && tmp4 == true && tmp5 == true) || (tmp7 == true && tmp4 == true && tmp6 == true) || (tmp7 == true && tmp5 == true && tmp6 == true) || (tmp7 == true && tmp4 == true && tmp5 == true && tmp6 == true) || (tmp4 == true && tmp5 == true && tmp6 == true))
                    {
                        check = 4;
                    }
                }
                return check;
            }
        private void txtMKMoi_TextChanged(object sender, EventArgs e)
            {
                if (txtMKMoi.Text != "")
                {
                    if (CheckMK(txtMKMoi) == 1)
                    {
                        erp.SetError(txtMKMoi, "Mật khẩu phải chứa ít nhất 6 ký tự!");
                        txtNhapLaiMK.Text = "";
                        txtNhapLaiMK.Enabled = false;
                        lblMatKhau.Text = "";
                        btnOK.Enabled = false;
                    }
                    else
                    {
                        if (txtMKCu.Text != txtMKMoi.Text)
                        {
                            if (CheckMK(txtMKMoi) == 2)
                            {
                                erp.Clear();
                                lblMatKhau.Text = "Yếu!";
                                lblMatKhau.ForeColor = Color.Gray;
                                txtNhapLaiMK.Enabled = true;
                            }
                            else if (CheckMK(txtMKMoi) == 3)
                            {
                                erp.Clear();
                                lblMatKhau.Text = "Trung bình!";
                                lblMatKhau.ForeColor = Color.YellowGreen;
                                txtNhapLaiMK.Enabled = true;
                            }
                            else if (CheckMK(txtMKMoi) == 4)
                            {
                                erp.Clear();
                                lblMatKhau.Text = "Mạnh!";
                                lblMatKhau.ForeColor = Color.Green;
                                txtNhapLaiMK.Enabled = true;
                            }
                        }
                        else
                        {
                            erp.SetError(txtMKMoi, "Mật khẩu mới không được trùng với mật khẩu cũ!");
                            txtNhapLaiMK.Text = "";
                            txtNhapLaiMK.Enabled = false;
                            lblMatKhau.Text = "";
                            btnOK.Enabled = false;
                        }
                    }
                }
                else
                {
                    erp.SetError(txtMKMoi, "Mật khẩu mới không được để trống!");
                    lblMatKhau.Text = "";
                    txtNhapLaiMK.Enabled = false;
                    txtNhapLaiMK.Text = "";
                    btnOK.Enabled = false;
                }
            }

        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
            {
                if (txtNhapLaiMK.Text != "")
                {
                    if (txtMKMoi.Text != txtNhapLaiMK.Text)
                    {
                    erp.SetError(txtNhapLaiMK, "Mật khẩu không khớp!");
                    btnOK.Enabled = false;
                    }
                    else
                    {
                    btnOK.Enabled = true;
                    erp.Clear();
                }
                }
                else
                {
                    btnOK.Enabled = false;
                }
            }

        
    }
}
