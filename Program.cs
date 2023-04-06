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

namespace ConsoleApp1
{
    public class Program
    {
        

    
        struct StudentRow
        {
            string name;
            int id;
            int age;
            string email;
            int phoneno;
            string dateofbirth;
            string dept;
            int facultyincharge;
        }
        public static void Main(string[] args)
        {
            string connetionString = @"Data Source=5CG9410FJD;Initial Catalog=Practice Database;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            
            SqlCommand command = conn.CreateCommand();

            try
            {
             
                command.CommandText = $"Delete from student where name is NULL";
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("Deleted Successfully");
              
            }
            catch(SqlException ex)
            { Console.WriteLine(ex.Message); }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            conn.Close();

        }
    }
    
}

