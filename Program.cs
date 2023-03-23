using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    { 
        public void PrintArray(int [] arr)
        {
            Console.Write("[");
            foreach (int i in arr) Console.Write(i + ",");
            Console.WriteLine("]");
        }
        public static void PrintArray(String [] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
        public static void Main(string[] args)
        {
            //1d array
            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            /*for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for(int i=0;i<11;i++)
            {//array out of bound exception
                Console.WriteLine(arr[i]);
            }
            foreach(int i in arr)
            { 
                Console.WriteLine(i); 
            }
            
            Program ps = new Program();
            ps.PrintArray(arr);
            string[] arr2 = { "HI", "Hello", "Greetings" };
            Console.WriteLine("["+string.Join(", ", arr2)+"]");
            PrintArray(arr2);
           //2dArray
            int[,] a1 = { {1,2,3},{4,5,6 } };
            int[,] a2 = new int[2, 3];
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    a2[i, j] = a1[i,j];
                    Console.Write(a2[i,j]+$"[{i},{j}] ");
                }
                Console.WriteLine();
            } 
            int[,,] a3 = {
                            {
                                {1,2},
                                {4,5}
                            },
                            {
                                {7,8},
                                {10,11}
                            }
                         };
            //arr.GetLength(i|j|k); i=0 j=1 k=3 for 3D

            for (int i = 0; i < a3.GetLength(0); i++)
            {
                for(int j=0; j < a3.GetLength(1); j++)
                {
                    for (int k = 0; k < a3.GetLength(2); k++)
                    {
                        Console.Write(a3[i, j, k] + $"[{i},{j},{k}] ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }*/
            //jagged array
            int[][] a4=new int[2][];
            a4[0] =new int[] {1,2,3,4};
            a4[1] = new int[] { 5,6,7,8 };
            for(int i=0; i<a4.Length; i++) { 
            
                    Console.WriteLine($"[{string.Join(",",a4[i])}]");
            }
        }    
    }
}
