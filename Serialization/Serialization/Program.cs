using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        public static void serilization()
        {
            person p1 = new person("subham", 22, "Bangalore");
            FileStream fs = new FileStream(@"C:\Users\Subham Kumar Ojha\Desktop\serial\Serialization\serial.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, p1);
            fs.Close();
            Console.WriteLine("File is created:");
            Console.ReadLine();
        
    }
        public static void deserialization()
        {
            person per;
            FileStream fs = new FileStream(@"C:\Users\Subham Kumar Ojha\Desktop\serial\Serialization\serial.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            per = (person)formatter.Deserialize(fs);
            string name = per.name;
            int age = per.age;
            string city = per.city;
            fs.Close();
            Console.WriteLine("the name of the person is :");
            Console.WriteLine("age is:");
            Console.WriteLine("City is:");

        }
        static void Main(string[] args)
        {
            serilization();
            deserialization();
            Console.ReadLine();
        } 
    }
}
