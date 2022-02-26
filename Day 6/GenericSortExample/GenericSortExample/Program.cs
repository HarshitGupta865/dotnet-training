using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student{Sno=1,Sname="Mohammed",Cgp=9.6,Gender="Male"},
                new Student{Sno=2,Sname="Abhishek",Cgp=8.6,Gender="Male"},
                new Student{Sno=3,Sname="Manali",Cgp=7.6,Gender="Female"},
                new Student{Sno=4,Sname="Tamanna",Cgp=8.6,Gender="Female"},
                new Student{Sno=5,Sname="Prathyusha",Cgp=9.1,Gender="Male"},
            };

            studentList.Sort();
            Console.WriteLine("Sorted List  ");
            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }

            studentList.Sort(new CgpComparor());
            Console.WriteLine("Sort By Cgp Wise...");
            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
