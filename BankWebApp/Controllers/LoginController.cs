using Microsoft.AspNetCore.Mvc;

namespace BankWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Add logic for authentication
            // Redirect to Dashboard on successful login
            return RedirectToAction("Index", "Dashboard", new { username = username });
        }
    }
}
