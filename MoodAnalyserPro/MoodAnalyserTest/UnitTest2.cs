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
        /// Reflection of two object Uc4.2
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_Return_ClassMesaage()
        {
            try
            {
                object expected = new Analyser(null);
                object obj = MoodAnalyserReflection.CreateMoodAnalyser("Analyser", "Analyser"); // enter wrong constructor name only 

            } catch(MoodAnalyserExpection ex)
            {
                Assert.AreEqual(ex.Message, "Class is not found");
            }

        }
       

    }
}
