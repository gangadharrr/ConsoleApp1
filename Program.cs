using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;

/*Write a C# Sharp program to exchange the first and last characters 
    in a given string and return the new string*/
namespace ConsoleApp1
{
    internal class Program
    {
       
       public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str=Console.ReadLine();
            char[] ch = str.ToCharArray();
            char temp = ch[ch.Length-1];
            ch[str.Length - 1] = ch[0];
            ch[0] = temp;
            Convert.ToString(ch);
            Console.WriteLine(ch);




        }    
    }
}
