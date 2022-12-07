using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPro
{
    public class MoodAnalyserExpection : Exception
    {
        public enum MoodAnalyserExpectionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR
        }
        public MoodAnalyserExpectionType type;
        public MoodAnalyserExpection(MoodAnalyserExpectionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
