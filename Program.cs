using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
       public class MyException:Exception
        {
            public MyException(string message) : base(message)
            { 
            }
        }
        public static void CheckAge(int age) 
        {
            if (age < 1) 
            {
                throw new MyException("!!Age Cannot Under be One!!");
            }
            if (age >150)
            {
                throw new MyException("!!Age Cannot Above be 150!!");
            }
        }

        public static void Main(string[] args)
        {   int a = 10;
            int b = 5;
            int [] arr  = { 1, 2, 3, 4, 5 };
            try 
            {
                CheckAge(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(a / b);
                Console.WriteLine(arr[2]);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                Console.WriteLine("Don't Divide by Zero");
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
                Console.WriteLine("Try with index in range");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("Finally Block Executed");
            }
            try 
            {
                throw new Exception("A user Exception with throw keyword");
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }    
    }
}
