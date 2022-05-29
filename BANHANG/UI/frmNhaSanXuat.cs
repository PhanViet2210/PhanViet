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
    public partial class frmNhaSanXuat : Form
    {
        public frmNhaSanXuat()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

                txtMaNSX.Text = "";
                txtTenNSX.Text = "";
                txtSDTNSX.Text = "";
                txtEmail.Text = "";
                txtMaNSX.Focus();
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
            TBchen = MessageBox.Show("Bạn có chắc chắn muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBchen == DialogResult.Yes)
            {
                string sql_chen = "Insert into NhaSanXuat Values('" + txtMaNSX.Text + "','" + txtTenNSX.Text + "','" + txtSDTNSX.Text + "','" + txtEmail.Text + "')";
                SqlExecute.ExecuteCommand(sql_chen);
                Dulieu_DMNSX();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult TBsua;
            TBsua = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBsua == DialogResult.Yes)
            {
                string sql_sua = "Update NhaSanXuat Set TenNSX = N'" + txtTenNSX.Text + "'";
                sql_sua = sql_sua + ",SDT = '" + txtSDTNSX.Text + "',";
                sql_sua = sql_sua + "Email = '" + txtEmail.Text;
                sql_sua = sql_sua + "'where ID_NSX = '" + txtMaNSX.Text + "'";
                SqlExecute.ExecuteCommand(sql_sua);
                Dulieu_DMNSX();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult TBxoa;
            TBxoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBxoa == DialogResult.Yes)
            {
                SqlExecute.ExecuteCommand("Delete NhaSanXuat where ID_NSX = '" + txtMaNSX.Text + "'");
                Dulieu_DMNSX();
            }
        }
        public void Dulieu_DMNSX()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("Select * From NhaSanXuat");
            dataGridNSX.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaNSX.DataBindings.Clear();
            txtMaNSX.DataBindings.Add("Text", dataGridNSX.DataSource, "ID_NSX");

            txtTenNSX.DataBindings.Clear();
            txtTenNSX.DataBindings.Add("Text", dataGridNSX.DataSource, "TenNSX");

            txtSDTNSX.DataBindings.Clear();
            txtSDTNSX.DataBindings.Add("Text", dataGridNSX.DataSource, "SDT");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridNSX.DataSource, "Email");
        }
        private void FrmDMNSX_Load(object sender, EventArgs e)
        {
            Dulieu_DMNSX();
        }
    }
}
