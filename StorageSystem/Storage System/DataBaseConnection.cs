using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Storage_System
{
    class DataBaseConnection
    {

        public SqlConnection conn = new SqlConnection("Data Source=FEDE\\SQLEXPRESS; Initial Catalog=STORAGE_SISTEM; Integrated Security=True");
        
        public void Open()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connection Opened");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to open connection", ex);
            }
        }

        public void Close()
        {
            try
            {
                conn.Close();
                Console.WriteLine("Connection Closed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to close connection" , ex);
            }
        }

    }
}
