using CodingRound.Models;
using CodingRound.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingRound.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly ApplicationContext _context;

        public FeedbackController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var feedbackList = _context.Feedbacks.ToList();
            return View(feedbackList);
        }

        public string GenerateUniqueLink()
        {
            return Guid.NewGuid().ToString();
        }

        // POST: Create new feedback link
        [HttpPost]
        public IActionResult Create(string feedbackName)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");
            var feedback = new Feedback
            {
                FeedbackText = feedbackName,
                UniqueIdentifier = GenerateUniqueLink(),
                CreatedAt = DateTime.Now,
                UserId=userid
    
            };
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Feedback submission page
        [HttpGet("Feedback/Submit/{link}")]
        public IActionResult Submit(string link)
        {
            var feedback = _context.Feedbacks.FirstOrDefault(f => f.UniqueIdentifier == link);
            if (feedback == null)
            {
                return NotFound("Feedback link is invalid or inactive.");
            }
            HttpContext.Session.SetInt32("feedbackid", feedback.FeedbackId);
            return View(("Create", "FeedbackResponse")); // Show feedback form
        }

        // POST: Submit feedback
        [HttpPost("Feedback/Submit/{link}")]
        public IActionResult Submit(string link, string feedbackData)
        {
            // Save feedback data logic here
            return View("ThankYou"); // Thank you page
        }
    }
}
