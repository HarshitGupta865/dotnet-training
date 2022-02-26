using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Akther");
            hs.Add("Rukhsar");
            hs.Add("Bhavya");
            hs.Add("Himadri");
            hs.Add("Hari Prasad");
            hs.Add("Akther");
            hs.Add("Rukhsar");
            hs.Add("Bhavya");
            hs.Add("Himadri");
            hs.Add("Akther");
            hs.Add("Rukhsar");
            hs.Add("Bhavya");
            hs.Add("Himadri");
            Console.WriteLine("HashSet Data is  ");
            foreach (object ob in hs)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("Duplicate items are not accepted");
        }
    }
}
