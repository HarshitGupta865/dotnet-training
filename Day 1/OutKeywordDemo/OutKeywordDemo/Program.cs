using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeywordDemo
{
    internal class Program
    {

        public void Show(int choice, out string name, out int code)
        {
            name = "";
            code = 0;
            if(choice == 0)
            {
                name = "I am choice 0";
                code = 0;
            }
            else if (choice == 1)
            {
                name = "I am choice 1";
                code = 1;
            }
            else if (choice == 2)
            {
                name = "I am choice 2";
                code = 2;
            }
        }
        static void Main(string[] args)
        {
            string name; int code;
            int choice = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Show(choice,out name, out code);
            Console.WriteLine("Choice = {0}, Name = {1}, Code = {2}", choice, name, code);
        }
    }
}
