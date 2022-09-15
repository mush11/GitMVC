using Microsoft.AspNetCore.Mvc;

namespace GitMVC.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
