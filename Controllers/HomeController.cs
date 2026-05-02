using Microsoft.AspNetCore.Mvc;
using MiPaginaCV.Models;

namespace MiPaginaCV.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(new CVData());
    }
}
