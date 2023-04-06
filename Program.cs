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
            using (SqlConnection conn = new SqlConnection(connetionString))
            { 
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "display_details";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        for(int i=0;i<reader.FieldCount;i++) 
                        {
                            Console.Write(reader[i].ToString().Trim()+ " ");
                        }
                        Console.WriteLine();
                    }
                    reader.Close();
                    Console.WriteLine();    
                    cmd.CommandText = "sortby_column";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@table_name", "employee"));
                    cmd.Parameters.Add(new SqlParameter("@column_name", "salary"));
                    cmd.Parameters.Add(new SqlParameter("@sortby", "desc"));
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i].ToString().Trim() + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            

        }
    }
    
}

