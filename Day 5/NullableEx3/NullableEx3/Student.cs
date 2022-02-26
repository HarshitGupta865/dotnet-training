using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableEx3
{
    internal class Student
    {
        public int sno;
        public string sname;
        public string gender;

        // One way to declare nullable variables
        // public  double ? cgpa;

        // Another way to declare nullable variables
        public Nullable<double> cgpa;

        public void show()
        {
            Console.WriteLine("Student No " + sno);
            Console.WriteLine("Student Name  " + sname);
            Console.WriteLine("Gender " + gender);
            if (cgpa.HasValue)
            {
                Console.WriteLine("Cgp is  " + cgpa);
            }
            else
            {
                Console.WriteLine("My Exam Still Not Conducted...");
            }
        }
    }
}
