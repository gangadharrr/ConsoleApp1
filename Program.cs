using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;


/*What is IEnumerable in C#?
What is Constructor Chaining in C#?
Can you use a "this" command within a static method ? Why?
Name some access modifiers available in C#
Why does C# not support multiple inheritances?*/
namespace ConsoleApp1
{
 
    internal class Program
    {
       
       public static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Class2 obj2 = new Class2();
            obj.method2();
        }    
    }
}
