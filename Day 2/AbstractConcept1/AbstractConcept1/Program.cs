using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConcept1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Training[] arr = new Training[]
            //{
            //    new Anubhav(),
            //    new Tanmay(),
            //    new Sachin()
            //};

            //foreach (Training t in arr)
            //{
            //    t.Name();
            //    t.Email();
            //}

            Training t = new Anubhav();
            t.Email();
            t.Name();
            Training tr = new Sachin();
            tr.Email();
            tr.Name();
            Training tra = new Tanmay();
            tra.Email();
            tra.Name();

        }
    }
}
