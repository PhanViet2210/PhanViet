using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BANHANG
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void Load_Dulieu_Vaitro()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("Select * From TaiKhoan");
            cboMaTK.DataSource = dta;
            cboMaTK.DisplayMember = "ID_TK";
            cboMaTK.ValueMember = "ID_TK";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                txtSDTNV.Text = "";
                txtDiachi.Text = "";
                txtEmail.Text = "";
                txtMaNV.Focus();
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
                string sql_chen = "Insert into NhanVien Values('" + txtMaNV.Text + "','" + txtTenNV.Text + "','" + txtSDTNV.Text + "','" + txtDiachi.Text + "','" + txtEmail.Text + "','" + cboMaTK.Text + "')";
                SqlExecute.ExecuteCommand(sql_chen);
                Dulieu_DMNV();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult TBsua;
            TBsua = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBsua == DialogResult.Yes)
            {
                string sql_sua = "Update NhanVien Set TenNhanVien = N'" + txtTenNV.Text + "'";
                sql_sua = sql_sua + ",SDT = '" + txtSDTNV.Text + "',";
                sql_sua = sql_sua + "DiaChi = N'" + txtDiachi.Text + "',";
                sql_sua = sql_sua + "Email = '" + txtEmail.Text + "',";
                sql_sua = sql_sua + "ID_TK = '" + cboMaTK.Text;
                sql_sua = sql_sua + "'where ID_NV = '" + txtMaNV.Text + "'";
                SqlExecute.ExecuteCommand(sql_sua);
                Dulieu_DMNV();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult TBxoa;
            TBxoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBxoa == DialogResult.Yes)
            {
                SqlExecute.ExecuteCommand("Delete NhanVien where ID_NV = '" + txtMaNV.Text + "'");
                Dulieu_DMNV();
            }
        }
        public void Dulieu_DMNV()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("Select * From NhanVien");
            dataGridNV.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dataGridNV.DataSource, "ID_NV");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dataGridNV.DataSource, "TenNhanVien");

            txtSDTNV.DataBindings.Clear();
            txtSDTNV.DataBindings.Add("Text", dataGridNV.DataSource, "SDT");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dataGridNV.DataSource, "DiaChi");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridNV.DataSource, "Email");

            cboMaTK.DataBindings.Clear();
            cboMaTK.DataBindings.Add("Text", dataGridNV.DataSource, "ID_TK");
        }
        private void FrmDMNV_Load(object sender, EventArgs e)
        {
            Load_Dulieu_Vaitro();
            Dulieu_DMNV();
        }
    }
}
