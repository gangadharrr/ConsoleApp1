using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;

/*Write a C# Sharp program to create a new string with the last char 
 * added at the front and back of a given string of length 1 or more.*/
namespace ConsoleApp1
{
    internal class Program
    {
       
       public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str=Console.ReadLine();
            str=str.Insert(0, Convert.ToString(str[str.Length - 1]));
            str = str.Insert(str.Length, Convert.ToString(str[str.Length-1]));
            Console.WriteLine(str);
        }    
    }
}
