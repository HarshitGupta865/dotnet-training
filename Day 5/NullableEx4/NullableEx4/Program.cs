using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent obj1 = new Agent();
            obj1.agentNo = 1;
            obj1.agentName = "Harshit";
            obj1.agentStatus = obj1.businessAmount ?? 0;

            Agent obj2 = new Agent();
            obj2.agentNo = 2;
            obj2.agentName = "Sumit";
            obj2.businessAmount = 2345;
            obj2.agentStatus = obj2.businessAmount ?? 0;

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

        }
    }
}
