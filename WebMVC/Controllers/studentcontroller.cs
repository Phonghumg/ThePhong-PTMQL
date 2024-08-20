using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers;

public class Studentcontroller : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Student sd)
        {
            string strOutput = "Phong xin chao " + sd.StudentId + "-" + sd.Name + "-" + sd.Address;
            ViewBag.Message = strOutput;
            return View();
        }
 
}