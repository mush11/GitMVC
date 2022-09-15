using Microsoft.AspNetCore.Mvc;

namespace GitMVC.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            int cb = 23;

            string m = "mo";
            bool b = true;
            return View();
        }

        public IActionResult action()
        {
            string a = "mojiuhy";
            string m = "lop";
            return View();
        }
    }
}
