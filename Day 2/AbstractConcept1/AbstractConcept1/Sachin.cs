using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConcept1
{
    class Sachin : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is sachin@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Name is Sachin...");
        }
    }
}
