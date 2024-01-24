using ConsoleApp1;

class Program
{ 
    public static void Main(string[] args)
    {
        //Point p1 = new Point(10,1);
        //Point p2 = new Point(-1,1);
        //Point p3 = new Point(3,-4);
        //Point p4 = new Point(3,4);
        //Point p5 = new Point(1,-6);
        //Point p6 = new Point(0,0);
        //Point p7 = new Point(0,0);
        //Point p8 = new Point(0,0);
        //Point p9 = new Point(0,0);
        //Point p10 = new Point(0,0);
        //Point p11 = new Point(0,0);
        //Point p12 = new Point(0,0);
        //Point p13 = new Point(0,0);
        //Point p14 = new Point(0,0);
        //Point p15 = new Point(0,0);
        //Point p16 = new Point(0,0);
        //Point p17 = new Point(0,0);

        Point[] points = new Point[5];

        for (int i = 0;i < points.Length;i++)
        {
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            points[i] = new Point(x,y);

            if (i == points.Length - 1) Point.PrintCountPoint();
        }
        
    }
}