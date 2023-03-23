using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        public string name="Not Given";
        public int age=0;
        public Program()
        {
            Console.WriteLine("Default Constructor");
        }
        public Program(string name)
        {
            this.name = name;
            Console.WriteLine($"Parametrized Constructor");
        }
        public Program(string name,int age)
        {
            this.name=name;
            this.age = age; 
        }
        ~Program() 
        {
            Console.WriteLine("Destructor has Called");
        }
        public void Display()
        {
            Console.WriteLine($"Name : {name}\nAge: {age}");
        }
        public static void Main(string[] args)
        {
            Program ps = new Program();
            Program ps1 = new Program("Gangadhar");
            Program ps2 = new Program("Gangadhar", 20);
            ps.Display();
            ps1.Display();
            ps2.Display();
            ps2 = null;
            GC.Collect();

        }    
    }
}
