using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    
    internal class Program
    {

        static void FileObejct()
        {
            File.WriteAllText("D:\\FileHandling.txt", "hello from WriteAll\n");
            File.AppendAllText("D:\\FileHandling.txt", "hello from AppendAll\n");
        }
        static void FileStreamerObject()
        {
            FileStream file = new FileStream("D:\\FileHandling.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            file.Write(Encoding.UTF8.GetBytes("hello from C# "));
            file.WriteByte(77);
            file.Close();
        }
        static void StreamWriterObject()
        {
            FileStream file1 = new FileStream("D:\\FileHandling.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter stream = new StreamWriter(file1);
            stream.WriteLine("Hello from Stream Writer");
            stream.Close();
            file1.Close();
        }
        static void StreamReaderObject()
        {
            FileStream file2 = new FileStream("D:\\FileHandling.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader streamrd = new StreamReader(file2);
            var str = streamrd.ReadLine();
            Console.WriteLine(str);
            streamrd.Close();
            file2.Close();
        }
        static void TextWriterObject()
        {

            TextWriter textWriter = File.CreateText("D:\\FileHandling.txt");
            textWriter.WriteLine("hello from textwriter");
            textWriter.WriteLine();
            textWriter.Close();
        }
        static void TextReaderObject()
        {
            TextReader textReader = File.OpenText("D:\\FileHandling.txt");
            var str1 = textReader.ReadToEnd();
            Console.WriteLine(str1);
        }
        static void FileInfoObject()
        {
            var path = "D:\\textfile.txt";
            FileInfo fi = new(path);
            fi.Create();
        }
        static void DirectoryInfoObject()
        {
            var path = "D:\\has";
            DirectoryInfo di = new(path);
            //di.Create();
            di.Delete();
        }
        static void Main(string[] args)
        {

            FileInfoObject();
            DirectoryInfoObject();






        }
    }

    
}
