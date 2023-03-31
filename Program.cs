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
    /*  Create a C# program to manage a photo book using OOPs.

    To start, create a class called PhotoBook.  It must also have a public method GetNumberPages that will return the number of photo book pages.

    The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

    There is also a AddPhotoBook class whose constructor will create an album with 64 pages.

    Finally create a PhotoBookTest class to perform the following actions:

    Create a default photo book and show the number of pages
    Create a photo book with 32 pages and show the number of pages
    Create a large photo book and show the number of pages*/

    
    public class PhotoBook
    {
        private protected int pages;
        public PhotoBook()
        {
            this.pages = 16;
        }
        public PhotoBook(int pages)
        {
            this.pages = pages;
        }
        public int GetNumberPages()
        { 
            return pages;
        }
    }
    public class AddPhotoBook : PhotoBook
    {
        /*public AddPhotoBook() : base(64)*/
        public AddPhotoBook()
        {
            this.pages = 64;
        }
    }
    public class PhotoBookTest
    {
        public PhotoBookTest() { 
            PhotoBook DefaultBook = new PhotoBook();
            Console.WriteLine($"Default Book Pages: {DefaultBook.GetNumberPages()}");
            PhotoBook Book_32 = new PhotoBook(32);
            Console.WriteLine($"Custom Book Pages: {Book_32.GetNumberPages()}");
            AddPhotoBook Book_64 = new AddPhotoBook();
            Console.WriteLine($"Large Book Pages: {Book_64.GetNumberPages()}");

        }

    }
    public class Program
    {
      
        public static void Main(string[] args)
        {
           PhotoBookTest test= new PhotoBookTest();
        }
    }
}