using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    [Serializable]
    internal class Employ
    {
        public int empno;
        public string name;
        public int basic;

        public override string ToString()
        {
            return "Empno = " + empno + " Name = " + name + " Basic pay = " + basic;
        }
    }
}
