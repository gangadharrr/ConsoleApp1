using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {

        public struct Triangle
        {
            public int side1;
            public int side2;
            public int side3;
            public int CalculatePerimeter()
            {
                return this.side1+this.side2+this.side3;
            }
        }
        public static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.side1 = 10;
            triangle.side2 = 20;
            triangle.side3 = 30;
            Console.WriteLine($"Perimeter of Triangle : {triangle.CalculatePerimeter()}");
        }    
    }
}
