using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace EmpAdoEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // To connect with database with key name - sqlpracticeconn
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;

            // To retrieve data from the database
            SqlConnection connection = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * From Emp", connection);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");

            // EmpDummy is the dummy database which is contained in dataset
            // where all action takes place before affecting actual database

            // DataRow : Contains the information about each row in dataset
            foreach (DataRow dr in ds.Tables["EmpDummy"].Rows)
            {
                Console.WriteLine("Employ No   " +dr["empno"]);
                Console.WriteLine("Employ Name  " +dr["nam"]);
                Console.WriteLine("Department   " +dr["dept"]);
                Console.WriteLine("Designation   " +dr["desig"]);
                Console.WriteLine("Basic   " +dr["basic"]);
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
