using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    internal class Program
    {
        public delegate void EventDemo();
        public static event EventDemo ShowName;

        public static void Sachin()
        {
            Console.WriteLine("Hiii I am Sachin");
        }

        public static void Harshit()
        {
            Console.WriteLine("Hiii I am Harshit");
        }

        public static void Anubhav()
        {
            Console.WriteLine("Hiii I am Anubhav");
        }

        public static void Execute(string name)
        {
            if (name.Equals("Sachin"))
            {
                ShowName = new EventDemo(Sachin);
                ShowName.Invoke();
            }
            if (name.Equals("Harshit"))
            {
                ShowName = new EventDemo(Harshit);
                ShowName.Invoke();
            }
            if (name.Equals("Anubhav"))
            {
                ShowName = new EventDemo(Anubhav);
                ShowName.Invoke();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name  ");
            string name = Console.ReadLine();
            Execute(name);
        }
    }
}
