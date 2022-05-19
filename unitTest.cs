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
        public MoodAnalysisException(String message) : base(message)
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
                MoodAnalyzer Mood = new MoodAnalyzer("I am Happy ");
                Regex regex = new Regex(@"Happy");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
                Assert.AreEqual(value, "Happy");
            }
            catch (MoodAnalysisException e )
            {
                Console.WriteLine("user defined Exception "+ e);  
            }
        }
        [TestMethod]
        public  void TC1_2()
        {
            try
            {
                MoodAnalyzer Mood = new MoodAnalyzer("I am sad");
                Regex regex = new Regex(@"sad");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
                Assert.AreEqual(value, "sad");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void TC1_3()
        {
            try
            {
                MoodAnalyzer Mood = new MoodAnalyzer("");
                Regex regex = new Regex("");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
                Assert.AreEqual(value, "");
            }
            catch (MoodAnalysisException e)
            {
                Console.WriteLine(e);
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
