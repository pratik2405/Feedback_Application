using CodingRound.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingRound.Controllers
{
    public class FeedbackResponseController : Controller
    {
        private readonly ApplicationContext _context;

        public FeedbackResponseController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("FeedbackResponse/Create/{link}")]
        public IActionResult Create(string link)
        {
            var feedback = _context.Feedbacks.Where(f => f.UniqueIdentifier == link).FirstOrDefault();
            
            HttpContext.Session.SetInt32("feedbackid", feedback.FeedbackId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form )
        {
            try
            {
                int feedbackid = (int)HttpContext.Session.GetInt32("feedbackid");

                string positiveEmotionsString = string.Join(", ", form["PositiveEmotions"]);
                string improvementAreasString = string.Join(", ", form["ImprovementAreas"]);
                string positiveCommnetsString = form["PositiveComments"].ToString();
                string improvementFeedback = form["ImprovementFeedback"].ToString();

                var feedbackres = new FeedbackResponse
                {
                    // assign values

                    FeedbackId = feedbackid,
                    PositiveEmotions = positiveEmotionsString,
                    ImprovementAreas = improvementAreasString,
                    PositiveComments = positiveCommnetsString,
                    ImprovementFeedback = improvementFeedback,
                };

                _context.FeedbackResponses.Add(feedbackres);
                _context.SaveChanges();

                TempData["Message"] = "Feedback submitted successfully!";
                return RedirectToAction("Index", "Feedback");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
        public IActionResult ShowFeedback()
        {
            try
            {
                int? userid = HttpContext.Session.GetInt32("UserId");
                if (userid == null)
                {
                    return RedirectToAction("Login", "Account"); // Redirect if session is not set
                }
                var res = _context.Feedbacks.Where(x => x.UserId == userid).FirstOrDefault();
                int feedid = res.FeedbackId;
                IEnumerable<FeedbackResponse> res2 = _context.FeedbackResponses.Where(x => x.FeedbackId == feedid).ToList();
                return View(res2);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return RedirectToAction("Login", "Feedback");
            }
        }

        public IActionResult DashBoard()
        {
            try
            {
                var feedbackList = _context.FeedbackResponses.ToList();

                // Define pre-set options for checkboxes
                ViewBag.PositiveEmotionsOptions = new List<string> { "Adaptive", "Flexible", "Team Player", "Honest", "Punctual" };
                ViewBag.ImprovementAreasOptions = new List<string> { "Arrogant", "Intuitive", "Lazy", "Aggressive", "Communication" };

                return View(feedbackList);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return RedirectToAction("Login", "Feedback");
            }
        }
    }
}
