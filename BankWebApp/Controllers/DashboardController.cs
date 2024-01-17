using Microsoft.AspNetCore.Mvc;

namespace BankWebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index(string username)
        {
            ViewBag.Username = username;
            return View();
        }
        [HttpPost]
        public IActionResult Logout()
        {
            // Add logic for logout
            // Redirect to Login page
            return RedirectToAction("Login", "Login");
        }

    }
}
