using Microsoft.AspNetCore.Mvc;

namespace GitMVC.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult action()
        {
            string a = "mojiuhy";
            return View();
        }
    }
}
