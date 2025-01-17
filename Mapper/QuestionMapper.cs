using QuizApp.DTO;
using QuizApp.Entity;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace QuizApp.Mapper
{
    public static class QuestionMapper
    {
        public static QuestionDTO QuestionToQuestionDTO(this Question question)
        {
            return new QuestionDTO
            {
                Id = question.Id,
                Title = question.Title,
                Type = question.Type,
                Options = question.Options,
                ImageUrl = question.ImageUrl

            };
        }
    }
}
