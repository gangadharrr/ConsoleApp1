using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;

//1) Write a program in C# Sharp to count a total number of duplicate elements in an array.
//2) Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
//3) Write a program in C# Sharp to separate odd and even integers in separate arrays
namespace ConsoleApp1
{
    internal class Program
    {
       
       public static void Main(string[] args)
        {  
            Console.Write("Enter elements in Single Line with Space: ");
            List <int> arr= Console.ReadLine().TrimEnd().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToList();
            List <int> oddList = new List<int>();
            List <int> evenList = new List<int>();
            foreach(var a in arr)
            {
                if((a&1)==1) oddList.Add(a);
                else evenList.Add(a);
            }
            Console.WriteLine($"Odd list:[{string.Join(",",oddList)}]");
            Console.WriteLine($"Even list:[{string.Join(",",evenList)}]");
        }    
    }
}
