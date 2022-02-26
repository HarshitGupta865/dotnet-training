using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class Program
    {

        public void show(params string []names)
        {
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.show();
            obj.show("Ashwin");
            obj.show("Manish", "Ashwin", "Chanpreet");
            obj.show("Manish", "Sandra", "Sashwat", "Prajjwal");

        }
    }
}
