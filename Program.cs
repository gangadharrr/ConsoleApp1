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

namespace ConsoleApp1
{
    /*In Nico Cipher, encoding is done by creating a numeric key and assigning each letter position of the message with the provided key.

    Create a function that takes two arguments, key and message, and returns the encoded message.

    There are some variations on the rules of encipherment.One version of the cipher rules are outlined below:

    message = "mubashirhassan"
    key = "crazy"

    nicoCipher(message, key) ➞ "bmusarhiahass n"
    Step 1: Assign numbers to sorted letters from the key:

    "crazy" = 23154
    Step 2: Assign numbers to the letters of the given message:

    2 3 1 5 4
    ---------
    m u b a s
    h i r h a
    s s a n
    Step 3: Sort columns as per assigned numbers:

    1 2 3 4 5
    ---------
    eMessage = "bmusarhiahass n"
    Examples
    NicoCipher("mubashirhassan", "crazy") ➞ "bmusarhiahass n"

    NicoCipher("edabitisamazing", "matt") ➞ "deabtiismaaznig "

    NicoCipher("iloveher", "612345") ➞ "lovehir    e"
    Notes
    Keys will have alphabets or numbers only.*/

    public class Program
    {
        
        public static string NicoCipher(string Message, string KeyToEncrypt)
        {
            Dictionary <Tuple<string, int>, int> ValueOfChars= new Dictionary <Tuple<string, int>, int> ();
            List<Tuple<string,int>>KeyInChars=new List<Tuple<string, int>>();
            int _Index = 1; 
            foreach (char Character in KeyToEncrypt)
            {
                KeyInChars.Add(new Tuple<string,int>(Character.ToString(),_Index));
                _Index++;
            }
            KeyInChars.Sort();
            _Index = 1;
            foreach (var tuple in KeyInChars)
            {   
                ValueOfChars.Add(tuple,_Index); 
                _Index++;
            }
            var SequenceOfKey= new List<int>();
            _Index = 1;
            foreach (char Character in KeyToEncrypt)
            {
                SequenceOfKey.Add(ValueOfChars[new Tuple<string, int>(Character.ToString(),_Index)]);
                _Index++;
            }
            int NumberOfRows=Message.Length%KeyToEncrypt.Length==0?(Message.Length/KeyToEncrypt.Length): (Message.Length / KeyToEncrypt.Length)+1;
            Dictionary <int,List<string>> EncrytionMatrix=new Dictionary <int,List<string>>();

            int _Index1 = 0;
            for (_Index = 0; _Index < NumberOfRows; _Index++)
            {   
                foreach (int i in SequenceOfKey)
                {
                    if (EncrytionMatrix.ContainsKey(i))
                    {
                        if(Message.Length-1>= _Index1)
                            EncrytionMatrix[i].Add(Message[_Index1].ToString());
                        else
                            EncrytionMatrix[i].Add(" ");
                    }
                    else
                    {
                        EncrytionMatrix.Add(i, new List<string>());
                        if (Message.Length - 1 >= _Index1)
                            EncrytionMatrix[i].Add(Message[_Index1].ToString());
                        else
                            EncrytionMatrix[i].Add(" ");
                        
                    }
                    _Index1++;
                }
            }
       
            SequenceOfKey.Sort();
            string Output = "";
            for (_Index = 0; _Index < NumberOfRows; _Index++)
            {
                foreach (int i in SequenceOfKey)
                {
                    Output += EncrytionMatrix[i][_Index];
                }
            }

            return Output;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(NicoCipher("iloveher", "612345"));
        }
    }
    
}

