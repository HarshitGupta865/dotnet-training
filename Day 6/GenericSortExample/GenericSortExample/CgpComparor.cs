using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortExample
{
    class CgpComparor : Comparer<Student>
    {
        public override int Compare(Student x, Student y)
        {
            if (x.Cgp >= y.Cgp)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
