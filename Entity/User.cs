namespace QuizApp.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public int Score {  get; set; }
        public DateTime Date { get; set; }
    }
}
