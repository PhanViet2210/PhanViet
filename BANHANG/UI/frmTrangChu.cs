using System;
using System.Data;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class frmTrangChu : Form
    {
        
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tongQuanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.panel10.Controls.Clear();
            this.panel10.Controls.Add(chartDoanhThu);
            this.panel10.Controls.Add(chartDonHangBan);
            this.panel10.Controls.Add(chartDonHangNhap);
            this.panel10.Controls.Add(chartRevenue);
            this.panel10.Controls.Add(chartTonKho);
        }
        private void AddForm(Form f)
        {
            this.panel10.Controls.Clear();         
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel10.Controls.Add(f);
            f.Show();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            AddForm(f);
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            AddForm(f);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            AddForm(f);
        }

        private void nhaSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaSanXuat f = new frmNhaSanXuat();
            AddForm(f);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            AddForm(f);
        }

        private void hóaĐơnBánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang f = new frmHoaDonBanHang();
            AddForm(f);
        }

        private void phiếuNhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHoaDonNhapHang f = new frmHoaDonNhapHang();
            AddForm(f);
        }


        private void ThoatToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                //  this.Close();
                Application.Exit();
                
            }
        }

        private void SanPham_Click(object sender, EventArgs e)
        {
            frmTimKiemSanPham f = new frmTimKiemSanPham();
            AddForm(f);
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimKiemKhachHang f = new frmTimKiemKhachHang();
            AddForm(f);
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDonBanHang f = new frmTimKiemHoaDonBanHang();
            AddForm(f);
        }
        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDonNhapHang f = new frmTimKiemHoaDonNhapHang();
            AddForm(f);
        }

        public void mnuDangXuat_Click(object sender, EventArgs e)
        {
            //     frmDangNhap1.mk = "";
            DialogResult TBthoat;
            TBthoat = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBthoat == DialogResult.Yes)
            {
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
                Close();
            }
            
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan f = new FrmTaiKhoan();
            AddForm(f);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan f = new frmQuanLyTaiKhoan();
            AddForm(f);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
        

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (frmDangNhap.quyentruycap == 1) btnQLTK.Hide();

            // Chart Hóa đơn bán
            string sql1 = "execute TongDonHangBan";
            DataTable dt1;
            dt1 = SqlExecute.ExecuteDataTable(sql1);
            chartDonHangBan.DataSource = dt1;
            chartDonHangBan.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartDonHangBan.ChartAreas["ChartArea1"].AxisY.Title = "Tổng đơn hàng";
            chartDonHangBan.Series["DonHangBan"].XValueMember = "Ngay";             
            chartDonHangBan.Series["DonHangBan"].YValueMembers = "Total";

            // Chart Hóa đơn nhập
            string sql2 = "execute TongDonHangNhap";
            DataTable dt2;
            dt2 = SqlExecute.ExecuteDataTable(sql2);
            chartDonHangNhap.DataSource = dt2;
            chartDonHangNhap.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartDonHangNhap.ChartAreas["ChartArea1"].AxisY.Title = "Tổng đơn hàng";
            chartDonHangNhap.Series["DonHangNhap"].XValueMember = "Ngay";
            chartDonHangNhap.Series["DonHangNhap"].YValueMembers = "Total";

            // Chart Tồn Kho
            string sql3 = "execute TonKho";
            DataTable dt3;
            dt3 = SqlExecute.ExecuteDataTable(sql3);
            chartTonKho.DataSource = dt3;
            chartTonKho.Series["TonKho"].XValueMember = "ID_SP";
            chartTonKho.Series["TonKho"].YValueMembers = "SoLuong";

            // Chart Doanh Thu
            string sql4 = "execute DoanhThu";
            DataTable dt4;
            dt4 = SqlExecute.ExecuteDataTable(sql4);
            chartDoanhThu.DataSource = dt4;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Ngay";
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "Total";


            // Chart Lợi Nhuận
            string sql5 = "execute LoiNhuan";
            DataTable dt5;
            dt5 = SqlExecute.ExecuteDataTable(sql5);
            chartRevenue.DataSource = dt5;
            chartRevenue.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartRevenue.ChartAreas["ChartArea1"].AxisY.Title = "Lợi Nhuận";
            chartRevenue.Series["LoiNhuan"].XValueMember = "NgayBan";
            chartRevenue.Series["LoiNhuan"].YValueMembers = "Loinhuan";

        }

        private void mnuBCBH_Click(object sender, EventArgs e)
        {
         //   BCBH = true;
            frmBaoCaoBanHang f = new frmBaoCaoBanHang();
            AddForm(f);
        }

        private void mnuThuChi_Click(object sender, EventArgs e)
        {
            BaoCao f = new BaoCao();
            AddForm(f);
        }

        private void mnuQLHD_Click(object sender, EventArgs e)
        {
            frmDanhSachHoaDon f = new frmDanhSachHoaDon();
            AddForm(f);
        }

        private void mnuBCTK_Click(object sender, EventArgs e)
        {
            frmBaoCaoTonKho.BCTK = true;
            frmBaoCaoTonKho f = new frmBaoCaoTonKho();
            AddForm(f);
        }

        private void baoCaoToolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
