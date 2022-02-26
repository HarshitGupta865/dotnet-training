using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarEx2
{

    public class Employ
    {
        public int empid;
        public string name;
        public int basic;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var employ = new List<Employ>()
            {
                new Employ{empid=1, name="Harshit", basic=12345},
                new Employ{empid=2, name="Sumit", basic=23455},
                new Employ(){empid=3, name="Roy", basic = 56789}
            };

            Console.WriteLine(employ.GetType());

            foreach(var v in employ)
            {
                Console.WriteLine(v.empid);
                Console.WriteLine(v.name);
                Console.WriteLine(v.basic);
            }
        }
    }
}
