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
    {/// <summary>
    /// UC4
    /// </summary>
    /// <param name="ClassName"></param>
    /// <param name="ConstructorName"></param>
    /// <returns></returns>
    /// <exception cref="MoodAnalyserExpection"></exception>

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
                throw new MoodAnalyserExpection(MoodAnalyserExpection.MoodAnalyserExpectionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
        /// <summary>
        /// Uc5 for parametrised constructor by passing message
        /// </summary>
        /// <param name="className"></param>
        /// <param name="ConstructorName"></param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserExpection"></exception>
        public static object CreateMoodAnalyseUsingParameterConstructor(string className,string ConstructorName,string message)
        {
            Type type = typeof(Analyser);
            if(type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object Instance = ctor.Invoke(new object[] { "Happy" });
                    return Instance;

                }
                else
                {
                    throw new MoodAnalyserExpection(MoodAnalyserExpection.MoodAnalyserExpectionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodAnalyserExpection(MoodAnalyserExpection.MoodAnalyserExpectionType.NO_SUCH_CLASS, "Class is not found");
            }
        }



    }
}
