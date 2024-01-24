using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(0,0);
            Point p2 = new Point(0,2);

            Point.LengthPoints(p1,p2);

            Console.WriteLine(Point.Count);

        }
    }
}