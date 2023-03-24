using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
       
       public static void Main(string[] args)
        { 
            Dictionary <int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "a");
            dict.Add(2, "b");
            dict.Add(3, "c");
            dict.Add(4, "d");
            dict.Add(5, "e");
            dict.Add(6, "f");
            dict.Add(7, "x");
            Dictionary <int,int> dict1 = new Dictionary<int,int>();

            Console.WriteLine(dict1.GetValueOrDefault(8));
            foreach(KeyValuePair<int,string> kvp in dict) 
            {
                if(kvp.Value == "a")
                {
                    dict[kvp.Key] = "A";
                }
            }
            foreach(var item in dict.OrderBy(x=>x.Value))
            {
                Console.WriteLine(item);
            }

            foreach(var item in dict)
            {
                if(item.Value == "x") 
                {
                    dict.Remove(item.Key);
                }
            }
            foreach(KeyValuePair<int,string> kvp in dict) 
            {
                Console.WriteLine($"[{kvp.Key},{kvp.Value}]");
            }
  
        }    
    }
}
