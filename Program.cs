using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;


namespace ConsoleApp1
{
    public class Marks
    {
        public float total_marks;
        public string grade;
        public int no_subs;
        public float percentage;
        public Marks(float total_marks,int no_subs)
        {
            this.total_marks = total_marks;
            this.no_subs = no_subs;
        }
        public void percentagecal()
        {
            percentage =total_marks/no_subs;
        }
    }
    public class Student
    {
        string name;
        int age;
        string rollno;
        int dept_id;
        Marks M;
        public Student(string name, int age, string rollno, int dept_id,Marks M)
        {
            this.name = name;
            this.age = age;
            this.rollno = rollno;
            this.dept_id = dept_id;
            this.M = M;
        }
        public void Display()
        {
            M.percentagecal();
            Console.WriteLine($"Name: {name},\nAge: {age},\nRollNO: {rollno}\nMarks: {M.total_marks},\nPercentage: {M.percentage}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Marks m = new Marks(350, 5);
            
            Student s = new Student("Gangadhar",20,"19s115762",2002,m);
            s.Display();
            

           
   
            

        }
    }
}
