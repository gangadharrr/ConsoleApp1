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
            Dictionary <int,int> hashtable = new Dictionary<int,int>();
            Console.Write("Enter elements in Single Line with Space: ");
            List <int> arr= Console.ReadLine().TrimEnd().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToList();
            int count = 0;
            foreach (int i in arr) 
            {
                hashtable[i] = (hashtable.TryGetValue(i, out var value) ? value :0)+1;
            }
            foreach (KeyValuePair<int, int> item in hashtable)
            {
                if(item.Value > 1)count++;
            }
            Console.WriteLine($"No. of Duplicate elements in array are :{count}");
        }    
    }
}
