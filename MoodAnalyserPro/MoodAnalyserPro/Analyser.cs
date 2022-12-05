using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPro
{
    public class Analyser
    {
        string message;
        public Analyser(string message)
        {
            this.message=message;
        }

        public string CheckMoodAnalyser()
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new MoodAnalyserExpection(MoodAnalyserExpection.MoodAnalyserExpectionType.NULL_MOOD, "Mood is null");
            }
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
