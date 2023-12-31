using Microsoft.AspNetCore.Mvc;

namespace eticaretb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult hakkinda()
        {
            return View();
        }
        public IActionResult blog_detail()
        {
            return View();
        }
    }
}
