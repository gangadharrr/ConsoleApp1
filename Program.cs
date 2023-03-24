using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
       
       public static void Main(string[] args)
        {  
            var myLinkedList=new LinkedList<int>();
            myLinkedList.AddLast(2);
            myLinkedList.AddLast(2);
            myLinkedList.AddLast(2);
            myLinkedList.AddLast(2);
           
            LinkedListNode <int> node1=myLinkedList.Find(2);
            myLinkedList.AddBefore(node1, 66);
            LinkedListNode<int> node2 = myLinkedList.FindLast(2);
            myLinkedList.AddBefore(node2, 66);
            Console.WriteLine($"{string.Join(" -> ", myLinkedList)}");

            for (LinkedListNode<int> node = myLinkedList.First; node != null;node = node.Next)
            { 
                if(node.Value==2)
                {
                    myLinkedList.AddBefore(node, 99);
                }
                

            }

            Console.WriteLine($"{string.Join(" -> ",myLinkedList)}");
            
  
        }    
    }
}
