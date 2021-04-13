using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleAppAshish
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = "server=.;initial catalog=Dev_Demo2019;integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BufferEmployee", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dt.ToCSV("D://ShaktiSing.csv");                
            }
        }
    }
}
