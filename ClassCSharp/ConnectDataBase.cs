using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Viva_vegan.ClassCSharp
{
    class ConnectDataBase
    {
        Entities1 qlnh = new Entities1();
        private SqlConnection connection;
        private String stringConnect;
        private static string path = Path.GetFullPath(Environment.CurrentDirectory);
        private static string nameDB = "QLNH30-08.mdf";
        //private string stringAvailable = @"Data Source=(Localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + nameDB + ";Integrated Security=SSPI";
        //<add name="CONNECTION-NAME" connectionString="metadata=res://*/DBModel.csdl|res://*/DBModel.ssdl|res://*/DBM‌​odel.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=NAME-OF-MY-COMPUTER\sqlexpress;AttachDbFilename=|DataDirectory|\MyDBFile.mdf;Initial Catalog=DATABASE-NAME;Integrated Security=True;MultipleActiveResultSets=True&quot;" providerName="System.Data.EntityClient" />
        private String stringAvailable = @"Data Source=DESKTOP-S418B85\SQLEXPRESS;Initial Catalog=QLNH30-08;Integrated Security=True";

        private static ConnectDataBase sessionConnect;
        public static ConnectDataBase SessionConnect
        {
            get { if (sessionConnect == null) sessionConnect = new ConnectDataBase(); return ConnectDataBase.sessionConnect; }
            private set
            {
                ConnectDataBase.sessionConnect = value;
            }
        }

        #region privateMethods
        private ConnectDataBase() { }
        #endregion
        public ConnectDataBase( string stringConnect)
        {
            try
            {
                // Truyền vào chuỗi rỗng thì lấy chuỗi string có sẵn để kết nối
                if (String.IsNullOrWhiteSpace(stringConnect))
                {
                    this.connection = new SqlConnection(this.stringAvailable);
                    this.stringConnect = this.stringAvailable;
                }
                // Không thì lấy chuỗi string truyền vào để kết nối.
                else
                {
                    this.connection = new SqlConnection(stringConnect);
                    this.stringConnect = stringConnect;
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        //Asyn function executeQuery
        // Asyncronous -> bất đồng bộ
        public async Task<DataTable> executeQueryAsync(String query, Object[] paramaters = null)
        {

            try
            {
                DataTable table = new DataTable();
                using (SqlConnection conn = new SqlConnection(this.stringAvailable))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (paramaters != null)
                    {
                        String[] listParams = query.Split(' ');
                        cmd = new SqlCommand(listParams[0], conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = 0;
                        foreach (String item in listParams)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, paramaters[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    await Task.Run(() => adapter.Fill(table));
                    //đợi tau chạy xong đã
                    conn.Close();
                }
                return table;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
                return null;
            }
        }
        public DataTable executeQuery (String query, Object [] paramaters=null)
        {

            try
            {
                DataTable table = new DataTable();
                using (SqlConnection conn = new SqlConnection(this.stringAvailable))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (paramaters != null)
                    {

                        String[] listParams = query.Split(' ');
                        cmd = new SqlCommand(listParams[0], conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = 0;
                        foreach (String item in listParams)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, paramaters[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    conn.Close();
                }
                return table;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
                return null;
            }
        }
        public DataTable executeQueryNoProc(String query, Object[] paramaters = null)
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlConnection conn = new SqlConnection(this.stringAvailable))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (paramaters != null)
                    {

                        String[] listParams = query.Split(' ');
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.Text;
                        int i = 0;
                        foreach (String item in listParams)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, paramaters[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    conn.Close();
                }
                return table;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
                return null;
            }
            
        }
        // trả về số bảng ghi truy vấn thành công
        public int executeNonQuery(String query, Object[] paramaters = null)
        {
            try
            {
                int data = 0;
                using (SqlConnection conn = new SqlConnection(stringAvailable))
                {
                    conn.Open();
                    SqlCommand cmd = cmd = new SqlCommand(query, conn);
                    if (paramaters != null)
                    {
                        String[] listParams = query.Split(' ');
                        cmd = new SqlCommand(listParams[0], conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = 0;
                        foreach (String item in listParams)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, paramaters[i]);
                                i++;
                            }
                        }
                    }
                    data = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                return data;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
                return -1;
            }
        }
        public async Task<int> executeNonQueryAsync(String query, Object[] paramaters = null)
        {

            try
            {
                int data = 0;
                using (SqlConnection conn = new SqlConnection(stringAvailable))
                {
                    conn.Open();
                    SqlCommand cmd = cmd = new SqlCommand(query, conn);
                    if (paramaters != null)
                    {
                        String[] listParams = query.Split(' ');
                        cmd = new SqlCommand(listParams[0], conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = 0;
                        foreach (String item in listParams)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, paramaters[i]);
                                i++;
                            }
                        }
                    }
                    await Task.Run(() => data = cmd.ExecuteNonQuery());
                    conn.Close();
                }
                return data;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
                return -1;
            }
        }
        // trả về giá trị đầu tiên của bảng.
        public object executeScalar(String query, Object[] paramaters = null) //select count (*)
        {

            try
            {
                object data = 0;
                using (SqlConnection conn = new SqlConnection(stringAvailable))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int i = 0;
                    if (paramaters != null)
                    {
                        String[] listParams = query.Split(' ');
                        cmd = new SqlCommand(listParams[0], conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (String item in listParams)
                        {
                            if (item.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(item, paramaters[i]);
                                i++;
                            }
                        }
                    }
                    data = cmd.ExecuteScalar();
                    conn.Close();
                }
                return data;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
                return -1;
            }
        }
        public async Task<object> executeScalarAsync(String query, Object[] paramaters = null) //select count (*)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(stringAvailable))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int i = 0;
                if (paramaters != null)
                {
                    String[] listParams = query.Split(' ');
                    cmd = new SqlCommand(listParams[0], conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (String item in listParams)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, paramaters[i]);
                            i++;
                        }
                    }
                }
                await Task.Run(() => data = cmd.ExecuteScalar());
                conn.Close();
            }
            return data;
        }
        public DataTable executeReaderDependency (SqlCommand cmd,String query =null)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.stringAvailable))
            {
                conn.Open();
                cmd.Connection = conn;
                if(!String.IsNullOrWhiteSpace(query))
                {
                    cmd.CommandText = query;
                }
                table.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
                conn.Close();
            }
            return table;
        }
        public SqlConnection getConnection()
        {
            return this.connection=new SqlConnection(stringAvailable);
        }
        public void closeDB()
        {
            this.connection.Close();
        }
        public void openDB()
        {
            this.connection.Open();
        }
        public void setConnection (SqlConnection temp)
        {
            this.connection = temp;
        }
        public String getStringConnection()
        {
            return this.stringAvailable;
        }
        public void setStringConnection(String temp)
        {
            this.stringConnect = temp;
        }
        public async Task<bool> TrungSdtKhachHang (string sdt)
        {
            string query = "select * from khachhang where dienthoaikh='" + sdt + "'";
            int res =await ConnectDataBase.SessionConnect.executeNonQueryAsync(query);
            Console.WriteLine(res);
            if (res > 0)
            {
                return true;
            }
            else return false;
        }
        public DateTime GetNgaySinhKh (string makh)
        {
            try
            {
                List<KHACHHANG> khs = qlnh.KHACHHANGs.Where(x => x.MAKH == makh).ToList();
                return khs[0].NGAYSINHKH;
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            return DateTime.Now;
        }
    }
}
