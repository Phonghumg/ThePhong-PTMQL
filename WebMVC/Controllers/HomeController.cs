using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Demo(string Fullname)
    {
        string strResult = "Hello " + Fullname;
        ViewBag.thongbao = strResult;
        return View();
    }
}