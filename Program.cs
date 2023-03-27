using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;


namespace ConsoleApp1
{


    public class Car
    {
        internal void MaxSpeed(int speed)
        {
            int MaxSpeed = speed;
            Console.WriteLine(MaxSpeed);

        }
        public void ABS()
        {
            Console.WriteLine("ABS is applied");
        }
    }

    public class Volvo : Car
    {
        public void Test()
        {
            Console.WriteLine("In Volvo car");
        }
        public void ABS()
        {
            Console.WriteLine("ADvanced Volvo aBS");
        }


    }
    public class VolvoSports : Volvo
    {
        public void Sportmethod()
        {
            Console.WriteLine("This is sport mode");
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {


            var Volvo = new VolvoSports();
            Volvo.MaxSpeed(40);
            Volvo.ABS();
            Volvo.Test();
            Volvo.Sportmethod();


        }
    }
}
