using Microsoft.AspNetCore.Mvc;
using PartialViewAndViewComponent.Models;

namespace PartialViewAndViewComponent.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Post()
        {
            PostModel model = new PostModel
            {
                Id = 1,
                Author = "Aditya Sharma",
                Title = "What is ASP.Net Core",
                Body = "ASP.Net core is an open source framework for building UI and API.."
            };
               
            return View(model);
        }
    }
}
