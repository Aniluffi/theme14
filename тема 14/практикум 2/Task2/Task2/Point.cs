using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp1

{

    class Point

    {
        int y;
        int x;

        static int countOne;
        static int countTwo;
        static int countThri;
        static int countFour;
        static int allCount;

        public Point(int x, int y)

        {
            this.y = y;
            this.x = x;

            if (x > 0 && y < 0) countFour++;
            else if (x > 0 && y > 0) countOne++;
            else if (x < 0 && y > 0) countTwo++;
            else if (x < 0 && y < 0) countThri++;

            allCount++;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"x = {x} \n" +
                $"y = {y} \n");
        }

        public static void PrintCountPoint()
        {
            Console.WriteLine($"Общее колличество точек  = {allCount} \n" +
                $"Колличество точек в 1-ой четверти = {countOne} \n" +
                $"Колличество точек в 2-ой четверти = {countTwo} \n" +
                $"Колличество точек в 3-й четверти = {countThri} \n" +
                $"Колличество точек в 4-ой четверти = {countFour} \n");
        }
    }

}