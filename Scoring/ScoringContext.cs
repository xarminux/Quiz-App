namespace QuizApp.Scoring
{
    public class ScoringContext
    {
        private readonly Dictionary<string, IScoringStrategy> _strategies;

        public ScoringContext()
        {
            _strategies = new Dictionary<string, IScoringStrategy>
            {
                { "Radio", new RadioScoringStrategy() },
                { "Checkbox", new CheckBoxScoringStrategy() },
                { "Textbox", new TextBoxScoringStrategy() }
            };
        }

        public int CalculateScore(string questionType, string correctAnswer, string userAnswer)
        {
            if (_strategies.ContainsKey(questionType))
            {
                Console.WriteLine(_strategies[questionType].CalculateScore(correctAnswer, userAnswer));
                return _strategies[questionType].CalculateScore(correctAnswer, userAnswer);
            }

            throw new InvalidOperationException("Unsupported question type");
        }
    }
}
