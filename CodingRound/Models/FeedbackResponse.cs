using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingRound.Models
{
    [Table("FeedbackResponse")]
    public class FeedbackResponse
    {
        [Key]
        public int Id { get; set; }
        public int FeedbackId { get; set; }
        public string ?PositiveEmotions { get; set; } 
        public string ?ImprovementAreas { get; set; }
        public string? PositiveComments { get; set; }
        public string? ImprovementFeedback { get; set; }

       
    }
}
