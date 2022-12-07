using MoodAnalyserPro;

namespace MoodAnalyserTest
{
    public class Tests
    {
        /// <summary>
        /// exception given sad message and return sad
        /// </summary>
        [Test]
        public void GivenSadMood_whenAnalyser_ReturnTheSadMessage()
        {
            Analyser analyser = new Analyser("I am in a Sad mood");
            //act
            string result = analyser.CheckMoodAnalyser();

            Assert.AreEqual("Sad", result);
        }
        /// <summary>
        /// exception given any message and return happy
        /// </summary>
        [Test]
        public void GivenAnyMood_whenAnalyser_ReturnTheHappyMessage()
        {
            Analyser analyser = new Analyser("I am in a Any mood");
            //act
            string result = analyser.CheckMoodAnalyser();

            Assert.AreEqual("Happy", result);
        }
        /// <summary>
        /// Exception given null message and return null message
        /// </summary>
        [Test]
        public void GivenNullMood_whenAnalyser_ReturnTheHappyMessage()
        {
            try
            {
                Analyser analyser = new Analyser(null);
                //act
                string result = analyser.CheckMoodAnalyser();
            } catch(MoodAnalyserExpection ex)
            {
                Assert.AreEqual(ex.Message, "Mood is null");
            }
           
        }
        /// <summary>
        /// Exception given empty message and return Empty message
        /// </summary>
        [Test]
        public void GivenEmptyMood_whenAnalyser_ReturnTheHappyMessage()
        {
            try
            {
                Analyser analyser = new Analyser(""); // string.Empty
                //act
                string result = analyser.CheckMoodAnalyser();
            }
            catch (MoodAnalyserExpection ex)
            {
                Assert.AreEqual(ex.Message, "Mood is empty");
            }



        }

        /// <summary>
        /// Reflection of two object
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_ReturnObject()
        {
            string message = null;
            object expected = new Analyser(message);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyserPro.Analyser", "Analyser");

            expected.Equals(obj);
            //Assert.AreEqual(expected,obj);
           


        }



    }
}