using System;
using System.Data;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmTimKiemHoaDonBanHang : Form
    {
        public frmTimKiemHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void frmTimKiemHoaDonBanHang_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblHDBH;
            sql = "SELECT * FROM HoaDonBan";
            tblHDBH = SqlExecute.ExecuteDataTable(sql);
            dataGridView1.DataSource = tblHDBH;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Ngày bán";
            dataGridView1.Columns[2].HeaderText = "Trạng thái";
            dataGridView1.Columns[3].HeaderText = "Tổng tiền";
            dataGridView1.Columns[4].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[5].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void bntTimKiem_Click_1(object sender, EventArgs e)
        {
            DataTable TKHDBH = new DataTable();
            string sql;

            if (checkBox1.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "'";
                TKHDBH = SqlExecute.ExecuteDataTable(sql);
                if (TKHDBH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin hóa đơn!");
                }
                else
                {
                    dataGridView1.DataSource = TKHDBH;
                }

            }

            if (checkBox2.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_KH = '" + txtMaKH.Text + "'";
                TKHDBH = SqlExecute.ExecuteDataTable(sql);
                if (TKHDBH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin hóa đơn!");
                }
                else
                {
                    dataGridView1.DataSource = TKHDBH;
                }
            }

            if (checkBox3.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_NV = '" + txtMaNV.Text + "'";
                TKHDBH = SqlExecute.ExecuteDataTable(sql);
                if (TKHDBH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin hóa đơn!");
                }
                else
                {
                    dataGridView1.DataSource = TKHDBH;
                }
            }

            if (checkBox4.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE TongTien = " + txtTongTien.Text;
                int num1 = -1;
                if (!int.TryParse(txtTongTien.Text, out num1))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "' AND ID_KH = '" + txtMaKH.Text + "'";
                TKHDBH = SqlExecute.ExecuteDataTable(sql);
                if (TKHDBH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin hóa đơn!");
                }
                else
                {
                    dataGridView1.DataSource = TKHDBH;
                }
            }

            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "' AND ID_NV = '" + txtMaNV.Text + "'";
                TKHDBH = SqlExecute.ExecuteDataTable(sql);
                if (TKHDBH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin hóa đơn!");
                }
                else
                {
                    dataGridView1.DataSource = TKHDBH;
                }
            }

            if (checkBox1.Checked == true && checkBox4.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "' AND TongTien = " + txtTongTien.Text;
                int num2 = -1;
                if (!int.TryParse(txtTongTien.Text, out num2))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }

            if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_KH = '" + txtMaKH.Text + "' AND ID_NV = '" + txtMaNV.Text + "'";
                TKHDBH = SqlExecute.ExecuteDataTable(sql);
                if (TKHDBH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin hóa đơn!");
                }
                else
                {
                    dataGridView1.DataSource = TKHDBH;
                }
            }

            if (checkBox2.Checked == true && checkBox4.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_KH = '" + txtMaKH.Text + "' AND TongTien = " + txtTongTien.Text;
                int num3 = -1;
                if (!int.TryParse(txtTongTien.Text, out num3))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }

            if (checkBox3.Checked == true && checkBox4.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_NV = '" + txtMaNV.Text + "' AND TongTien = " + txtTongTien.Text;
                int num4 = -1;
                if (!int.TryParse(txtTongTien.Text, out num4))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "' AND ID_KH = '" + txtMaKH.Text + "' AND ID_NV = '" + txtMaNV.Text + "'";
                TKHDBH = SqlExecute.ExecuteDataTable(sql);
                if (TKHDBH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin hóa đơn!");
                }
                else
                {
                    dataGridView1.DataSource = TKHDBH;
                }
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox4.Checked == true)
            {

                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "' AND ID_KH = '" + txtMaKH.Text + "' AND TongTien = " + txtTongTien.Text;
                int num5 = -1;
                if (!int.TryParse(txtTongTien.Text, out num5))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }

            if (checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
            {

                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "' AND ID_NV = '" + txtMaNV.Text + "' AND TongTien = " + txtTongTien.Text;
                int num6 = -1;
                if (!int.TryParse(txtTongTien.Text, out num6))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }

            if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
            {

                sql = "SELECT * FROM HoaDonBan WHERE ID_KH = '" + txtMaKH.Text + "' AND ID_NV = '" + txtMaNV.Text + "' AND TongTien = " + txtTongTien.Text;
                int num7 = -1;
                if (!int.TryParse(txtTongTien.Text, out num7))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
            {
                sql = "SELECT * FROM HoaDonBan WHERE ID_HDB = '" + txtMaHD.Text + "' AND ID_KH = '" + txtMaKH.Text + "' AND ID_NV = '" + txtMaNV.Text + "' AND TongTien = " + txtTongTien.Text;
                int num8 = -1;
                if (!int.TryParse(txtTongTien.Text, out num8))
                {
                    MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                }
                else
                {
                    TKHDBH = SqlExecute.ExecuteDataTable(sql);
                    if (TKHDBH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin hóa đơn!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKHDBH;
                    }
                }
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
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
