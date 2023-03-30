using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;
using ConsoleApp1;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Data;
using System.Security.Principal;
using System.Transactions;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace ConsoleApp1
{
  /*  Abstraction:

    A company XYZ wants to develop an app which can predict the
    lucky number for a person.
    The name of the app is LuckyNumberPredictor.
    This app consists of a method - upon calling the person gets to know his/her lucky number.
     This method calls another class —> NumberPredictor - which have the formula for
     predicting the lucky number of that person.This approach is done so that no-one else gets
    to know the secret formula for this prediction.

    LuckyNumberPredictor accepts only one argument i.e: date of birth of the person. The formula
    for predicting the lucky number is quite simple -> a person’s lucky number is calculated by rounding off the date of birth to the nearest Fibonacci number.
    Another thought that XYZ company is  having - is to predict unlucky number as well 
    - but for this — for now, they don’t have any formula ready.But they want to have this idea to 
    be stored in - in their NumberPredictor class. The company is asking you to develop this system.*/
   
    abstract class NumberPredictor 
    {
        private protected int SecrectLuckyNumberCalculator(int DateOfBirth)
        {
            return LuckyNumberFormula(DateOfBirth);
        }
        private int LuckyNumberFormula(int N)
        {
            int n1 = 0, n2 = 1; 
            while(n1+n2 < N)
            {
                int temp = n1 + n2;
                n1=n2; 
                n2=temp;
            }
            return n1+n2;
        }
        private protected int SecrectUnuckyNumberCalculator(int DateOfBirth)
        {
            return 0;
        }
        private int UnuckyNumberFormula(int N)
        { 
            return 0;
        }

    }
    internal class LuckyNumberPredictor:NumberPredictor
    {
        public int LuckyNumberCalculator(string DateOfBirth)
        { 
            DateOfBirth=DateOfBirth.Trim().Replace("-"," ").Replace("/"," ");
            return base.SecrectLuckyNumberCalculator(DateOfBirth.Split().Select(x => Convert.ToInt32(x)).ToList()[0]); 
        }

    }

    internal class Program
    {
        internal static void FibonacciNumber(int N)
        {
            int n1 = 0, n2 = 1;
            while (n1 + n2 < N)
            {
                int temp = n1 + n2;
                Console.Write(temp+" ");
                n1 = n2;
                n2 = temp;
            }
           
        }
        public static void Main(string[] args)
        {
            LuckyNumberPredictor lnp = new LuckyNumberPredictor();
            Console.Write("Enter the Date of Birth (dd/mm/yyyy): ");
            int LuckyNumber = lnp.LuckyNumberCalculator(Console.ReadLine().ToString());
            Console.WriteLine($"Your Lucky Number is: {LuckyNumber}");
           // FibonacciNumber(100);
        }
    }
}