using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace NamedValueUsage
{
    
    internal class Program
    {
        static NameValueCollection GetCollection()
        {
            NameValueCollection collection = new NameValueCollection();
            collection.Add("Sam", "The Dev Codes");
            collection.Add("Bill", "Microsoft");
            collection.Add("Bill", "White House");
            collection.Add("Sam", "IBM");
            return collection;
        }
        static void Main(string[] args)
        {
            NameValueCollection collection = GetCollection();
            foreach (string key in collection.AllKeys) // <-- No duplicates returned.
            {
                Console.WriteLine(key);
            }
        }
    }
}
