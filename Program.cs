using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;


namespace ConsoleApp1
{
    abstract public class AbstractClass
    {
        public void methodAdd(int a, int b)
        { a++; b++; }   
    }
    abstract public class AbstractClassWithMethod
    {
        abstract public void method(int a, int b);
        public void methodAdd(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
    public class Myclass : AbstractClassWithMethod 
    {
         public override void method(int a,int b)
        { Console.WriteLine(a+b); } 
        
    }
    //public class Myclass:AbstractClass
    //{

    //}
    internal class Program
    {

        static void Main(string[] args)
        {
            Myclass mc = new Myclass();
            mc.method(1, 2);
            mc.methodAdd(1, 2);
           
        }
    }

    
}
