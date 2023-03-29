using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        async Task<int> a()
        {
            int number = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Executing method(a)");
                    number++;
                }
            });

            Console.WriteLine("In a");
             await Task.Delay(3000);
            Console.WriteLine("End a");
            return number;
        }

        async Task b()
        {
            Console.WriteLine("In b");
            // await Task.Delay(5000);
            Console.WriteLine("End b");
        }

        async Task c(int number)
        {
            Console.WriteLine("Number from method(A): " + number);
            Console.WriteLine("In c");
            await Task.Delay(5000);
            Console.WriteLine("End c");
        }


        static async Task Main(string[] args)
        {
            Program obj = new Program();
            var task1 = obj.a();
            var task2 = obj.b();
            int number = await task1;
            var task3 = obj.c(number);
            // Task.WaitAll(task1,task2);
            Console.ReadKey();

        }
    }
}