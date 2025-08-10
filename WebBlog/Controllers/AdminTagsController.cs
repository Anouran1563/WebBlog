using Microsoft.AspNetCore.Mvc;

namespace WebBlog.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
