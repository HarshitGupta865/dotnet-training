using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordDemo3
{
    internal class Program
    {
        static int count;
        public void inc()
        {
            count++;
        }
        public void show()
        {
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program o = new Program();
            Program ob = new Program();
            obj.inc();
            o.inc();
            obj.inc();
            //ob.inc();
            obj.show();
        }
    }
}
