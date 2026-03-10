using Microsoft.AspNetCore.Mvc;

namespace lab.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return Content("Exams Web project is running successfully.");
    }
}