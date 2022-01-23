using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.View_Components
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1 , " Top 3 JavaScript Frameworks" , "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aeneancommodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis disparturient..." , "blog-post-thumb-card-1.jpg"),
                new Article(2 , "About Remote Working" , " Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aeneancommodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient..." , "blog-post-thumb-card-2.jpg"),
                new Article(3 , "A Guide to Becoming a Full-Stack Developer" , " Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient..." , "blog-post-thumb-card-3.jpg"),
                new Article(4 , " Top 3 JavaScript Frameworks" , "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aeneancommodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis disparturient..." , "blog-post-thumb-card-4.jpg"),
                new Article(5 , "About Remote Working" , " Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aeneancommodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient..." , "blog-post-thumb-card-5.jpg"),
                new Article(6 , "A Guide to Becoming a Full-Stack Developer" , " Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient..." , "blog-post-thumb-card-6.jpg"),
            };
            return View("_LatestArticles" , articles);
        }
    }
}
 