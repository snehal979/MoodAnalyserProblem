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
        /// <summary>
        /// given Mood analyser class name should return moodMessage UC 5.2
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_ReturnExceptionMessage_UsingParamerter()
        {

            try
            {

                object obj = MoodAnalyserReflection.CreateMoodAnalyseUsingParameterConstructor("MoodAnalyserPro.Democlass", "Analyser", "Happy");  

            }
            catch (MoodAnalyserExpection ex)
            {
                Assert.AreEqual(ex.Message, "Class is not found");
            }


        }
        /// <summary>
        /// given Mood analyser Constructor name should return moodMessage UC 5.3
        /// </summary>
        [Test]
        public void GivenMoodAnalyserConstructorName_ReturnExceptionMessage_UsingParamerter()
        {

            try
            {

                object obj = MoodAnalyserReflection.CreateMoodAnalyseUsingParameterConstructor("MoodAnalyserPro.Analyser", "DemoClass", "Happy");

            }
            catch (MoodAnalyserExpection ex)
            {
                Assert.AreEqual(ex.Message, "Constructor is not found");
            }


        }



    }
}
