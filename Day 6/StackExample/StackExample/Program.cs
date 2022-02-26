using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();
            obj.Push("Himadri");
            obj.Push("Madhav");
            obj.Push("Rohit");
            obj.Push("Harshit");
            obj.Push(12);
            Console.WriteLine("Stack Data ");
            foreach (object ob in obj)
            {
                Console.WriteLine(ob);
            }

            obj.Pop();
            obj.Pop();
            Console.WriteLine("Stack after Pop Operation");
            foreach (object ob in obj)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
