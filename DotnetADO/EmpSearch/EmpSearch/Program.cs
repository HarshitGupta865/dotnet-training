using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace EmpSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Number");
            int empno = Convert.ToInt32(Console.ReadLine());

            // To extract the entered empno from the database if present
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp where empno=@empno", conn);ad.SelectCommand.Parameters.AddWithValue("@empno", empno);
            
            DataSet ds = new DataSet();

            // If empno found then add that row to the dummy database
            ad.Fill(ds, "EmpDummy");

            // If empno found then number of rows in database = 1 else 0
            int count = ds.Tables["EmpDummy"].Rows.Count;
            if (count==1)
            {
                DataRow dr = ds.Tables["EmpDummy"].Rows[0];
                Console.WriteLine("Employ Name  " +ds.Tables["EmpDummy"].Rows[0]["Nam"]);
                Console.WriteLine("Employ Name    " + dr["nam"]);
                Console.WriteLine("Department   " + dr["dept"]);
                Console.WriteLine("Desigantion   " + dr["desig"]);
                Console.WriteLine("Basic   " + dr["basic"]);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
