using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnonymous
{
    internal class Program
    {
        public delegate void Show(string xyz);
        static void Main(string[] args)
        {
            Show obj = delegate (string str)
            {
                Console.WriteLine("This is Anonymous Method " + str);
            };
            obj("Manali");
        }
    }
}
