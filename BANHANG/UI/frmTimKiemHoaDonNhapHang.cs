using System;
using System.Data;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmTimKiemHoaDonNhapHang : Form
    {
        public frmTimKiemHoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void frmTimKiemHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblHDNH;
            sql = "SELECT ID_HDN AS 'Mã hóa đơn', NgayNhap AS 'Ngày nhập', ID_NV AS 'Mã nhân viên', TrangThai AS 'Trạng thái', TongTien AS 'Tổng tiền', ID_NCC AS 'Mã nhà cung cấp' FROM HoaDonNhap";
            tblHDNH = SqlExecute.ExecuteDataTable(sql);
            dataGridView1.DataSource = tblHDNH;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Ngày nhập";
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[3].HeaderText = "Trạng thái";
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.Columns[5].HeaderText = "Mã nhà cung cấp";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable TKHDNH;
            string nn;
            string sql = "SELECT ID_HDN AS 'Mã hóa đơn', NgayNhap AS 'Ngày nhập', ID_NV AS 'Mã nhân viên', TrangThai AS 'Trạng thái', TongTien AS 'Tổng tiền', ID_NCC AS 'Mã nhà cung cấp' FROM HoaDonNhap WHERE ";

            if (radioButton1.Checked == true)
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = sql + "ID_HDN = '" + txtNhap.Text + "'";
                    TKHDNH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDNH.Rows.Count == 0)
                    {
                        MessageBox.Show("Hóa đơn không tồn tại!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDNH;
                    }
                }
            }

            if (radioButton2.Checked == true)
            {
                nn = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                if (dateTimePicker1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateTimePicker1.Focus();
                    return;
                }
                else
                {
                    sql = sql + "NgayNhap = '" + nn + "'";
                    TKHDNH = SqlExecute.ExecuteDataTable(sql);
                    dataGridView1.DataSource = TKHDNH;
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
                    sql = sql + "TrangThai LIKE N'%" + txtNhap.Text + "%'";
                    TKHDNH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDNH.Rows.Count == 0)
                    {
                        MessageBox.Show("Hóa đơn không tồn tại!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDNH;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
