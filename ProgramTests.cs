using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void OverTimeTest()
        {
            
            Program SalaryCalculator = new Program();
            Details details = new Details();
            details.StartTime = 9;
            details.EndTime = 17;
            details.HourlyRate = 30;
            details.OvertimeMultiplier = 1.5;
            StringWriter stringBuilder = new StringWriter();
            Console.SetOut(stringBuilder);
            Console.Write(SalaryCalculator.OverTime(details));
            Assert.AreEqual(Convert.ToString(240.00), stringBuilder.ToString()); 
            //Assert.AreEqual(240.00, SalaryCalculator.OverTime(details)); 
        }
        [TestMethod()]
        public void OverTimeTest1()
        {

            Program SalaryCalculator = new Program();
            Details details = new Details();
            details.StartTime = 16;
            details.EndTime = 18;
            details.HourlyRate = 30;
            details.OvertimeMultiplier = 1.8;
            StringWriter stringBuilder = new StringWriter();
            Console.SetOut(stringBuilder);
            Console.Write(SalaryCalculator.OverTime(details));
            Assert.AreEqual(Convert.ToString(84.00), stringBuilder.ToString());
        }
        [TestMethod()]
        public void OverTimeTest2()
        {

            Program SalaryCalculator = new Program();
            Details details = new Details();
            details.StartTime = 13.25;
            details.EndTime = 15;
            details.HourlyRate = 30;
            details.OvertimeMultiplier = 1.5;
            StringWriter stringBuilder = new StringWriter();
            Console.SetOut(stringBuilder);
            Console.Write(SalaryCalculator.OverTime(details));
            Assert.AreEqual(Convert.ToString(52.50), stringBuilder.ToString());
        }
    }
}