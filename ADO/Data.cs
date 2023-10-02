using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ADO
{
    public class Data
    {
        public void Connection()
        {
            string cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=ado_db;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection has benn Created Sucessful");
                }
            }
        }
    }
}
