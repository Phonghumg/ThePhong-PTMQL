using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;



namespace WebMVC.Controllers;

public class StudentController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Student sd)
        {
            string strOutput = "Phong xin chao " + sd.StudentID + "-" + sd.Name + "-" + sd.Address + "-" + sd.Email;
            ViewBag.Message = strOutput;
            return View();
        }
 
}
