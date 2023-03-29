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
        public static string path = "D:/Async.txt";
        public static FileStream file = new FileStream(path, FileMode.OpenOrCreate);
        public static StreamWriter streamWriter = new StreamWriter(file);
        public static async void FirstMethod()
        {
            Console.WriteLine("First Method Started");
            Task.Delay(3000);
            streamWriter.Close();
            file.Close();
            Console.WriteLine("First Method Ending");
        }
        public static async void SecondMethod()
        {
            Console.WriteLine("Second Method Started");
            streamWriter.Write("Hello hi xyz");
            Console.WriteLine("Second Method Ending");
        }

        public static void Main(string[] args)
        {
            
            FirstMethod();
            SecondMethod();
            Console.ReadLine();

        }
    }
}