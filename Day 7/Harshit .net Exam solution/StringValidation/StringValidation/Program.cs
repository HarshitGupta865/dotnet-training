using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidation
{
    internal class Program
    {
        public void validate(string s)
        {
            int k = 0;
            if(s.Length == 11)
            {
                if(s[3] == '-' && s[6] == '-')
                {
                    for(int i=0; i<s.Length; i++)
                    {
                        if(i!=3 && i!=6)
                            {
                                if (s[i] == '0' || s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4'
                                    || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
                                    {
                                         k = 1;
                                    }
                                else
                                    {
                                        k = 0;
                                        break;
                                    }
                        }

                    }
                }
            }
            if(k == 1)
            {
                Console.WriteLine("Validation successful");
            }
            else
            {
                Console.WriteLine("Validation not successful");
            }

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine(); 
            Program obj = new Program();
            obj.validate(str);
        }
    }
}
