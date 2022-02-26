using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userData = new Dictionary<string, string>();
            userData.Add("Tamanna", "Gupta");
            userData.Add("Harshit", "Tripathi");
            userData.Add("Pradyumna", "Sai");
            userData.Add("Varun", "Barua");
            string user, pwd;
            Console.WriteLine("Enter UserName   ");
            user = Console.ReadLine();
            Console.WriteLine("Enter Password   ");
            pwd = Console.ReadLine();
            string result;
            userData.TryGetValue(user, out result);
            if (pwd.Equals(result))
            {
                Console.WriteLine("Correct Credentials...");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
        }
    }
}
