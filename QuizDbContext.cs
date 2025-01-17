using Microsoft.EntityFrameworkCore;
using QuizApp.Entity;

namespace QuizApp
{

    public class QuizDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }

        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options) { }
    }

}
