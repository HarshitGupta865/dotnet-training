using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    [Serializable]
    class Tutorial
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\Learning Dotnet\Day 4\SerializeExample.txt", FileMode.Create, FileAccess.Write);

            // Serialization
            formatter.Serialize(stream, obj);
            stream.Close();

            // Dserialization
            stream = new FileStream(@"D:\Learning Dotnet\Day 4\SerializeExample.txt", FileMode.Open, FileAccess.Read);
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
        }
    }
}