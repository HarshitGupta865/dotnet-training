using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ obj = new Employ();
            obj.empno = 1;
            obj.name = "Harshit";
            obj.basic = 34567;

            //Console.WriteLine(obj);

            // Serialization
            FileStream fs = new FileStream("d:/Learning Dotnet/Day 4/SerializeEx.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter binf = new BinaryFormatter();
            binf.Serialize(fs, obj);
            Console.WriteLine("Employ Object Stored...");
            fs.Close();

            // Deserialization
            FileStream fsp = new FileStream("d:/Learning Dotnet/Day 4/SerializeEx.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Employ obj1 = (Employ)formatter.Deserialize(fsp);
            Console.WriteLine(obj1);
        }
    }
}
