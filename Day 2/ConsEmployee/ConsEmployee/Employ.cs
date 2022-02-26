﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsEmployee
{
    internal class Employ
    {
        int empno;
        string name;
        double basic;
        public Employ()
        {
            this.empno = 1;
            this.name = "Anubhav";
            this.basic = 99425;
        }
        public Employ(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
        public override string ToString()
        {
            return "Employ No " + empno + " Name  " + name + " Basic " + basic;
        }
    }
}