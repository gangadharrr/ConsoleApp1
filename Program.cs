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

namespace ConsoleApp1
{
    public class Program
    {
        /*In this challenge, you have to establish which kind of Poker combination is present in a deck of five cards. Every card is a string containing the card value (with the upper-case initial for face-cards) and the lower-case initial for suits, as in the examples below:
            "Ah" ➞ Ace of hearts
            "Ks" ➞ King of spades
            "3d" ➞ Three of diamonds
            "Qc" ➞ Queen of clubs
            "10c" ➞ Ten of clubs
            There are 10 different combinations. Here's the list, in decreasing order of importance:
            Name	Description
            Royal Flush	A, K, Q, J, 10, all with the same suit.
            Straight Flush	Five cards in sequence, all with the same suit.
            Four of a Kind	Four cards of the same rank.
            Full House	Three of a Kind with a Pair.
            Flush	Any five cards of the same suit, not in sequence.
            Straight	Five cards in a sequence, but not of the same suit.
            Three of a Kind	Three cards of the same rank.
            Two Pair	Two different Pair.
            Pair	Two cards of the same rank.
            High Card	No other valid combination.
            Given an array hand containing five strings being the cards,
            implement a function that returns a string with the name of the highest combination obtained, accordingly to the table above.
            Examples
            PokerHandRanking({ "10h", "Jh", "Qh", "Ah", "Kh" }) ➞ "Royal Flush"
            PokerHandRanking({ "3h", "5h", "Qs", "9h", "Ad" }) ➞ "High Card"
            PokerHandRanking({ "10s", "10c", "8d", "10d", "10h" }) ➞ "Four of a Kind"
        */

        public static string PokerHandRanking(List<string> cards)
        {
            Func<List<string>, bool> Royal_Flush = (List<string> cards) => {
                List<string> ranks = new List<string>{ "A", "K", "Q", "J", "10" };
                foreach(string s in cards)
                {
                    if(!(ranks.Contains(s.Substring(0,s.Length-1))))
                        return false;
                }
                
                string Temp_Suit = cards[0].Substring(cards[0].Length - 1);
                return cards.All(y => y.Substring(y.Length - 1) == Temp_Suit);
            };
            Func<List<string>, bool> Straight_Flush = (List<string> cards) => { 
                Dictionary<string,int> ranks = new Dictionary<string, int>()
                {{ "A" ,1},
                    { "2",2 }, {"3",3 }, {"4",4 }
                    ,{ "5" ,5},{"6" ,6},{"7" ,7},{"8" ,8},{"9" ,9},{"10" ,10},{"J" ,11},{"Q" ,12},{"K",13} };
                cards.Sort((x, y) => ranks[x.Substring(0,x.Length-1)].CompareTo(ranks[y.Substring(0, y.Length - 1)]));
                for (int i= 0;i<cards.Count-1;i++)
                {
                    if (ranks[cards[i].Substring(0, cards[i].Length - 1)]+1 != ranks[cards[i + 1].Substring(0, cards[i + 1].Length - 1)] )
                        return false;
                }
                string Temp_Suit = cards[0].Substring(cards[0].Length - 1);
                return cards.All(y => y.Substring(y.Length - 1) == Temp_Suit);
            };
            Func<List<string>, bool> Four_of_a_Kind = (List<string> cards) => {
                Dictionary <string,int> count= new Dictionary<string,int>();
                foreach (string s in cards)
                {
                    count[s.Substring(0, s.Length - 1)]=count.GetValueOrDefault(s.Substring(0, s.Length - 1))+1;
                }
                foreach(var KeyValPair in count)
                {
                    if(KeyValPair.Value==4)
                        return true;
                }
                return false;
            };
            Func<List<string>, bool> Three_of_a_Kind = (List<string> cards) => {
                Dictionary<string, int> count = new Dictionary<string, int>();
                foreach (string s in cards)
                {
                    count[s.Substring(0, s.Length - 1)] = count.GetValueOrDefault(s.Substring(0, s.Length - 1)) + 1;
                }
                foreach (var KeyValPair in count)
                {
                    if (KeyValPair.Value == 3)
                        return true;
                }
                return false;
            };
            Func<List<string>, bool> Pair = (List<string> cards) => {
                Dictionary<string, int> count = new Dictionary<string, int>();
                foreach (string s in cards)
                {
                    count[s.Substring(0, s.Length - 1)] = count.GetValueOrDefault(s.Substring(0, s.Length - 1)) + 1;
                }
                foreach (var KeyValPair in count)
                {
                    if (KeyValPair.Value == 2)
                        return true;
                }
                return false;
            };
            Func<List<string>, bool> Full_House = (List<string> cards) => {
                return Three_of_a_Kind(cards)&&Pair(cards);
            };
            Func<List<string>, bool> Two_Pair = (List<string> cards) => {
                Dictionary<string, int> count = new Dictionary<string, int>();
                foreach (string s in cards)
                {
                    count[s.Substring(0, s.Length - 1)] = count.GetValueOrDefault(s.Substring(0, s.Length - 1)) + 1;
                }
                int Temp_Counter = 0;
                foreach (var KeyValPair in count)
                {
                    if (KeyValPair.Value == 2)
                        Temp_Counter++;
                }
                return Temp_Counter==2;
            };
            Func<List<string>, bool> Flush = (List<string> cards) => {
                Dictionary<string, int> ranks = new Dictionary<string, int>()
                {{ "A" ,1},
                    { "2",2 }, {"3",3 }, {"4",4 }
                    ,{ "5" ,5},{"6" ,6},{"7" ,7},{"8" ,8},{"9" ,9},{"10" ,10},{"J" ,11},{"Q" ,12},{"K",13} };
                cards.Sort((x, y) => ranks[x.Substring(0, x.Length - 1)].CompareTo(ranks[y.Substring(0, y.Length - 1)]));
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if (ranks[cards[i].Substring(0, cards[i].Length - 1)] + 1 != ranks[cards[i + 1].Substring(0, cards[i + 1].Length - 1)])
                    {
                        string Temp_Suit = cards[0].Substring(cards[0].Length - 1);
                        return cards.All(y => y.Substring(y.Length - 1) == Temp_Suit);
                    }
                }
                return false;
            };
            Func<List<string>, bool> Straight = (List<string> cards) => {
                Dictionary<string, int> ranks = new Dictionary<string, int>()
                {{ "A" ,1},
                    { "2",2 }, {"3",3 }, {"4",4 }
                    ,{ "5" ,5},{"6" ,6},{"7" ,7},{"8" ,8},{"9" ,9},{"10" ,10},{"J" ,11},{"Q" ,12},{"K",13} };
                cards.Sort((x, y) => ranks[x.Substring(0, x.Length - 1)].CompareTo(ranks[y.Substring(0, y.Length - 1)]));
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if (ranks[cards[i].Substring(0, cards[i].Length - 1)] + 1 != ranks[cards[i + 1].Substring(0, cards[i + 1].Length - 1)])
                        return false;
                }
                string Temp_Suit = cards[0].Substring(cards[0].Length - 1);
                return cards.Any(y => y.Substring(y.Length - 1) != Temp_Suit);
            };
            Dictionary<string, Func<List<string>, bool>> Functions = new Dictionary<string, Func<List<string>, bool>>();
            Functions.Add("Royal Flush", Royal_Flush) ;
            Functions.Add("Straight Flush", Straight_Flush) ;
            Functions.Add("Four of a Kind", Four_of_a_Kind) ;
            Functions.Add("Three of a Kind", Three_of_a_Kind) ;
            Functions.Add("Pair", Pair) ;
            Functions.Add("Full House", Full_House) ;
            Functions.Add("Two Pair", Two_Pair) ;
            Functions.Add("Flush", Flush) ;
            Functions.Add("Straight", Straight) ;
            List <string> Sequence = new List<string>() 
            {
                "Royal Flush",
                "Straight Flush",
                "Four of a Kind",
                "Full House",
                "Flush",
                "Straight",
                "Three of a Kind",
                "Two Pair",
                "Pair"
            };
            foreach (var sequence in Sequence)
            {
                if (Functions[sequence](cards))
                    return sequence;
            }
            return "High Card";
        }
       

        public static void Main(string[] args)
        {

            Console.WriteLine(PokerHandRanking(new List<string> { "10s", "10c", "8d", "10d", "10h" }));

        }
    }
    
}