using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employ emp = new Employ(1, "Harshit", 3456);

            Console.WriteLine(emp.empid);
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.basic);
        }
    }
}
