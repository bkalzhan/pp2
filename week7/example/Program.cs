using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace example
{
    [Serializable]
    class bekzat
    {
        public string name { get; set; }
        public int number { get; set; }

        public bekzat()
        {


        }

        public bekzat(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }

    class Program
    {
        static void SR(List<bekzat> thing)
        {
            FileStream fs = new FileStream("thing.xml", FileMode.OpenOrCreate);
            XmlSerializer sr = new XmlSerializer(typeof(List<bekzat>));
            sr.Serialize(fs, thing);
            fs.Close();
        }

        static void DS(List<bekzat> thing)
        {
            FileStream fs = new FileStream("thing.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer ds = new XmlSerializer(typeof(List<bekzat>));
            thing = ds.Deserialize(fs) as List<bekzat>;
            fs.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many times you will create objects of your class?");
            int n = int.Parse(Console.ReadLine());
            List<bekzat> thing = new List<bekzat>();
            for(int i=0; i<n; i++)
            {
                int m;
                string Name = Console.ReadLine();
                Random random = new Random();
                m = random.Next(1, 100);
                bekzat bekzat = new bekzat(Name, m);
                thing.Add(bekzat);
                Console.WriteLine("Name:" + Name + ", number:" + m);
            }
            SR(thing);
            DS(thing);
            Console.ReadKey();
        }
    }
}
