using CodingRound.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingRound.Controllers
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>op):base(op)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<FeedbackResponse> FeedbackResponses { get; set; }
    }
}
