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
using CrystalDecisions.Shared;
using BANHANG.Report;

namespace BANHANG
{
    public partial class frmBaoCaoBanHang : Form
    {
        public frmBaoCaoBanHang()
        {
            InitializeComponent();
        }

        private void frmBaoCao1_Load(object sender, EventArgs e)
        {
        }
        
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("Select * from BanHang1 where NgayBan between CONVERT(datetime,'" + dtpFrom.Value.Date.ToString("MM/dd/yyyy") + "')and CONVERT(datetime,'" + dtpTo.Value.Date.ToString("MM/dd/yyyy") + "')");
            rptBanHang BC2 = new rptBanHang();
            BC2.SetDataSource(dta);
            crystalRV.ReportSource = BC2;         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
