using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DeleteEmpOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Empno to be deleted
            int empno;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());

            // Retrieve the entered empno if found and add it to dummy database
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp where empno=@empno", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            ad.SelectCommand.Parameters.AddWithValue("@empno", empno);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");

            // Delete operation
            int count = ds.Tables["EmpDummy"].Rows.Count;
            if (count==1)
            {
                DataRow dr = ds.Tables["EmpDummy"].Rows[0];
                dr.Delete();
                ad.Update(ds, "EmpDummy");
                Console.WriteLine("Record Deleted...");
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
        }
    }
}
