using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;
using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی "),
            new Service(3, "پلاتین "),
            new Service(4, "الماس "),
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services, "ID", "Name")
            };

            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            form.Services = new SelectList(_services, "ID", "Name");

            if (ModelState.IsValid == false)
            {
                ViewBag.error = "اطلاعات وارد صحیح نیست لطفا دوباره تلاش کنید";
                return View(form);
            }

            ModelState.Clear();

            form = new Contact()
            {
                Services = new SelectList(_services, "ID", "Name")
            };
            ViewBag.success = "پیغام شما با موفقت ارسال شد";
            return View(form);
            //return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
