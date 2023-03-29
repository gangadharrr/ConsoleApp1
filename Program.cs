using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;
using ConsoleApp1;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using System.Reflection;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
   
    internal class Program
    {
        public static async void FirstMethod()
        {

            Console.WriteLine("First Method Started");
            await Task.Delay(7000);
            Console.WriteLine("First Method Ending");
        }
        public static async void SecondMethod()
        {
            Console.WriteLine("Second Method Started");
            await Task.Delay(5000);
            Console.WriteLine("Second Method Ending");
        }
        public static async void ThirdMethod()
        {
            Console.WriteLine("Third Method Started");
            await Task.Delay(3000);
            Console.WriteLine("Third Method Ending");
        
        }

        public static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch calculation =new System.Diagnostics.Stopwatch();
            calculation.Start();
            FirstMethod();
            SecondMethod();
            ThirdMethod();
            calculation.Stop();
            Console.WriteLine(calculation.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}