//using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.Controllers
{
    public class TestController : Controller
    {
        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}
        /*public IActionResult Index()
        {
            return View("Footer");
        }*/
        //public ContentResult Index()
        //{
        //    //return Content("<h1>MVC courses</h1>",contentType:"text/html");
        //    return Content("<h1>MVC courses</h1><script>confirm('This is the question?')</script>");
        //}
        //public EmptyResult Index()
        //{
        //    return  new EmptyResult();
        //      return null;
        //}

        //public FileResult Index()
        //{
        //    //return File("~/sample.txt","text/text");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/sample.txt");
        //    string fileName = "Sample.txt";
        //    return File(fileByte,MediaTypeNames.Text.Plain,fileName);
        //}

        //public JsonResult Index()
        //{
        //    List<Project> p = new List<Project>()
        //    {
        //        new Project("Taxi", "Taxi app", "Yas", "taxi.jpg"),
        //        new Project("Taxi", "Taxi app", "Yas", "taxi.jpg")
        //    };
        //    return Json(p);
        //}
        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("alert('Hello')");
        //}
        //public RedirectResult Index()
        //{
        //    return Redirect("https://www.google.com");
        //}
        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact","Home");
        //}
        public StatusCodeResult Index()
        {
            return new UnauthorizedResult();
        }
    }

    public class JavaScriptResult:ContentResult
    {
        public JavaScriptResult(string data)
        {
            Content = data;
            ContentType = "text/javascript";
        }
     
    }
}
