namespace QuizApp.Scoring
{
    public class CheckBoxScoringStrategy : IScoringStrategy
    {
        public int CalculateScore(string correctAnswer, string userAnswer)
        {
            var correctAnswers = correctAnswer.Split(',');
            var userAnswers = userAnswer.Split(',');

            int correctCount = correctAnswers.Intersect(userAnswers).Count();
            int totalCorrect = correctAnswers.Length;

            if (correctCount == 0) return 0;

            return (int)Math.Ceiling((100.0 / totalCorrect) * correctCount);
        }
    }
}
