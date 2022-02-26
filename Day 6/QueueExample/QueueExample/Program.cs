using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue("Ashwin");
            qu.Enqueue("Navdeep");
            qu.Enqueue("Abhishek");
            qu.Enqueue("Raj");

            Console.WriteLine("Queue Data is  ");
            foreach (object ob in qu)
            {
                Console.WriteLine(ob);
            }
            qu.Dequeue();
            qu.Dequeue();
            Console.WriteLine("Queue after remove operation");
            foreach (object ob in qu)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
