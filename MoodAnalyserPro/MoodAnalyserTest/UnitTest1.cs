using MoodAnalyserPro;

namespace MoodAnalyserTest
{
    public class Tests
    {
      
        [Test]
        public void GivenSadMood_whenAnalyser_ReturnTheSadMessage()
        {
            Analyser analyser = new Analyser("I am in a Sad mood");
            //act
            string result = analyser.CheckMoodAnalyser();

            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenAnyMood_whenAnalyser_ReturnTheHappyMessage()
        {
            Analyser analyser = new Analyser("I am in a Any mood");
            //act
            string result = analyser.CheckMoodAnalyser();

            Assert.AreEqual("Happy", result);
        }
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



    }
}