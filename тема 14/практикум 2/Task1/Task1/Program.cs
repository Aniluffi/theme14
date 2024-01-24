using System.Drawing;
using Task1;

 class Pro
{
    public static void Main(string[]args) 
    {
        MyClass cl1 = new MyClass();//#1
        MyClass cl2 = new MyClass(3,5);//#2
        MyClass cl3 = new MyClass(1,4);//#3
        MyClass cl4 = new MyClass(6,3);//#4

        cl4.Print();//выхываем №4
        cl3.Print();//вызываем №3

        Console.WriteLine(MyClass.Count);//общее колличество
    }
}

