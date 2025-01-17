using QuizApp.DTO;
using QuizApp.Entity;

namespace QuizApp.Mapper
{
    public static class UserMapper
    {
        public static User AnswerDTOToUser(this QuizResultDTO user, int score)
        {
            return new User
            {
                Email = user.Email,
                Score = score,
                Date = DateTime.Now

            };
        }
    }
}
