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
            Console.WriteLine("Message From Method 1");
            string str=await SecondMethod();
            Console.WriteLine( str);
            Console.WriteLine("First Method Ending");
        }
        public static async Task<string> SecondMethod()
        {
            Console.WriteLine("Second Method Started");
            await Task.Delay(7000);
            string msg = "Message from Method 2";
            Console.WriteLine("Second Method Ending");
            return msg;
        }
        public static void ThirdMethod()
        {
            Console.WriteLine("Third Method Started");
     
            Console.WriteLine("Third Method Ending");
        
        }

        public static void Main(string[] args)
        {

            FirstMethod();
            Console.WriteLine("third method calling");
            ThirdMethod();
            
            Console.ReadLine();

        }
    }
}