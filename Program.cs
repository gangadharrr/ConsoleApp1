using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;


namespace ConsoleApp1
{
    public interface Iparent
    {
        public void show(int[] ar);
        public void calculate(int age);
        public void display(string name)
        {
            Console.WriteLine(name);
        }

    }
    public class Parent : Iparent 
    {  
        public void show(int[] arr)
        {
            Console.WriteLine($"[{string.Join(", ",arr)}]");
        }
        public void calculate(int age) 
        {
            if(age < 18 )
            {
                Console.WriteLine("underage");
            }
            else 
            {
                Console.WriteLine("Eligible");
            }
        }
        
}

    internal class Program
    {

        static void Main(string[] args)
        {
            Parent mc = new Parent();
            Iparent p= new Parent();
            int[] arr = { 1,2,3,4,5};
            mc.show(arr);
            mc.calculate(17);
            p.display("Gangadhar C");
           
        }
    }

    
}
