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

namespace ConsoleApp1
{

    /*Polymorphism

    A friend of yours wants to create a special calculator.
    He only wants two operations to be handled by that calculator
    i.e. : addition and subtraction.
    The calculator can only accept either 2 numbers or 3 numbers.

    There are two functionalities for this calculator -
    1. Normal -> in this role - the calculator works normally
     - where upon adding the numbers are added,
    while upon subtracting the numbers are subtracted.

    2. Opposite -> in this role - the calculator works opposite
    to the normal role - where upon adding the numbers are subtracted,
     while upon subtracting the numbers are added.
    That friend have approached you for the help, in creating
     such a calculator.*/
    internal class Calculator
    {
        public bool Role = true;
        public Calculator()
        { }
        public Calculator(bool Role)
        {
            this.Role = Role;
        }
        public int Addition(int a, int b)
        {
            return Role ? a + b : a - b;
        }
        public int Addition(int a, int b, int c)
        {
            return Role ? a + b + c : a - b - c;
        }
        public int Subtraction(int a, int b)
        {
            return Role ? a - b : a + b;
        }
        public int Subtraction(int a, int b, int c)
        {
            return Role ? a - b - c : a + b + c;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator normalCalculatorObject = new Calculator(true);
            Calculator oppositeCalculatorObject = new Calculator(false);

            Console.WriteLine("Normal Calculation :-\n");

            Console.WriteLine($"Addition with 2 args: {normalCalculatorObject.Addition(2, 3)}");
            Console.WriteLine($"Addition with 3 args: {normalCalculatorObject.Addition(1, 2, 3)}");

            Console.WriteLine($"Subtraction with 2 args: {normalCalculatorObject.Subtraction(2, 3)}");
            Console.WriteLine($"Subtraction with 3 args: {normalCalculatorObject.Subtraction(2, 3, 4)}\n");
            
            Console.WriteLine("Opposite Calculation :-\n");

            Console.WriteLine($"Addition with 2 args: {oppositeCalculatorObject.Addition(2, 3)}");
            Console.WriteLine($"Addition with 3 args: {oppositeCalculatorObject.Addition(1, 2, 3)}");

            Console.WriteLine($"Subtraction with 2 args: {oppositeCalculatorObject.Subtraction(2, 3)}");
            Console.WriteLine($"Subtraction with 3 args: {oppositeCalculatorObject.Subtraction(2, 3, 4)}");

        }
    }
}