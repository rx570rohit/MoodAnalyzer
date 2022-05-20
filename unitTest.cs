using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace MoodAnalyzer
{
    [TestClass]

    public  class MoodAnalysisException : Exception
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
                Moodanalyzer Mood = new Moodanalyzer("I am Happy ");
                Regex regex = new Regex(@"Happy");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
                Assert.AreEqual(value, "Happy");
                Console.WriteLine("Working");
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
                Moodanalyzer Mood = new Moodanalyzer("I am sad");
                Regex regex = new Regex(@"sad");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
             
                Assert.AreEqual(value, "sad");
                Console.WriteLine("Working");
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
                Moodanalyzer Mood = new Moodanalyzer("");
                Regex regex = new Regex("");
                Match match = regex.Match(Mood.analyseMood());
                String value = match.Value;
                Assert.AreEqual(value, "");
                Console.WriteLine("Working");
            }
            catch (MoodAnalysisException e)
            {
                Console.WriteLine(e);
            }
        }

           public static void Main(String[] arg)
        {


            Assembly executing = Assembly.GetExecutingAssembly();
            Type moodtype = executing.GetType("MoodAnalyzer.Moodanalyzer");
            object mood = Activator.CreateInstance(moodtype);
            MethodInfo getmethod = moodtype.GetMethod("analyseMood");
            string [] param = new string[1];
            param[0] = "Happy";
            
            try
            {
                String detail = getmethod.Invoke(mood,param) as String;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);    
            }
            unitTest un1 = new unitTest();
            un1.TC1_1();
            un1.TC1_2();    
        }
    }
}
