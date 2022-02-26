using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Harshit");
            dic.Add(2, "Sumit");
            dic.Add(3, "Roy");
            dic.Add(4, "Rohan");
            dic.Add(5, "Srishti");
            Console.WriteLine("Enter Employ No    ");
            int empno = Convert.ToInt32(Console.ReadLine());
            string result;
            dic.TryGetValue(empno, out result);
            Console.WriteLine("Result is  " + result);

        }
    }
}
