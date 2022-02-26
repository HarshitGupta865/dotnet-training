using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullTestExample
{
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
       // public double? Commission { get; set; }
       public Nullable<double> Commission { get; set; }

        public double Status { get; set; }

        public override string ToString()
        {
            return "Employ No " + Empno + " Name " + Name + " Commission " + Commission + " Status " + Status;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employ emp1 = new Employ();
            emp1.Empno = 1;
            emp1.Name = "Akhil";
            emp1.Status = emp1.Commission ?? 0;

            Employ emp2 = new Employ();
            emp2.Empno = 2;
            emp2.Name = "Harshit";
            emp2.Commission = 1000;
            emp2.Status = emp2.Commission ?? 0;

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }
    }
}