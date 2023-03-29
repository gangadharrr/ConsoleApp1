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
        public static async Task<string> FirstMethod()
        {
            Console.WriteLine("First Method Started");
            await Task.Delay(3000);
             //Task.Delay(3000);// throw error with await
            streamWriter.Close();
            file.Close();
            Console.WriteLine("First Method Ending");
            string msg = "hi this is method 1";
            return msg;
        }
        public static async Task<string> SecondMethod()
        {
            Console.WriteLine("Second Method Started");
            streamWriter.Write("Hello hi xyz");
            Console.WriteLine("Second Method Ending");
            string msg = "hi this is method 2";
            return msg;
        }
        public static async Task<string> ThirdMethod()
        {
            Console.WriteLine("Third Method File Open and Written some text");
            string msg = "third method running";
            return msg;
        }
        public static async Task Main(string[] args)
        {
            Task SmTask1 = FirstMethod();
            Task SmTask2=SecondMethod();
            Task progess=Task.WhenAny(SmTask1, SmTask2);
            //await progess;
            while (true) {
                if (progess.Status == TaskStatus.RanToCompletion)
                {
                    Task SmTask3 = ThirdMethod();
                    break;
                } 
                else
                { 
                    Console.WriteLine("Not Completd");
                }
                Thread.Sleep(2000);
            }
            
            Console.ReadLine();

        }
    }
}