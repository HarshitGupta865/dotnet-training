using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableEx1
{
    public class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public int ? LeaveDays { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ e1 = new Employ();
            e1.Empno = 1;
            e1.Name = "Bhavya";
            //e1.LeaveDays = 2;
            if (e1.LeaveDays.HasValue)
            {
                Console.WriteLine("Taken Leave Already " + e1.LeaveDays);
            }
            else
            {
                Console.WriteLine("She is Not taken any leaves till now...");
            }
        }
    }
}
