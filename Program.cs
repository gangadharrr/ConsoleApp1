using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            string s1 = "    Hello";
            string s2 = "Hello    ";
            string s3 = "hello";
            Console.WriteLine(s1+" "+s2.Substring(2)+s2.Substring(0,2));
            Console.WriteLine(string.Concat(s1,s2));
            Console.WriteLine(s1.TrimEnd()+s2.TrimStart());
            Console.WriteLine(s1.TrimStart()+s2.TrimEnd());
            Console.WriteLine(s1.Trim()+s2.Trim());
            Console.WriteLine(string.Compare(s1,s2));
            Console.WriteLine(string.Compare(s2,s1));
            Console.WriteLine(string.Compare(s1.Trim(),s2.Trim()));
            Console.WriteLine(string.Compare(s1.Trim(),s3,false));
            Console.WriteLine(string.Compare(s3,s1.Trim(),false));
            Console.WriteLine(string.Compare(s3,s1.Trim(),true));
            Console.WriteLine(string.Compare(s3,s1.Trim(),StringComparison.Ordinal)); //return the difference b/w ascii values
            Console.WriteLine(s1.Trim().Equals(s2.Trim()));
            Console.WriteLine(s1.Trim().Equals(s3,StringComparison.Ordinal));
            Console.WriteLine(s1.Trim().Equals(s3,StringComparison.OrdinalIgnoreCase));
            Console.Write("Enter Name: ");
            Console.WriteLine($"Hi! {Console.ReadLine()}");
            string word = "Hello$world$test";
            string [] op=word.Split('$');
            foreach(string s in op) Console.WriteLine(s);
        }    
    }
}
