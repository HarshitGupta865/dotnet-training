using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Prajjwal");
            ht.Add(2, "Madhav");
            ht.Add(3, "Harshit Kumar");
            ht.Add(4, "Sharif");
            ht.Add(5, "Zaran");
            ht.Add(13, "Gyanendra");
            ht.Add(6, "Tamanna");

            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine("Key = {0} and value = {1}", entry.Key, entry.Value);
            }

        }
    }
}
