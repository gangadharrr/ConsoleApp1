using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;


namespace ConsoleApp1
{

    sealed class SealedClass
    {

        // Calling Function
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Printer {
 
    // Display Function for
    // Dimension printing
    public virtual void show()
    {
        Console.WriteLine("display dimension : 6*6");
    }
 
    // Display Function
    public virtual void print()
    {
        Console.WriteLine("printer printing....\n");
    }
}
 
// inheriting class
    class LaserJet : Printer {
 
        // Sealed Display Function
        // for Dimension printing
        sealed override public void show()
        {
            Console.WriteLine("display dimension : 12*12");
        }
 
        // Function to override
        // Print() function
        override public void print()
        {
            Console.WriteLine("Laserjet printer printing....\n");
        }
    }
 
// Officejet class cannot override show
// function as it is sealed in LaserJet class.
    class Officejet : LaserJet {
 
        // can not override show function or else
        // compiler error : 'Officejet.show()' :
        // cannot override inherited member
        // 'LaserJet.show()' because it is sealed.
        override public void print()
        {
            Console.WriteLine("Officejet printer printing....");
        }
    }
    internal class Program
    {

        // Main Method
        static void Main(string[] args)
        {

            // Creating an object of Sealed Class
            SealedClass slc = new SealedClass();

            // Performing Addition operation
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
           
            Printer p = new Printer();
            p.show();
            p.print();

            Printer ls = new LaserJet();
            ls.show();
            ls.print();

            Printer of = new Officejet();
            of.show();
            of.print();
            
        }
    }

    
}
