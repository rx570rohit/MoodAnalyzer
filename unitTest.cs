using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    [TestClass]

    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisException(string message) : base(message)
        {

        }
    }
    internal class unitTest
    {
        [TestMethod]
        public  void TC1_1()
        {
            try
            {
                MoodAnalyzer Mood = new MoodAnalyzer(Console.ReadLine());
                Regex regex = new Regex(@"Happy");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
                Assert.AreEqual(value, "Happy");
            }
            catch (Exception ex)
            {
                Console.WriteLine("invalid Input");  
            }
        }
        [TestMethod]
        public  void TC1_2()
        {
            try
            {
                MoodAnalyzer Mood = new MoodAnalyzer(Console.ReadLine());
                Regex regex = new Regex(@"any");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
                Assert.AreEqual(value, "any");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input");
            }
        }
        public static void Main(String[] arg)
        {
            unitTest un1 = new unitTest();
            un1.TC1_1();
            un1.TC1_2();    
        }
    }
}
