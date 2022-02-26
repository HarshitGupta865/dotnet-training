using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyExample
{
    class Employ
    {
        public int empid;
        public string name;
        public int basic;

        public Employ(int empid, string name, int basic)
        { 
            this.empid = empid;
            this.name = name;
            this.basic = basic; 
        }  
    }
}
