using Microsoft.AspNetCore.Mvc;

namespace GitMVC.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            int cb = 23;
            return View();
        }

        public IActionResult action()
        {
            string a = "mojiuhy";
            return View();
        }
    }
}
