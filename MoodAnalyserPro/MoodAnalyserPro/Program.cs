namespace MoodAnalyserPro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Analyser analyser = new Analyser();
            string msgs = analyser.CheckMoodAnalyser("I am in Sad Mood");
            Console.WriteLine(msgs);
        }
    }
}
