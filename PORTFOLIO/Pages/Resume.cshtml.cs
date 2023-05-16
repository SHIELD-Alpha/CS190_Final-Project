using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace PORTFOLIO.Pages
{
    public class ResumeModel : PageModel
    {
        private readonly ILogger<ResumeModel> _logger;

        public ResumeModel(ILogger<ResumeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
            ViewData["TimeStamp"] = dateTime;
        }
    }
}