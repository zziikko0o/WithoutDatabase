using LoginWithoutDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginWithoutDatabase.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            if (username == "admin" && password == "1234")
            {
                // Redirection vers une page après connexion (par exemple, la page d'accueil)
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Message d'erreur pour l'utilisateur
                ViewBag.ErrorMessage = "Login failed. Invalid username or password.";
                return View();
            }
        }
    }
}
