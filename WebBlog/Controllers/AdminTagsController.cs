using Microsoft.AspNetCore.Mvc;
using WebBlog.Data;
using WebBlog.Models.Domain;
using WebBlog.Models.ViewModels;

namespace WebBlog.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly DBContext dBContext;
        public AdminTagsController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };
            dBContext.Tag.Add(tag);
            dBContext.SaveChanges();
            return View("Add");
        }
    }
}
