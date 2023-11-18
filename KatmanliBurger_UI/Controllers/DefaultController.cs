using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData["message"] = " Logout";
                TempData["adress"] = "/Default/Logout";
            }
            else
            {
                TempData["message"] = " Login";
                TempData["adress"] = "/Login/Index";
            }
            return View();
        }
    }
}
