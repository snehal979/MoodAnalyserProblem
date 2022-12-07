using MoodAnalyserPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    public class UnitTest3
    {
        /// <summary>
        /// given Mood analyser class name should return mood analyser object UC 5.1
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_ReturnObject_UsingParamerter()
        {

            object expected = new Analyser("Happy");
            object obj = MoodAnalyserReflection.CreateMoodAnalyseUsingParameterConstructor("MoodAnalyserPro.Analyser", "Analyser", "Happy");

            expected.Equals(obj);



        }
    }
}
