using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITraining[] arr = new ITraining[]
            //{
            //    new Anubhav(),new Sachin()
            //};

            //foreach (ITraining i in arr)
            //{
            //    i.Name();
            //    i.Email();
            //}

            ITraining i = new Anubhav();
            i.Name();
            i.Email();
            ITraining it = new Sachin();
            it.Name();
            it.Email();

        }
    }
}
