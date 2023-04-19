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
    }public class Marks
    {
        public int id { set; get; }
        public int m1 { set; get; }
        public int m2 { set; get; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
          
            List <Student> students = new List<Student>()
            { 
                new Student(){ id=1,name="Gangadhar",age=20},
                new Student(){ id=2,name="Aswin",age=21},
                new Student(){ id=3,name="Arjun",age=24},
                new Student(){ id=4,name="Karan",age=23}
            };
            List <Marks> studentsMarks = new List<Marks>()
            { 
                new Marks(){ id=1,m1=99,m2=25},
                new Marks(){ id=2,m1=29,m2=45},
                new Marks(){ id=3,m1=98,m2=75},
                new Marks(){ id=4,m1=72,m2=65}              
            };
            var query = from std in students
                        join mrks in studentsMarks on std.id equals mrks.id
                        select (std.name, mrks.m1, mrks.m2);
            foreach(var item in query )
            {
                Console.WriteLine(item.name+" "+item.m1+" "+item.m2);
            }
            var query1 = students.Join(studentsMarks, x => x.id, y => y.id, (x, y) => new { x.name, y.m1, y.m2 });
            foreach(var item in query1 )
            {
                Console.WriteLine(item.name+" "+item.m1+" "+item.m2);
            }

        }
    }
    
}

