using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, s=  "";
            FileStream fs = new FileStream("d:/myname.txt", FileMode.Open, FileAccess.Read);    
            StreamReader sr = new StreamReader(fs);
            str = sr.ReadToEnd();
            for(int i=0; i<str.Length; i++)
            {
                if(Char.IsLetter(str[i]))
                {
                    if(Char.IsLower(str[i]))
                    {
                        s = s + Char.ToUpper(str[i]);
                    }
                    else
                    {
                        s = s + str[i];
                    }
                }
                else
                {
                    s = s + str[i];
                }
            }
            Console.WriteLine("Result = " + s);
        }
    }
}
