using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastExample
{
    class Program
    {
        public delegate void MyDelegate(string s);

        public void Show(string s)
        {
            Console.WriteLine("From Show Method  " + s);
        }

        public void Display(string s)
        {
            Console.WriteLine("From Display Method " + s);
        }

        public void Test(string s)
        {
            Console.WriteLine("From Test Method   " + s);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            MyDelegate delegateObj = new MyDelegate(obj.Show);
            delegateObj += new MyDelegate(obj.Test);
            delegateObj += new MyDelegate(obj.Display);
            delegateObj("Sachin");
            delegateObj -= new MyDelegate(obj.Display);
            delegateObj("Srishti");
        }
    }
}
