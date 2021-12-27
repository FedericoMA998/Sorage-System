using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;


namespace BackendProcess
{
    public class DataProcess
    {
        SqlConnection conect = new SqlConnection("Data Source=FEDE\\SQLEXPRESS; Initial Catalog=STORAGE_SISTEM; Integrated Security=True");

        conect

            DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        DA.Fill(DS);
            conn.Close();

            return DS;
    }
}
