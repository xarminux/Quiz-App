namespace QuizApp.DTO
{
    public class QuizResultDTO
    {
        public string Email { get; set; } = null!;
        public List<UserAnswerDTO> Answers { get; set; } = new List<UserAnswerDTO>();
    }

    public class UserAnswerDTO
    {
        public int QuestionId { get; set; }
        public string Answer { get; set; } = null!;
        public string QuestionType { get; set; } = null!;
    }
}
