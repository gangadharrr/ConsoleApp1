using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    public class Class1<T>
    { 
        public Class1(T message) 
        {
            Console.WriteLine(message);
        }
       
    }
    public class Class2
    {
        public void MyMethod<T>(T message)
        {
            Console.WriteLine(message);
        }
    }

    internal class Program
    { 
        public static void Main(string[] args)
        {   //Generic Class
            Class1 <string> gc=new Class1<string>("hello");
            Class1 <int> gc1=new Class1<int>(25);
            Class1<float> gc2 = new Class1<float>(25.1f);
            Class1<char> gc3 = new Class1<char>('$');
            System.Console.WriteLine();
            //Generic Method
            Class2 gen2 = new Class2();
            gen2.MyMethod("Hello");
            gen2.MyMethod(25);
            gen2.MyMethod(25.1);
            gen2.MyMethod('$');
            //List
            var list1=new List<string>();
            var list2=new List<string>();
            list1.Add("sunday");
            list1.Add("monday");
            list1.Add("tuesday");
            list1.Add("wednesday");
            list1.ForEach(x => list2.Insert(0,x));
            list1.ForEach(x=>Console.Write(x+" "));
            System.Console.WriteLine("\n");
            list2.ForEach(x=>Console.Write(x+" "));
            System.Console.WriteLine("\n");

            //Hashset
            var hashset1 = new HashSet<int>() {1,2,3,3,4,4,5,6};
            hashset1.ToList().ForEach(x => Console.Write(x + " "));
            System.Console.WriteLine("\n");

            //Sortedset
            SortedSet<int> sortedset1 =new SortedSet<int>() {9,23,7,5,3,6,1,7,0,2};
            SortedSet<String> sortedset2 =new SortedSet<string>() {"b","c","a","abc","c","b"};
            sortedset1.ToList().ForEach(x => Console.Write(x + " "));
            System.Console.WriteLine("\n");
            sortedset2.ToList().ForEach(x => Console.Write(x + " "));
            System.Console.WriteLine("\n");

            //Stack
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Pop();
            stack1.Push(5);
            stack1.Push(6);
            stack1.ToList().ForEach(x => Console.Write(x + " "));
            System.Console.WriteLine("\n");
            Console.WriteLine(stack1.Peek());
            Console.WriteLine(stack1.Pop()); //pops and return value
            Console.WriteLine(stack2.TryPeek(out int item));

            //Queue
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("A");
            queue1.Enqueue("B");
            queue1.Enqueue("C");
            queue1.Enqueue("B");
            queue1.ToList().ForEach(x => Console.Write(x + " "));


        }    
    }
}
