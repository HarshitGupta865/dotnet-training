using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample2
{
    class Data<T,V>
    {
        T t;
        V v;

        public Data(T t, V v)
        {
            this.t = t;
            this.v = v;
        }

        public void show()
        {
            Console.WriteLine("First data type = "+ t.GetType().Name);
            Console.WriteLine("First data type = " + v.GetType().Name);
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Data<int, string> obj = new Data<int, string>(1, "Sachin");
            obj.show();
            Console.WriteLine();
            Data<int, int> obj1 = new Data<int, int>(1, 5);
            obj1.show();
        }
    }
}
