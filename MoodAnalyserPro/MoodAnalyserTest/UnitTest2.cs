using MoodAnalyserPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    public class UnitTest2
    {

        /// <summary>
        /// Reflection of two object uc4.1
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_ReturnObject()
        {

            object expected = new Analyser(null);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyserPro.Analyser", "Analyser");

            expected.Equals(obj);
            //Assert.AreEqual(expected,obj);



        }
        /// <summary>
        /// Reflection of two object Uc4.2
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_Return_ClassMesaage()
        {
            try
            {

                object obj = MoodAnalyserReflection.CreateMoodAnalyser("Analyser", "Analyser"); // enter wrong class name only 

            }
            catch (MoodAnalyserExpection ex)
            {
                Assert.AreEqual(ex.Message, "Class is not found");
            }

        }
        /// <summary>
        /// Reflection of two object Uc4.3
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_Return_ConstructorMesaage()
        {
            try
            {
                object expected = new Analyser(null);
                object obj = MoodAnalyserReflection.CreateMoodAnalyser("Analyser", "Demo"); // enter wrong constructor name only 

            }
            catch (MoodAnalyserExpection ex)
            {
                Assert.AreEqual(ex.Message, "Constructor is not found");
            }

        }



    }
}
