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
using System.IO;
using System.Drawing.Imaging;

namespace BANHANG
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
            this.dataGridSP.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
        }
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        public void Load_Dulieu_NhaSanXuat()
        {
            DataTable dta = new DataTable();
            dta = SqlExecute.ExecuteDataTable("Select ID_NSX From NhaSanXuat");
            cboMaNSX.DataSource = dta;
            cboMaNSX.DisplayMember = "ID_NSX";
            cboMaNSX.ValueMember = "ID_NSX";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtDongiaban.Text = "";
                txtDongianhap.Text = "";
                txtMotaSP.Text = "";
                txtSoLuong.Text = "";
                txtBaohanh.Text = "";
                txtMaSP.Focus();
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
                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.CommandText = @"INSERT INTO SanPham(ID_SP, TenSP, GiaNhap, GiaBan, MoTa,SoLuong,ID_NSX,BaoHanh,ImgSP) 
                                            VALUES(@ID_SP, @TenSP, @GiaNhap, @GiaBan, @MoTa, @SoLuong,@ID_NSX,@BaoHanh,@ImgSP)";
                    cmd.Parameters.AddWithValue("@ID_SP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@GiaNhap", txtDongianhap.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", txtDongiaban.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtMotaSP.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@ID_NSX", cboMaNSX.Text);
                    cmd.Parameters.AddWithValue("@BaoHanh", txtBaohanh.Text);


                    MemoryStream stream = new MemoryStream();
                    picSP.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@ImgSP", pic);

                    SqlExecute.ExecuteCommand(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Dulieu_DMSP();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult TBsua;
            TBsua = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBsua == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.CommandText = @"UPDATE SanPham set ImgSP = @pic,TenSP = @TenSP,GiaNhap=@GiaNhap,Giaban= @GiaBan,MoTa= @MoTa,SoLuong= @SoLuong,ID_NSX =@ID_NSX,BaoHanh =@BaoHanh
                             where ID_SP = '" + txtMaSP.Text + "'";

                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@GiaNhap", txtDongianhap.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", txtDongiaban.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtMotaSP.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@ID_NSX", cboMaNSX.Text);
                    cmd.Parameters.AddWithValue("@BaoHanh", txtBaohanh.Text);

                    MemoryStream stream = new MemoryStream();
                    picSP.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@pic", pic);

                    SqlExecute.ExecuteCommand(cmd);
                    Dulieu_DMSP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! - " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult TBxoa;
            TBxoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBxoa == DialogResult.Yes)
            {
                SqlExecute.ExecuteCommand("Delete SanPham where ID_SP = '" + txtMaSP.Text + "'");
                Dulieu_DMSP();
            }
        }
        public void Dulieu_DMSP()
        {
            try
            {
                DataTable dta = new DataTable();
                dta = SqlExecute.ExecuteDataTable("Select * From SanPham");
                dataGridSP.DataSource = dta;
                //dataGridSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmDMSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter1.Fill(this.dataSet.SanPham);
            // TODO: This line of code loads data into the 'dataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter1.Fill(this.dataSet.SanPham);
            Load_Dulieu_NhaSanXuat();
            Dulieu_DMSP();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if (openFile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFile.OpenFile()) != null)
                    {

                        string fileName = openFile.FileName;
                        txtImagepath.Text = openFile.FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("Kích thước file quá lớn !");
                        }
                        else
                            picSP.Load(fileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSP.CurrentRow.Cells[e.ColumnIndex].Value.ToString() != null)
            {
                dataGridSP.CurrentRow.Selected = true;

                txtMaSP.Text = dataGridSP.CurrentRow.Cells[0].FormattedValue.ToString();
                txtTenSP.Text = dataGridSP.CurrentRow.Cells[1].FormattedValue.ToString();
                txtDongianhap.Text = dataGridSP.CurrentRow.Cells[2].FormattedValue.ToString();
                txtDongiaban.Text = dataGridSP.CurrentRow.Cells[3].FormattedValue.ToString();
                txtMotaSP.Text = dataGridSP.CurrentRow.Cells[5].FormattedValue.ToString();
                txtSoLuong.Text = dataGridSP.CurrentRow.Cells[6].FormattedValue.ToString();
                cboMaNSX.Text = dataGridSP.CurrentRow.Cells[7].FormattedValue.ToString();
                txtBaohanh.Text = dataGridSP.CurrentRow.Cells[8].FormattedValue.ToString();

                byte[] imgData = (byte[])dataGridSP.CurrentRow.Cells[4].Value;

                Image newImage;
                MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length);
                ms.Write(imgData, 0, imgData.Length);
                    newImage = Image.FromStream(ms, false,false);
                    picSP.Image = newImage;

            }
        }
    }
}

