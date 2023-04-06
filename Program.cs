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
        public class Mydata
        {
            public int projectId { get; set; }
            public string position { get; set; }
            public string duration { get; set; }
        }
        List<Mydata> dataList = new List<Mydata>();

    
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
            int Student_Id= Convert.ToInt32(Console.ReadLine());
            command.CommandText = $"select count(*) from student where id={Student_Id} ";
            try
            {
                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    command.CommandText = $"insert into student(Id,department) values ({Student_Id},'PHY')";
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("Inserted Successfully");
                }
                else
                {
                    Console.WriteLine($"StudentId {Student_Id} Already Exist");
                }
                /*while (reader.Read())
                {
                    Mydata data = new Mydata();
                    data.projectId = (int)reader["projectId"];
                    data.position = (string)reader["position"];
                    data.duration = (string)reader["duration"];

                    dataList.Add(data);
                    //Console.WriteLine(reader.GetInt32(0)+" "+ reader.GetString(1) + " " + reader.GetString(2));
                }

                foreach (Mydata data in dataList)
                {
                    Console.WriteLine(data.projectId + " " + data.position + " " + data.duration);
                }*/

                /* int i = 0;

                 while(reader.Read())
                 {
                     for (int j = 0; j < reader.FieldCount; j++)
                     {
                         Console.Write(reader[j] + " ");
                     }
                     Console.WriteLine();
                     i++;
                 }
                 */
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

