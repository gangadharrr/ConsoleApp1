using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;

/*Write a C# Sharp program to check if a string 'ok' appears in a given string. 
 * If it appears return a string without 'ok' otherwise return the original string.*/
namespace ConsoleApp1
{
    internal class Program
    {
       
       public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string[] str=Console.ReadLine().Split("ok");
            while(string.Join("", str).Contains("ok"))
            { 
                string temp = string.Join("", str);
                str = temp.Split("ok");
            }
            Console.WriteLine(string.Join("", str));
        }    
    }
}
