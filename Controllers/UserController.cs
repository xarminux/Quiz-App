using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApp.DTO;
using QuizApp.Scoring;
using QuizApp.Entity;
using QuizApp.Mapper;

namespace QuizApp.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public UserController(QuizDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTopUsersScore()
        {
            var topUsers = await _context.Users
                .OrderByDescending(x => x.Score)
                .Take(10)
                .ToListAsync();
            return Ok(topUsers);
        }

        [HttpPost]
        public async Task<IActionResult> AddQuizResult([FromBody] QuizResultDTO quizResult)
        {
            var scoringContext = new ScoringContext();
            int totalScore = 0;

            foreach (var answer in quizResult.Answers)
            {
                var question = await _context.Questions.FindAsync(answer.QuestionId);
                if (question == null) continue;

                totalScore += scoringContext.CalculateScore(answer.QuestionType, question.Answer, answer.Answer);
            }


            _context.Users.Add(quizResult.AnswerDTOToUser(totalScore));
            await _context.SaveChangesAsync();

            return Ok(quizResult.AnswerDTOToUser(totalScore));
        }
    }
}
