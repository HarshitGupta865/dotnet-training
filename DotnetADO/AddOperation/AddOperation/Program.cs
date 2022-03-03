using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AddOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Enter fields to be added
            int empno, basic;
            string name, dept, desig;
            Console.WriteLine("Enter Employ No    ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name   ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department   ");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Designation   ");
            desig = Console.ReadLine();
            Console.WriteLine("Enter Basic    ");
            basic = Convert.ToInt32(Console.ReadLine());

            // Retrieve the database
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EmpDummy");

            // Create a new row to enter the added elements
            DataRow dr = ds.Tables["EmpDummy"].NewRow();

            // Assign values
            dr["empno"] = empno;
            dr["nam"] = name;
            dr["dept"] = dept;
            dr["desig"] = desig;
            dr["basic"] = basic;

            // Enter the assigned values
            ds.Tables["EmpDummy"].Rows.Add(dr);

            //update the dummy data
            ad.Update(ds, "EmpDummy");

            // reflect all changes of dataset (ds) to Emp table
            Console.WriteLine("Record Inserted...");
        }
    }
}
