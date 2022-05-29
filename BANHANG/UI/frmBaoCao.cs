using System;
using System.Data;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            txtTongChi.Enabled = false;
            txtTongThu.Enabled = false;
            txtTongLoiNhuan.Enabled = false;
            button2.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql, tn, dn;
            double tc, tt, ttn;
            tn = dateTimePicker3.Value.Date.ToString("MM/dd/yyyy");
            dn = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            if (dateTimePicker1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Focus();
                return;
            }
            if (dateTimePicker3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker3.Focus();
                return;
            }
            DataTable tblPNH;
            sql = "SELECT [ID_HDN] AS 'Mã hóa đơn', [NgayNhap] AS 'Ngày nhập', [ID_NV] AS 'Mã nhân viên', [TrangThai] AS 'Trạng thái', [TongTien] AS 'Tổng tiền', [ID_NCC] AS 'Mã nhà cung cấp' From [HoaDonNhap] Where ([NgayNhap] >= '" + tn + "' AND [NgayNhap] <= '" + dn + "' ) ";
            tblPNH = SqlExecute.ExecuteDataTable(sql);
            dataGridView1.DataSource = tblPNH;
            Hienthi_Luoi();


            DataTable tblHDB;
            sql = "SELECT [ID_HDB] AS 'Mã hóa đơn', [NgayBan] AS 'Ngày bán', [TrangThai] AS 'Trạng thái', [TongTien] AS 'Tổng tiền', [ID_KH] AS 'Mã khách hàng', [ID_NV] AS 'Mã nhân viên' FROM [HoaDonBan] Where ([NgayBan] >= '" + tn + "' AND [NgayBan] <= '" + dn + "' )";
            tblHDB = SqlExecute.ExecuteDataTable(sql);
            dataGridView2.DataSource = tblHDB;
            Hienthi_Luoi1();

            txtTongChi.Text = SqlExecute.GetFieldValues("SELECT SUM([TongTien]) FROM [HoaDonNhap] WHERE ( ([NgayNhap] >= '" + tn + "' AND [NgayNhap] <= '" + dn + "' ) AND ([TrangThai] = N'Đã thanh toán') )");
            txtTongThu.Text = SqlExecute.GetFieldValues("SELECT SUM([TongTien]) From [HoaDonBan] Where ( ([NgayBan] >= '" + tn + "' AND [NgayBan] <= '" + dn + "') AND (TrangThai = N'Đã thanh toán') )");
            if (txtTongChi.Text == "")
                txtTongChi.Text = "0";
            if (txtTongThu.Text == "")
                txtTongThu.Text = "0";
            tc = Convert.ToDouble(txtTongChi.Text);
            tt = Convert.ToDouble(txtTongThu.Text);
            ttn = tt - tc;
            txtTongLoiNhuan.Text = Convert.ToString(ttn);
        }

        private void Hienthi_Luoi()
        {
            string sql, tn, dn;
            DataTable tblPNH;
            tn = dateTimePicker3.Value.Date.ToString("MM/dd/yyyy");
            dn = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            sql = "SELECT * FROM [HoaDonNhap] Where ([NgayNhap] >= '" + tn + "' AND [NgayNhap] <= '" + dn + "' )";
            tblPNH = SqlExecute.ExecuteDataTable(sql);
            dataGridView1.DataSource = tblPNH;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Ngày nhập";
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[3].HeaderText = "Trạng thái";
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.Columns[5].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void Hienthi_Luoi1()
        {
            string sql, tn, dn;
            DataTable tblHDB;
            tn = dateTimePicker3.Value.Date.ToString("MM/dd/yyyy");
            dn = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            sql = "SELECT * FROM [HoaDonBan] Where ([NgayBan] >= '" + tn + "' AND [NgayBan] <= '" + dn + "' )";
            tblHDB = SqlExecute.ExecuteDataTable(sql);
            dataGridView2.DataSource = tblHDB;
            dataGridView2.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView2.Columns[1].HeaderText = "Ngày bán";
            dataGridView2.Columns[2].HeaderText = "Trạng thái";
            dataGridView2.Columns[3].HeaderText = "Tổng tiền";
            dataGridView2.Columns[4].HeaderText = "Mã khách hàng";
            dataGridView2.Columns[5].HeaderText = "Mã nhân viên";
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns[1].Width = 110;
            dataGridView2.Columns[2].Width = 90;
            dataGridView2.Columns[3].Width = 90;
            dataGridView2.Columns[4].Width = 90;
            dataGridView2.Columns[5].Width = 90;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn đóng không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
