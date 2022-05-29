using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        public void Dulieu_DMKH()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("Select * From KhachHang");
            dataGridKH.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dataGridKH.DataSource, "ID_KH");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dataGridKH.DataSource, "TenKhachHang");

            txtSDTKH.DataBindings.Clear();
            txtSDTKH.DataBindings.Add("Text", dataGridKH.DataSource, "SDT");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dataGridKH.DataSource, "DiaChi");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridKH.DataSource, "Email");
        }
        private void FrmDMKH_Load(object sender, EventArgs e)
        {
            Dulieu_DMKH();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {          
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtSDTKH.Text = "";
                txtDiachi.Text = "";
                txtEmail.Text = "";
                txtMaKH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult TBchen;
            TBchen = MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBchen == DialogResult.Yes)
            {
                string sql_chen = "Insert into KhachHang Values('" + txtMaKH.Text + "','" + txtTenKH.Text + "','" + txtSDTKH.Text + "','" + txtDiachi.Text + "','" + txtEmail.Text + "')";
                SqlExecute.ExecuteCommand(sql_chen);
                Dulieu_DMKH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult TBsua;
            TBsua = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBsua == DialogResult.Yes)
            {
                string sql_sua = "Update KhachHang Set TenKhachHang = N'" + txtTenKH.Text + "'";
                sql_sua = sql_sua + ",SDT = '" + txtSDTKH.Text + "',";
                sql_sua = sql_sua + "DiaChi = N'" + txtDiachi.Text + "',";
                sql_sua = sql_sua + "Email = '" + txtEmail.Text;
                sql_sua = sql_sua + "'where ID_KH = '" + txtMaKH.Text + "'";
                SqlExecute.ExecuteCommand(sql_sua);
                Dulieu_DMKH();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult TBxoa;
            TBxoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBxoa == DialogResult.Yes)
            {
                SqlExecute.ExecuteCommand("Delete KhachHang where ID_KH = '" + txtMaKH.Text + "'");
                Dulieu_DMKH();
            }
        }

        private void lblMaKH_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
