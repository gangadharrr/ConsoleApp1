using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;
using ConsoleApp1;


namespace ConsoleApp1
{
    delegate int DelegateAdd(int a, int b);
   public class MyClass
    {
        //public 
    }
    internal class Program
    { 
        
        static int Add(int a,int b)
        { 
            //Console.WriteLine(a + b);
            return a + b; }
        static int Sub(int a,int b) { 
            //Console.WriteLine(a - b);

            return a-b; 
        }
        public static void Main(string[] args)
        {
            //MyClass obj = new MyClass();
            //MyClass.DelegateAdd Dsum = Add;
            DelegateAdd Dsub = Sub;
            Dsub += Add;
            //Console.WriteLine(Dsum(2,4));
            //Console.WriteLine(Dsum.Invoke(5,2));
            //Console.WriteLine(Dsub.DynamicInvoke(2, 4));
            //Console.WriteLine(sm);
            // Console.WriteLine(Dsub.Invoke(5,2));
            Delegate[] arr = Dsub.GetInvocationList();
            foreach (Delegate a in arr)
            {
                Console.WriteLine(a.DynamicInvoke(2,7));
            }
            foreach(DelegateAdd a in Dsub.GetInvocationList())
            {
                Console.WriteLine(a(4, 5));

            }




        }
    }
}