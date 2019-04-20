using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    class Program
    {
        public static object XmlSerialier { get; private set; }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s == "WRITE")
            {
                string login = Console.ReadLine();
                string password = Console.ReadLine();
                XmlSerializer xs = new XmlSerializer(typeof(string));
                FileStream fs = new FileStream("lp.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                xs.Serialize(fs, "login:" + login + " password:" + password);
                fs.Close();
            }
            else if (s == "READ")
            {
                FileStream fs = new FileStream("lp.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(string));
                string info = xs.Deserialize(fs) as string;
                Console.WriteLine(info);
            }
            else
            {
                return;
            }
            Console.ReadKey();
        }
    }
}
