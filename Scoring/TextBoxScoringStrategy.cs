namespace QuizApp.Scoring
{
    public class TextBoxScoringStrategy : IScoringStrategy
    {
        public int CalculateScore(string correctAnswer, string userAnswer)
        {
            return string.Equals(correctAnswer, userAnswer, StringComparison.OrdinalIgnoreCase) ? 100 : 0;
        }
    }
}
