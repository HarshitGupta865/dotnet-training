using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArray
{
    internal class Program
    {
        public delegate void LoginAuthentication();
        public static event LoginAuthentication LoginSuccess;
        public static event LoginAuthentication LoginFailure;

        static Dictionary<string, string> userData;

        static Program()
        {
            userData = new Dictionary<string, string>();
            userData.Add("Sachin", "Gupta");
            userData.Add("Rohit", "Malla");
            userData.Add("Anubhav", "Srivasthava");
            userData.Add("Ashwin", "Krishna");
            userData.Add("Tamanna", "Gupta");
        }

        public static void Success()
        {
            Console.WriteLine("Your Credentials are Correct...Nice...");
        }

        public static void Failure()
        {
            Console.WriteLine("Your Credentials are wrong...Try One More Time...");
        }

        public static void ValidateMe(string user, string password)
        {
            string result;
            userData.TryGetValue(user, out result);
            if (result.Equals(password))
            {
                LoginSuccess = new LoginAuthentication(Success);
                LoginSuccess.Invoke();
            }
            else
            {
                LoginFailure = new LoginAuthentication(Failure);
                LoginFailure.Invoke();
            }
        }

        static void Main(string[] args)
        {
            string user, pwd;
            Console.WriteLine("Enter UserName   ");
            user = Console.ReadLine();
            Console.WriteLine("Enter Password  ");
            pwd = Console.ReadLine();
            ValidateMe(user, pwd);
        }
    }
}
