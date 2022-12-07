using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserPro
{
    public class MoodAnalyserReflection
    {

        public static object CreateMoodAnalyser(string ClassName, string ConstructorName)
        {
            string pattern = @"."+ConstructorName+"$";
            Match result = Regex.Match(pattern, ClassName);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserExpection(MoodAnalyserExpection.MoodAnalyserExpectionType.NO_SUCH_CLASS, "Class is not found");
                }
            }
            else
            {
                throw new MoodAnalyserExpection(MoodAnalyserExpection.MoodAnalyserExpectionType.NO_SUCH_CONSTRUCTOR, "Constructor is not found");
            }
        }



    }
}
