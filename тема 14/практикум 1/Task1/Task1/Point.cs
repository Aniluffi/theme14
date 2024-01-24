using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Point
    {
        int x;
        int y;

        static int count;

        public static int Count { get => count;  }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

            count++;
        }

        public Point()
        {
            this.x = 1;
            this.y = 0;

            count++;
        }

        static Point()
        {
            count = 0;
        }

        public void Print()
        {
            Console.WriteLine($"x = {x} \n" +
                $"y = {y} \n");
        }


        
        public static void LengthPoints(Point a, Point b)
        {
            Console.WriteLine($"длина между точками = " +
                $"{Math.Round(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y + b.Y, 2)), 2)}");
        }
    }
}
