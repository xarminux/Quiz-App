namespace QuizApp.Scoring
{
    public class RadioScoringStrategy : IScoringStrategy
    {
        public int CalculateScore(string correctAnswer, string userAnswer)
        {
            return string.Equals(correctAnswer, userAnswer, StringComparison.OrdinalIgnoreCase) ? 100 : 0;
        }
    }
}
