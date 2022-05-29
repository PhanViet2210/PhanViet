using System;
using System.Data;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmTimKiemKhachHang : Form
    {
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblKH;
            sql = "SELECT ID_KH AS 'Mã khách hàng', TenKhachHang AS 'Tên khách hàng', SDT AS 'Số điện thoại', DiaChi AS 'Địa chỉ', Email FROM KhachHang ";
            tblKH = SqlExecute.ExecuteDataTable(sql);
            dataGridView1.DataSource = tblKH;
            dataGridView1.Columns[0].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            DataTable TKKH;
            string sql;
            if (radioButton1.Checked == true)
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT ID_KH AS 'Mã khách hàng', TenKhachHang AS 'Tên khách hàng', SDT AS 'Số điện thoại', DiaChi AS 'Địa chỉ', Email FROM KhachHang WHERE ID_KH = '" + txtNhap.Text + "'";
                    TKKH = SqlExecute.ExecuteDataTable(sql);
                    if (TKKH.Rows.Count == 0)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKKH;
                    }
                }
            }
            if (radioButton2.Checked == true)
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT ID_KH AS 'Mã khách hàng', TenKhachHang AS 'Tên khách hàng', SDT AS 'Số điện thoại', DiaChi AS 'Địa chỉ', Email FROM KhachHang WHERE TenKhachHang like N'%" + txtNhap.Text + "%'";
                    TKKH = SqlExecute.ExecuteDataTable(sql);
                    if (TKKH.Rows.Count == 0)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKKH;
                    }
                }
            }

            if (radioButton3.Checked == true)
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT ID_KH AS 'Mã khách hàng', TenKhachHang AS 'Tên khách hàng', SDT AS 'Số điện thoại', DiaChi AS 'Địa chỉ', Email FROM KhachHang WHERE SDT = '" + txtNhap.Text + "'";
                    TKKH = SqlExecute.ExecuteDataTable(sql);
                    if (TKKH.Rows.Count == 0)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKKH;
                    }
                }
            }
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn đóng không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
