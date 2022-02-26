using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeEmpList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employ> employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Mani",Basic=94222},
                new Employ{Empno=2,Name="Bhavya",Basic=92242},
                new Employ{Empno=3,Name="Chanpreet",Basic=58864}
            };

            // Serialization
            FileStream fs = new FileStream("d:/Learning Dotnet/Day 4/EmployList.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter binf = new BinaryFormatter();
            binf.Serialize(fs, employList);
            Console.WriteLine("Objects Stored In File...");
            fs.Close();

            //Deserialization
            FileStream fsp = new FileStream("d:/Learning Dotnet/Day 4/EmployList.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Employ> emp = (List<Employ>)formatter.Deserialize(fsp);
            foreach (Employ employ in employList)
            {
                Console.WriteLine(employ);
            }

        }
    }
}
