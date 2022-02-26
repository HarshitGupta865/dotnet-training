using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student();
            ob1.sno = 1;
            ob1.sname = "Harshit";
            ob1.gender = "male";
            ob1.cgpa = 9.4;


            Student ob2 = new Student();
            ob2.sno = 2;
            ob2.sname = "Roop";
            ob2.gender = "female";

            ob1.show();
            ob2.show();
        }
    }
}
