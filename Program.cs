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
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Text;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;
using static Azure.Core.HttpHeader;
using System.Reflection.Metadata;
using Microsoft.IdentityModel.Tokens;

namespace ConsoleApp1
{
    public class Student
    {
        public int id { set; get; }
        public string name { set; get; }
        public int age { set; get; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
           /* List <string> Names=new List<string>() { "Gangadhar","Ashwin","Arjun","karan"};
            var Query1=from name in Names select name;
            var Query2 = Names.ToList();
            foreach(var name in Query1)
            {
                Console.WriteLine(name);
            }
            foreach(var name in Query2)
            {
                Console.WriteLine(name);
            }*/
            List <Student> students = new List<Student>()
            { 
                new Student(){ id=1,name="Gangadhar",age=20},
                new Student(){ id=2,name="Aswin",age=21},
                new Student(){ id=3,name="Arjun",age=24},
                new Student(){ id=4,name="Karan",age=23}
            };/*
            var Query3=from student in students where(student.age>=21) select student.name;
            foreach( var studentName in Query3)
            {
                    Console.WriteLine(studentName);
            }
            var Query4=students.Where(x=>x.age>=21).Select(x=>x.name);
            foreach (var studentName in Query4)
            {
                Console.WriteLine(studentName);
            }
            List<List<int>> nestedList = new List<List<int>>() {
                new List<int>(){ 1,2,3,4,5},
                new List<int>(){ 7,8,9,10}


            };
            var Query5=nestedList.SelectMany(x=>x.Where(y=>(y&1)==0));
            foreach( var nestedName in Query5)
            { Console.WriteLine(nestedName); }
            List<object> listOfObjects=new List<object>()
            {
                1,"heelo",3.6,'e',2.5,2,4,"world","welcome"
            };  
            var Query6=listOfObjects.OfType<int>().ToList().OrderBy(a=>-a);
            foreach (var item in Query6)
            {
                Console.WriteLine(item);
            }
            var Query7= from obj in listOfObjects where obj is int orderby obj select obj;
            (from obj in listOfObjects where obj is int select obj).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();
            foreach (var item in Query7)
            {
                Console.WriteLine(item);
            }
            listOfObjects.Reverse();
            foreach(var item in listOfObjects)
            {
                Console.WriteLine(item);
            }*/

            List<int> listOfIntegers = new List<int>() { 1, 2, 3, 4, 5,10, 3,4,5 };
            listOfIntegers.Take(3).ToList().ForEach(i => Console.WriteLine(i));
            listOfIntegers.TakeWhile(i=>i<10).ToList().ForEach(i => Console.WriteLine(i));
            listOfIntegers = listOfIntegers.ConvertAll(a => a * 10);
            Console.WriteLine($"{string.Join(",", listOfIntegers)}");
            students.Select(x => x.name).Distinct().ToList().ForEach(x => Console.WriteLine(x));
            students.DistinctBy(x => x.name.Length).Select(x => x.name).ToList().ForEach(x => Console.WriteLine(x));
            students.Select(x => x.age).Except(listOfIntegers).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"{string.Join(",", listOfIntegers.ConvertAll(a => Convert.ToChar(a) + 0.2))}");

        }
    }
    
}

