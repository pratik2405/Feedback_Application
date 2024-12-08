using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingRound.Models
{
    [Table("Feedbacks")]
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public int UserId { get; set; }
        public string ? FeedbackText { get; set; }
        public DateTime CreatedAt { get; set; }

        public string ? UniqueIdentifier {  get; set; }
    }
}
