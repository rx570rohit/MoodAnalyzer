using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return msg;
        }

    }
    
}