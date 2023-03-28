using Microsoft.AspNetCore.Mvc;
using MyFirstGitHub.Models;
using System.Diagnostics;

namespace MyFirstGitHub.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

       
    }
}