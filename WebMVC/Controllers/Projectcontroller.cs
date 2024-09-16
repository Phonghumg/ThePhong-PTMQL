using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
namespace WebMVC.Controllers;

public class Projectcontroller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Project sd)
        {
            string strOutput = "Phong xin chao " + sd.Text1 + "-" + sd.Text2 + "-" + "-";
            ViewBag.Message = strOutput;
            return View();
        }
}