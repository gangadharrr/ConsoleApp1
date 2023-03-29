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

namespace ConsoleApp1
{
   public class Student
    {
        public string Name;
        public string Department;
        public int Age;
        public int Id;
        
        public Student(string Name,string Department,int Age,int Id)
        { 
            this.Name = Name;
            this.Department = Department;
            this.Age = Age;
            this.Id = Id;
        }
    }
    internal class Program
    {
        public int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public delegate bool check(int a);
       public int Counting(int[] arr, Func<int,bool> lambda)
        {
            int count = 0;
            foreach(int a in arr) 
            {
                if(lambda(a))
                count++;
            }

            return count;
        }
        public static void Main(string[] args)
        {
           // List<Student> students = new List<Student>()
           //{
           //    new Student("Gangadhar","CSE",20,39110202),
           //    new Student("Rahul","CSE",22,39110222),
           //    new Student("Vivek","IT",21,39130292),
           //    new Student("Uday","EEE",25,39150212),
           //    new Student("Jyothi","ECE",23,39140220),
           //    new Student("Akhil","MECH",27,39130501)
           //};
           // students.Sort((x, y) => x.Age.CompareTo(y.Age));
           // students.ForEach(x => Console.WriteLine($"[{x.Name},{x.Age},{x.Department},{x.Id}]"));
           // Console.WriteLine();

           // students.Sort((x, y) => x.Id - y.Id);
           // students.ForEach(x => Console.WriteLine($"[{x.Name},{x.Age},{x.Department},{x.Id}]"));
           // Console.WriteLine();

           // foreach (Student student in students.FindAll(x => x.Age < 25 && x.Department.Equals("CSE")))
           //     Console.WriteLine($"[{student.Name},{student.Age},{student.Department},{student.Id}]");
           // if (students.All(x => x.Age < 25))
           // {
           //     Console.WriteLine("All students are under 25");
           // }
           // else
           // {
           //     Console.WriteLine("All students are not under 25");
           // }
           // var res = (int a, int b) =>
           // {
           //     int total = a + b;
           //     return total;
           // };
           // Console.WriteLine(res(2, 3));
           // Console.WriteLine();
            Program ps = new Program();
            check even= (x) => (x & 1) == 0;
            Console.WriteLine(ps.Counting(ps.arr,(int x) => (x & 1) == 0));

            Action<string> ActionDelegate = (msg) => Console.WriteLine(msg);// can only used for statements
            Func<int, int, int> FuncAdd = (a, b) => { Console.WriteLine(a + b); return a + b; };
            int val = FuncAdd(5, 6);
            Func<double> pi = () => 3.14;
            Console.WriteLine(pi());
            // Only return boolean
            // only accepts 1 input parameter
            Predicate<int> evenCheck = (a) => (a&1)== 0;
            Console.WriteLine(evenCheck(2));


            Func<int, int> fact = null;
             fact=(x) => 
            { 
                if (x == 0 || x == 1) 
                    return 1; 
                else 
                    return x * fact(x - 1); 
            };
            Console.Write(fact(5));



        }
    }
}