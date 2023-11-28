using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Data;
using DevCard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace DevCard.Controllers
{
    //[Route("inventory/product")]
    public class HomeController : Controller
    {
        private readonly List<Service> services = new List<Service>()
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس")

        };

        //[Route("indexpage")]
        public IActionResult Index(int id)
        {
            return View();
        }

        public ViewResult ProjectDetail(int id)
        {
            var project = ProjectStore.GetProjectBy(id);
            return View(project);
        }

        [HttpGet]
        //[Route("contactpage")]
        public IActionResult Contact(int id)
        {
            var model = new Contact();
            model.Services = new SelectList(services, "Id", "Name");
            return View(model);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            var model2 = new Contact();
            model2.Services = new SelectList(services, "Id", "Name");
            if(ModelState.IsValid)
            {
                ViewBag.success = "اطلاعات موفقیت آمیز بود";
                ModelState.Clear();
                return View(model2);
            }
            else
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید";
                return View(model);
            }
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
