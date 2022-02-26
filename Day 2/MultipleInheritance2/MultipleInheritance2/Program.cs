using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance2
{
    interface IOne
    {
        void Name();
    }

    interface ITwo
    {
        void Name();
    }

    interface IThree
    {
        void Name();
    }

    class Test : IOne, ITwo, IThree
    {
        void IOne.Name()
        {
            throw new NotImplementedException();
        }

        void ITwo.Name()
        {
            throw new NotImplementedException();
        }
        void IThree.Name()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
