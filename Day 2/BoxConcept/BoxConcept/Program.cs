using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConcept
{
    internal class Program
    {
        public void show(object ob)
        {
            Console.WriteLine(ob.GetType());
            string type = ob.GetType().Name;
            if(type.Equals("Int32"))
            {
                Console.WriteLine("Integer Casting");
                int r = (int)ob;
                Console.WriteLine(r);
            }
            else if(type.Equals("Double"))
            {
                Console.WriteLine("Double Casting");
                double re = (double)ob;
                Console.WriteLine(re);
            }    
            else if(type.Equals("String"))
            {
                Console.WriteLine("String casting");
                string s = (string)ob;
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            int x = 12;
            double y = 12.5;
            string st = "Boss";
            Program obj = new Program();
            obj.show(x);
            obj.show(y);
            obj.show(st);
        }
    }
}
