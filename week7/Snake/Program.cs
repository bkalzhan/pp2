using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    public class Car
    {
        public string name;
        public string mark;
        public int yearOfRelease;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }
        public int YearOfRelease
        {
            get
            {
                return yearOfRelease;
            }
            set
            {
                yearOfRelease = value;
            }
        }
        public Car(string name, string mark, int yearOfRelease)
        {
            this.name = name;
            this.mark = mark;
            this.yearOfRelease = yearOfRelease;
        }

        public Car() { }

        public void GetInfo()
        {
            Console.WriteLine(name + " " + mark + " " + yearOfRelease + " ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F2();
            Console.ReadLine();
        }
        public static void F1()
        {
            Car car1 = new Car("Audi", "1", 1998);
            Car car2 = new Car("BMW", "2", 2005);
            Car car3 = new Car("Toyota", "98", 2015);
            Car car4 = new Car("Toyota1", "11", 2017);
            Car car5 = new Car("Toyota2", "98", 2013);
            Car car6 = new Car("Toyota3", "94", 2014);
            Car car7 = new Car("Toyota4", "22", 1999);
            Car car8 = new Car("Toyota5", "74", 2012);
            Car car9 = new Car("Toyota", "68", 2005);
            Car car10 = new Car("Nissan", "45", 1988);

            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);
            cars.Add(car7);
            cars.Add(car8);
            cars.Add(car9);
            cars.Add(car10);

            XmlSerializer xml = new XmlSerializer(typeof(List<Car>));
            FileStream fs = new FileStream("car.xml", FileMode.OpenOrCreate, FileAccess.Write);
            xml.Serialize(fs, cars);
            fs.Close();

        }
        public static void F2()

        {

            XmlSerializer xml = new XmlSerializer(typeof(List<Car>));
            FileStream fs = new FileStream("car.xml", FileMode.OpenOrCreate, FileAccess.Read);
            List<Car> cars = xml.Deserialize(fs) as List<Car>;
            fs.Close();

            cars[0].GetInfo();
        }
    }
}