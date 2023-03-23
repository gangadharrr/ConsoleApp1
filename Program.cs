using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
       /* public static void Main(string[] args)
        {
            Console.Write("No. CommonBullets :");
            int co = Convert.ToInt32(Console.ReadLine());
            int HeroBullets = co;
            Console.WriteLine();
            int VillanBullets = co;
            Console.WriteLine($"Time T  Hero Bullets VillanBullets");
            int i = 0;
            while (HeroBullets > 0 || VillanBullets > 0)
            {
                Console.WriteLine($"  {i}           {HeroBullets}            {VillanBullets}      ");
                i++;
                if (HeroBullets > 0)
                    HeroBullets--;
                if (VillanBullets > 0)
                    VillanBullets -= 3;
            }
        }*/

       public static void Main(string[] args)
        {
            Console.Write("No. HeroBullets :");
            int HeroBullets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("No. VillanBullets :");
            int VillanBullets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Time T  Hero Bullets VillanBullets");
            int i = 0;
            while (HeroBullets > 0&& VillanBullets>0)
            {
                Console.WriteLine($"  {i}           {HeroBullets}            {VillanBullets}      ");
                i++;
                if(HeroBullets>0)
                    HeroBullets--;
                if (VillanBullets > 0)
                    VillanBullets -= 3;
            }
            Console.WriteLine(HeroBullets>VillanBullets?"!!!! Hero Wins!!!!": "!!!! Villan Wins !!!!");

        }    
    }
}
