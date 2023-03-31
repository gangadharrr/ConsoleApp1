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

namespace ConsoleApp1
{
    /*  An event is organized and the following has to happen. 


      The chief guest needs to be picked up from the airport. 
      The stage has to be decorated. 
      The catering team needs to start preparing food
      The transport team needs to drop the food raw materials to the venue before the cooking needs to start. 
      The chief guest's speech needs to be reviewed by the PA
      The venue needs to be checked for security features like bomb threat, etc
      Prize distribution is set to happen at the end of the event so all the prizes that need to be presented should be brought to the venue. 
      The chief guest needs to give the speech. 
      Prizes need to be distributed. 
      Food has to be provided to all participants. 

      Please write a C# program to make use of the Async Programming concepts and write the program so that all 
        of the above happen in a correct order.*/



    internal class Program
    {
        public static async void PickUp()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Cheif Guest has been PickedUp from Airport");
            await Task.Delay(10000);
            Console.WriteLine("Cheif Guest has Arrived At event");
            Console.WriteLine("-----------------------------------");
            SpeechDelivery();
        }
        public static async void Decoration()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Decoration has started at event");
            await Task.Delay(4000);
            SecurityCheck();
            Console.WriteLine("Decoration has complete");
            Console.WriteLine("-----------------------------------");

        }
        public static async Task<string> FoodTransport()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Raw Materials has Picked at Local Store");
            string str = "Raw Materials Acquried Food Preparation Inprogress";
            await Task.Delay(7000);
            Console.WriteLine("Raw Material has Arrived at event");
            Console.WriteLine("-----------------------------------");
            return str;
        }
        public static async void FoodPreparation()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Food Preparation started at event");
            string str =await FoodTransport();
            Console.WriteLine(str);
            await Task.Delay(10000);
            Console.WriteLine("Food Preparation Completed at event");
            Console.WriteLine("-----------------------------------");

        }
        public static async Task<string> SpeechReview() 
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Speech Review Has Started By PA");
            await Task.Delay(2000);
            string str = "Speech has been review";
            Console.WriteLine("Speech Review Has Completd By PA");
            Console.WriteLine("-----------------------------------");
            return str;

        }
        public static async void SecurityCheck()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Security Check Has Started At Event");
            await Task.Delay(4000);
            Console.WriteLine("Security Check Has Completed At Event");
            Console.WriteLine("-----------------------------------");

        }
        public static async void PrizeDistribution()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Prize Distribution Has Started At Event");
            await Task.Delay(2000);
            Lunch();
            await Task.Delay(5000);
            Console.WriteLine("Prize Distribution Has Completed At Event");
            Console.WriteLine("-----------------------------------");

        }
        public static async void SpeechDelivery()
        {
            string str = await SpeechReview();
            Console.WriteLine("***********************************");
            Console.WriteLine("Speech by Chief Guest Has Started");
            Console.WriteLine(str);
            await Task.Delay(5000);
            Console.WriteLine("Speech by Chief Guest Has Ended");
            Console.WriteLine("-----------------------------------");
            PrizeDistribution();
            
        }
        public static async void Lunch() 
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Lunch Has Started At Event");
            await Task.Delay(7000);
            Console.WriteLine("Lunch Distribution Has Completed At Event");
            Console.WriteLine("-----------------------------------");
        }
        public static void Main(string[] args)
        {
            Decoration();
            PickUp();
            FoodPreparation();
            Console.ReadLine();

        }
    }
}