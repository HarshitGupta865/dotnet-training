using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeEmpList
{
    [Serializable]
    internal class Employ
    {
        public int Empno { get; set; }  
        public string Name { get; set; }    
        public int Basic { get; set; }

        public override string ToString()
        {
            return "Empno = " + Empno + " Name = " + Name + " Basic = " + Basic;
        }
    }
}
