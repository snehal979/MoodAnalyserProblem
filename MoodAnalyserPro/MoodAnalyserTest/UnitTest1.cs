using MoodAnalyserPro;

namespace MoodAnalyserTest
{
    public class Tests
    {
        Analyser analyser = new Analyser();
        [Test]
        public void GivenSadMood_whenAnalyser_ReturnTheSadMessage()
        {
            //act
            string result = analyser.CheckMoodAnalyser("I am in a Sad mood");

            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenAnyMood_whenAnalyser_ReturnTheHappyMessage()
        {
            //act
            string result = analyser.CheckMoodAnalyser("I am in a Any mood");

            Assert.AreEqual("Happy", result);
        }



    }
}