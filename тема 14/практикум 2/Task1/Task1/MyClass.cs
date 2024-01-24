using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyClass
    {

        double value1;
        double value2;

        static int count;//поле для общего колличества экземпляров
        int total = count;//поле для подсчета

        public double Value1 { get => value1; set => value1 = value; }
        public double Value2 { get => value2; set => value2 = value; }
        public static int Count { get => count; }

        public MyClass(double value1, double value2)
        {
            this.value1 = value1;
            this.value2 = value2;

            this.total = total + 1;
            count++;
        }

        public MyClass()
        {
            this.value1 = 2;
            this.value2 = 0;

            total++;
            count++;
        }

        static MyClass()
        {
            count = 0; ;
        }

        public void Print()
        {
            Console.Write($"Данные экземпляра №{total}: \n" +
                $"1) Данные строки1 - {value1} \n" +
                $"2) Данные строки2 - {value2} \n");
        }
    }
}
