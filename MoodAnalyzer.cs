using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    class MoodAnalyzer
    {
        String msg;
        public MoodAnalyzer() 
        { }
        public MoodAnalyzer(String msg)
        {
            this.msg = msg;
        }

        public String analyseMood()
        {
            Regex regex1 = new Regex(@"Happy");
            Regex regex2 = new Regex(@"sad");
            Regex regex3 = new Regex("");
            if (regex1.IsMatch(msg))
                return msg;
            else if (regex2.IsMatch(msg))
                return msg;
            else if (regex3.IsMatch(msg))
                throw new MoodAnalysisException(" Empty Mood");
            else
                throw new MoodAnalysisException("Invalid input");
        }

    }
    
}