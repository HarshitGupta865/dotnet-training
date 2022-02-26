using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept2
{
    class Info
    {
        int empno;
        String name;
        double basic;

        public Info(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }

        public override string ToString()
        {
            return "Name = " + name + " Empno. = " + empno + " Basic pay = " + basic;
        }
    }

    class Harshit : Info
    {
        public Harshit(int empno, string name, double basic) : base(empno, name, basic)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Harshit obj = new Harshit(1, "Harshit", 88522);
            Console.WriteLine(obj);
        }
    }
}
