using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Draw();

            ConsoleKeyInfo keyInfo;
            while (true)
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    car.Move(0, -1);
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    car.Move(0, 1);
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    car.Move(1, 0);
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    car.Move(-1, 0);
                }
                Console.Clear();
                car.Draw();
            }
        }
    }
    class Car
    {
        public List<Point> body;
        public ConsoleColor color;
        public string sign;

        public Car()
        {
            body = new List<Point>() { new Point(1, 1), new Point(1, 2), new Point(2, 1), new Point(2, 2) };
            color = ConsoleColor.Blue;
            sign = "o";
        }


        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

        public void Move(int dx, int dy)
        {
            for (int i = 0; i < body.Count; i++)
            {
                body[i].x = body[i].x + dx;
                body[i].y = body[i].y + dy;
            }
        }
    }
    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
