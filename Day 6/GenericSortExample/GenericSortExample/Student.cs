using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortExample
{
    public class Student : IComparable<Student>
    {
        public int Sno { get; set; }
        public string Sname { get; set; }
        public string Gender { get; set; }
        public double Cgp { get; set; }

        public int CompareTo(Student other)
        {
            return Gender.CompareTo(other.Gender);
        }

        public override string ToString()
        {
            return "Sno  " + Sno + " Student Name " + Sname + " Gender " + Gender + " Cgp " + Cgp;
        }

    }
}
