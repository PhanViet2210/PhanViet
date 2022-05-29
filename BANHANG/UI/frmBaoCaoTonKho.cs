using BANHANG.Report;
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
    public partial class frmBaoCaoTonKho : Form
    {
        public static bool BCTK = false, HDBH = false;
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void crystalRV_Load(object sender, EventArgs e)
        {

        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            if (BCTK == true)
            {
                DataTable dta = new DataTable();
                dta = SqlExecute.ExecuteDataTable("Select * from SanPham");
                rptTonKho BC1 = new rptTonKho();
                BC1.SetDataSource(dta);
                crystalRV.ReportSource = BC1;
                BCTK = false;
            }
            if (HDBH == true)
            {

                DataTable dta2 = new DataTable();
                dta2 = SqlExecute.ExecuteDataTable("Select * from HoaDonBanHang where ID_HDB = '"+ frmDanhSachHoaDon.ID_HD+"'");
                rptHoaDonBanHang BC1 = new rptHoaDonBanHang();
                BC1.SetDataSource(dta2);
                crystalRV.ReportSource = BC1;
                HDBH = false;
            }
        }
    }
}
