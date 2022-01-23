using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.View_Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1 , "تاکسی" , "درخواست آنلاین تاکسی برای سفر های درون شهری" , "project-1.jpg","Snapp"),
                new Project(2 , "زودفود" , "درخواست آنلاین غذا برای سفارش های درون شهری" , "project-2.jpg","Zoodfood"),
                new Project(3 , "الو پیک" , "درخواست آنلاین پیک برای بسته های درون شهری" , "project-3.jpg","Alopeyk"),
                new Project(4 , "مدارس" , "سیستم مدیریت یکپارجه مدارس" , "project-4.jpg" , "MR.SA")
            };
            return View("_Projects" , projects);
        }
    }
}
     