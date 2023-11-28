using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class LatestArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Article> articles = new List<Article>()
            {
                new Article("JavaScript","آموزش جاوااسکریپت","blog-post-thumb-4.jpg"),
                new Article("ReactJs","آموزش ری اکت ","blog-post-thumb-5.jpg"),
                new Article("CSS","آموزش فشرده سی اس اس","blog-post-thumb-6.jpg"),
            };
            return View("_Articles",articles);
        }
    }
}
