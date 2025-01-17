namespace QuizApp.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string? Options { get; set; }
        public string? ImageUrl { get; set; }
    }
}
