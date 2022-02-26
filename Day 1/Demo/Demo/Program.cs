using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Difference
    {
        public void ram()
        {
            Console.WriteLine("Hiii I am Ram");
        }
        internal void vijay()
        {
            Console.WriteLine("Hiii I am Vijay");
        }
        private void priya()
        {
            Console.WriteLine("Hiii I am Priya");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Difference d = new Difference();
            d.vijay();
            d.ram();
            //d.priya();  This statement will give error.
        }
    }
}
