namespace QuizApp.Entity
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Type {  get; set; } = string.Empty;
        public string? Options {  get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        public string Answer {  get; set; } = string.Empty;
    }
}
