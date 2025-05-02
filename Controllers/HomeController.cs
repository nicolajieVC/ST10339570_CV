using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using St10339570_PROG7311_OnlineCV.Models;

namespace St10339570_PROG7311_OnlineCV.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Qualifications() => View();

    public IActionResult AboutMe() => View();

    public IActionResult Projects() => View();
    



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
