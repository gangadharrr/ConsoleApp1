using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void modify(int vl)
        {
            vl++;
            Console.WriteLine(vl);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age == 5)
            {
                goto after;
            }
            Console.WriteLine("wlcome");
            return;
        after:
            Console.WriteLine("not");
            Console.WriteLine(age);
            modify(age);
            Console.WriteLine(age);


        }    
    }
}