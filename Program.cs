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
        
        private void Print(String args)
        { 
            Console.WriteLine(args);
        }
        private void Print(int[] args)
        { 
            Console.WriteLine($"[{string.Join(", ",args)}]");
        }
        private void Print(String[] args)
        {
            Console.WriteLine($"[{string.Join(",\n", args)}]");
        }
        private void Print(string fname,string lname)
        {
            Console.WriteLine( $"{{\n\sFirstname: {fname}\n\sLastname: {lname}\n}}");
        }
       
        static void Main(string[] args)
        {
            Program ps = new Program();

            int[] arr = {1,2,3,4,5};
            string[] arr1 = { "monday", "tuesday" ,"wednesday","thursday"};


           

            ps.Print("Hello");
            ps.Print(arr);
            ps.Print(arr1);
            ps.Print("Gangadhar", "C");
   
            

        }
    }
}
