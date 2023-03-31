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
    /*  Working 9 to 5
    Write a function that calculates overtime and pay associated with overtime.

    Working 9 to 5: regular hours
    After 5pm is overtime
    Your function gets an array with 4 values:

    Start of working day, in decimal format, (24-hour day notation)
    End of working day. (Same format)
    Hourly rate
    Overtime multiplier
    Your function should spit out:

    $ + earned that day (rounded to the nearest hundreth)
    Examples
    OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

    OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

    OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
    2nd example explained:

    From 16 to 17 is regular, so 1 * 30 = 30
    From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
    30 + 54 = $84.00*/
    
    public struct Details
    {

        public double StartTime;
        public double EndTime;
        public int HourlyRate;
        public double OvertimeMultiplier;
    }
    public class Program
    {
        public double OverTime(Details details)
        {
            double NormalPay=0.0,AdditionalPay=0.0;
            if(details.EndTime > 17)
            {
                double NormalDifferenceHours = Math.Abs(details.StartTime - 17.0);
                double OverTimelDifferenceHours = Math.Abs(17.0 - details.EndTime);
                NormalPay = NormalDifferenceHours * details.HourlyRate;
                AdditionalPay = OverTimelDifferenceHours * details.HourlyRate * details.OvertimeMultiplier;
            }
            else
            {
                double NormalDifferenceHours = Math.Abs(details.StartTime - details.EndTime);
                NormalPay = NormalDifferenceHours * details.HourlyRate;
            }
            return NormalPay+Math.Round(AdditionalPay);
        }
        public static void Main(string[] args)
        {

            Program SalaryCalculator = new Program();
            Details details = new Details();
            details.StartTime = 9;
            details.EndTime = 17;
            details.HourlyRate = 30;
            details.OvertimeMultiplier = 1.5;
            Console.WriteLine(SalaryCalculator.OverTime(details));
        }
    }
}