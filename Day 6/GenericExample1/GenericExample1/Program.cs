using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample1
{

    class Employ
    {
        int empno;
        string name;
        double basic;

        public Employ(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }

        public override string ToString()
        {
            return "Employ No  " + empno + " Name  " + name + " Basic  " + basic;
        }
    }

    class Demo<T>
    {
        
        public void Swap(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo<int> obj = new Demo<int>();
            int a = 3, b = 5;
            obj.Swap(ref a, ref b);
            Console.WriteLine("After swap a = {0} and b = {1}", a, b);
            string s1 = "Harshit", s2 = "Bittu";

            Demo<string> obj1 = new Demo<string>();
            obj1.Swap(ref s1, ref s2);
            Console.WriteLine("After swap s1 = {0} and s2 = {1}", s1, s2);

            Demo<bool> obj3 = new Demo<bool>();
            bool b1=true, b2=false;
            obj3.Swap(ref b1, ref b2);
            Console.WriteLine("After swap b1 = {0} and b2 = {1}", b1, b2);

            Demo<Employ> obj4 = new Demo<Employ>();
            Employ e1 = new Employ(1, "Sachin", 94222);
            Employ e2 = new Employ(3, "Smriti", 85622);
            obj4.Swap(ref e1, ref e2);
            Console.WriteLine("First Object  " + e1 + " Second Object " + e2);
        }
    }
}
