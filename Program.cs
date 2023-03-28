using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;
using ConsoleApp1;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    delegate int DelegateAdd(int a, int b);
    delegate void Print(string s);
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

            ////Anonymous Method
            //DelegateAdd Dsm=new DelegateAdd(delegate(int a,int b) { return  a + b; });
            //Console.WriteLine(Dsm(2,4));
            //Print print = delegate (string s) { Console.WriteLine(s); };
            //print("Hello");

            ////Lambda Epressions
            //DelegateAdd add = (num1, num2) => num1 + num2;
            //Console.WriteLine(add(2,30));
            //Print p = (num2) => Console.WriteLine(num2);
            //p("Hi");
            //var mul = (int num1, int num2) => num1 * num2;
            //Console.WriteLine(mul(2,30)); 
            //mul+= (int num1, int num2) => num1 + num2;
            //foreach(Delegate a in mul.GetInvocationList()) 
            //{
            //    Console.WriteLine(a.DynamicInvoke(2,3));
            //}

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var square = (int n) => { return n * n; };

            foreach (int num in nums)
            {
                Console.WriteLine(square(num));
            }
            List<int> nums1 = nums.FindAll(n=>(n&1)==0);
            nums1.ForEach(x => Console.Write(x+" "));
            Console.WriteLine();
            List<string> strings = new List<string>() { "hi", "Hello", "xyz", "abc" };
            Console.WriteLine($"[{string.Join(", ",strings.OrderBy(x=>x).ToList())}]");
            Dictionary <int, int[]> dict=new Dictionary<int, int[]>()
            {
                { 99,new int[]{3,2} },
                {1,new int[]{2,4} },
                {45,new int[]{3,5 } },
                { 20,new int[]{2,3 } }
            };
            foreach (var k in dict.OrderBy(x => -x.Value[1]).OrderBy(x => x.Value[0]))
            {
                Console.WriteLine($"[{string.Join(",",k.Value)}]");
            }
            Console.WriteLine(dict[99][1].CompareTo(dict[99][0]));
        }
    }
}