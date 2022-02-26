using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Enter the type of book (novels, academics, sports, gk)");
            string type = Console.ReadLine();
            if(type.Equals("novels"))
            {
                book.novels();
            }
            if (type.Equals("academics"))
            {
                book.academics();
            }
            if (type.Equals("sports"))
            {
                book.sports();
            }
            if (type.Equals("gk"))
            {
                book.gk();
            }
        }
    }
}
