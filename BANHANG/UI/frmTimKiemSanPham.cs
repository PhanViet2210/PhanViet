using System;
using System.Data;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmTimKiemSanPham : Form
    {
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }
        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.dataSet.SanPham);
            Hienthi_Luoi();
        }
        private void Hienthi_Luoi()
        {
            /*string sql;
            DataTable tblSP;
            sql = "SELECT ID_SP AS 'Mã sản phẩm', TenSP AS 'Tên sản phẩm', GiaNhap AS 'Giá nhập', GiaBan AS 'Giá bán', MoTa AS 'Mô tả', SoLuong AS 'Số lượng', ID_NSX AS 'Mã nhà sản xuất', BaoHanh AS 'Bảo hành' FROM [dbo].[SanPham]";
            tblSP = SqlExecute.ExecuteDataTable(sql);
            dataGridView1.DataSource = tblSP; */

            string sql;
            DataTable tblSP;
            sql = "SELECT * FROM SanPham";
            tblSP = SqlExecute.ExecuteDataTable(sql);
            dataGridView1.DataSource = tblSP;
            dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Giá nhập";
            dataGridView1.Columns[3].HeaderText = "Giá bán";
            dataGridView1.Columns[4].HeaderText = "Hình ảnh";
            dataGridView1.Columns[5].HeaderText = "Mô tả";
            dataGridView1.Columns[6].HeaderText = "Số lượng";
            dataGridView1.Columns[7].HeaderText = "Mã nhà sản xuất";
            dataGridView1.Columns[8].HeaderText = "Bảo hành";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[8].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }


        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            DataTable TKSP;
            string sql;
            if (comboBox1.Text == "Mã sản phẩm")
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT * FROM [dbo].[SanPham] WHERE ID_SP = '" + txtNhap.Text + "'";
                    TKSP = SqlExecute.ExecuteDataTable(sql);
                    if (TKSP.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin sản phẩm!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKSP;
                    }
                }
            }

            if (comboBox1.Text == "Tên sản phẩm")
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT * FROM [dbo].[SanPham] WHERE TenSP like N'%" + txtNhap.Text + "%'";
                    TKSP = SqlExecute.ExecuteDataTable(sql);
                    if (TKSP.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin sản phẩm!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKSP;

                    }
                }
            }

            if (comboBox1.Text == "Giá nhập")
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT * FROM [dbo].[SanPham] WHERE GiaNhap = " + txtNhap.Text;
                    int num = -1;
                    if (!int.TryParse(txtNhap.Text, out num))
                    {
                        MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                    }
                    else
                    {
                        TKSP = SqlExecute.ExecuteDataTable(sql);
                        if (TKSP.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có thông tin sản phẩm!");
                        }
                        else
                        {
                            dataGridView1.DataSource = TKSP;
                        }
                    }

                }
            }

            if (comboBox1.Text == "Giá bán")
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT * FROM [dbo].[SanPham] WHERE GiaBan = " + txtNhap.Text;
                    int num = -1;
                    if (!int.TryParse(txtNhap.Text, out num))
                    {
                        MessageBox.Show("Ban da nhap sai. Moi nhap lai!");
                    }
                    else
                    {
                        TKSP = SqlExecute.ExecuteDataTable(sql);
                        if (TKSP.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có thông tin sản phẩm!");
                        }
                        else
                        {
                            dataGridView1.DataSource = TKSP;
                        }
                    }
                }
            }
            if (comboBox1.Text == "Mã nhà sản xuất")
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sql = "SELECT * FROM [dbo].[SanPham] WHERE ID_NSX = '" + txtNhap.Text + "'";
                    TKSP = SqlExecute.ExecuteDataTable(sql);
                    if (TKSP.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin sản phẩm!");
                    }
                    else
                    {
                        dataGridView1.DataSource = TKSP;
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
