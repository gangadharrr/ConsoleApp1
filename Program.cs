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

namespace ConsoleApp1
{
    public class Program
    {
        /*    English to Pig Latin Translator

        Pig latin has two very simple rules:

        If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel, to the end of the word and add "ay" to the end.
        have ➞ avehay
        cram ➞ amcray
        take ➞ aketay
        cat ➞ atcay
        shrimp ➞ impshray
        trebuchet ➞ ebuchettray
        If a word starts with a vowel add "yay" to the end of the word.
        ate ➞ ateyay
        apple ➞ appleyay
        oaken ➞ oakenyay
        eagle ➞ eagleyay
        Write two functions to make an English to pig latin translator. The first function TranslateWord(word) takes a single word and returns that word translated into pig latin.The second function TranslateSentence(sentence) takes an English sentence and returns that sentence translated into pig latin.

        Examples
        TranslateWord("flag") ➞ "agflay"

        TranslateWord("Apple") ➞ "Appleyay"

        TranslateWord("button") ➞ "uttonbay"

        TranslateWord("") ➞ ""

        TranslateSentence("I like to eat honey waffles.") ➞ 
            "Iyay ikelay otay eatyay oneyhay afflesway."
        TranslateSentence("Do you think it is going to rain today?") ➞ 
            "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?"
        Notes
        Regular expressions will help you not mess up the punctuation in the sentence.
        If the original word or sentence starts with a capital letter, the translation should preserve 
            its case (see examples #2, #5 and #6).
        */
        
        public static string TranslateWord(string word)
        {
            string vowels = "aeiouAEIOU";
            Regex re = new Regex("[A-Za-z]+");

            if (!(vowels.Contains(word[0])) && re.IsMatch(word))
            {
                while (!(vowels.Contains(word[0])))
                {
                    word = word.Substring(1) + word[0];
                    break;
                }
                word += "ay";
            }
            
            else if (re.IsMatch(word))
            {
                word += "yay";
            }
            re = new Regex("[A-Z]");
            if (re.IsMatch(word))
            { 
                word=word.ToLower();
                word= char.ToUpper(word[0])+word.Substring(1);
            }

            return word;
        }
        public static string TranslateSentence(string sentence)
        {
            Regex re = new Regex("[A-Za-z]+|[.!?\\-]+");
            foreach (Match match in re.Matches(sentence))
            { 
                int loc=sentence.IndexOf(match.Value);
                sentence=sentence.Remove(loc,match.Value.Length).Insert(loc, TranslateWord(match.Value));
            }
            return sentence;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine(TranslateSentence("I like to eat honey waffles."));
            Console.WriteLine(TranslateSentence("Do you think it is going to rain today?"));

        }
    }
    
}