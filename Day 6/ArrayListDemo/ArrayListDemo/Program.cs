using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("Smrithi");
            a.Add("Sachin");
            a.Add("Sheelendra");
            a.Add("Anshual");

            foreach(object o in a)
            {
                Console.WriteLine(o);
            }

            a.Insert(2, "Harshit");
            Console.WriteLine("List after adding new Value ");
            foreach (object o in a)
            {
                Console.WriteLine(o);
            }

            a.Remove("Sheelendra");
            Console.WriteLine("List after removing by Obejct ");
            foreach (object ob in a)
            {
                Console.WriteLine(ob);
            }

            a.RemoveAt(2);
            Console.WriteLine("List after removing by Object Index...");
            foreach (object ob in a)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
