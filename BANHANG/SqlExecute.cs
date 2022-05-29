using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BANHANG
{
    class SqlExecute
    {
        public static SqlConnection cnn;

        //Kết nối DTB
        public static void Connect()
        {
            try
            {
                //Lưu ý: Mỗi máy có 1 ConnectionString riêng

                //ConnectionString Yen
               // cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\Dotnet-DB\BANHANG\DTB\QL_BANHANG.mdf;Integrated Security=True");

                //ConnectionString Vu
               //cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\Dotnet-DB\BANHANG\DTB\QL_BANHANG.mdf;Integrated Security=True");

                //ConnectionString Khai
                cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Dotnet-DB-master\BANHANG\DTB\QL_BANHANG.mdf;Integrated Security=True");

                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error! " + ex.Message, "Information");
            }         
        }

        //Ngắt kết nối DTB
        public static void Disconnect()
        {
            if (cnn.State != ConnectionState.Closed)
            {
                cnn.Close();
                cnn.Dispose();
                cnn = null;
            }            
        }

        //Thực thi command trả về DataTable
        public static DataTable ExecuteDataTable(string commandText)
        {
            Connect();

            try
            {                                
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandText, cnn);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return null;
        } 
        
        //Thực thi command
        public static void ExecuteCommand(string commandText)
        {
            Connect();

            try
            {
                new SqlCommand(commandText, cnn).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }      

        //Thực thi command
        public static void ExecuteCommand(SqlCommand cmd)
        {
            Connect();
            cmd.Connection = cnn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        //Lấy giá trị thỏa mãn command
        public static string GetFieldValues(string commandText)
        {
            Connect();

            string id = "";

            try
            {
                SqlDataReader reader = new SqlCommand(commandText, cnn).ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return id;
        }

        //Tạo ID theo thời gian hiện tại (<prefix>yyyyMMddHHmmss)
        public static string CreateUniqueID(string prefix, DateTime dt)
        {
            return  prefix
                    + dt.ToString("dd/MM/yy").Replace("/", "")
                    + "T"
                    + dt.ToString("HH:mm:ss").Replace(":", "");            
        }
    }
}
