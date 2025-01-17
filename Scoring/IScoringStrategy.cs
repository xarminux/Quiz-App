namespace QuizApp.Scoring
{
    public interface IScoringStrategy
    {
        int CalculateScore(string correctAnswer, string userAnswer);
    }
}
