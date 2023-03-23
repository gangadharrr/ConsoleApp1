using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {

        public enum Days
        {
            sunday,monday,tuesday,wednesday,thursday,friday,saturday
        }
        public enum naturalnumbers
        { 
            x=1, y=2, z=3,
        }
        public static void Main(string[] args)
        {
            int a=(int) Days.sunday;
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.Write(Enum.GetName(typeof(Days),i)+" ");
            Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(naturalnumbers)))
                Console.Write(Enum.GetName(typeof(naturalnumbers), i)+" ");
        }    
    }
}
