using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace AttributeExample
{
    public class Demo
    {

        public void Show()
        {
            Console.WriteLine("From Show Method...");
        }

        public void SHOW()
        {
            Console.WriteLine("From SHOW Method...");
        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.Show();
            demo.SHOW();
        }
    }
}
