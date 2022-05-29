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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                txtMaNCC.Text = "";
                txtTenNCC.Text = "";
                txtSDTNCC.Text = "";
                txtDiachi.Text = "";
                txtMaNCC.Focus();
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
                string sql_chen = "Insert into NhaCungCap Values('" + txtMaNCC.Text + "','" + txtTenNCC.Text + "','" + txtDiachi.Text + "','" + txtSDTNCC.Text + "')";
                SqlExecute.ExecuteCommand(sql_chen);
                Dulieu_DMNCC();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult TBsua;
            TBsua = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBsua == DialogResult.Yes)
            {
                string sql_sua = "Update NhaCungCap Set TenNCC = N'" + txtTenNCC.Text + "'";
                sql_sua = sql_sua + ",DiaChi = N'" + txtDiachi.Text + "',";
                sql_sua = sql_sua + "SDT = '" + txtSDTNCC.Text;
                sql_sua = sql_sua + "'where ID_NCC = '" + txtMaNCC.Text + "'";
                SqlExecute.ExecuteCommand(sql_sua);
                Dulieu_DMNCC();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult TBxoa;
            TBxoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBxoa == DialogResult.Yes)
            {
                SqlExecute.ExecuteCommand("Delete NhaCungCap where ID_NCC = '" + txtMaNCC.Text + "'");
                Dulieu_DMNCC();
            }
        }
        public void Dulieu_DMNCC()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("Select * From NhaCungCap");
            dataGridNCC.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dataGridNCC.DataSource, "ID_NCC");

            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", dataGridNCC.DataSource, "TenNCC");

            txtSDTNCC.DataBindings.Clear();
            txtSDTNCC.DataBindings.Add("Text", dataGridNCC.DataSource, "SDT");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dataGridNCC.DataSource, "DiaChi");
        }
        private void FrmDMNCC_Load(object sender, EventArgs e)
        {
            Dulieu_DMNCC();
        }
    }
}
