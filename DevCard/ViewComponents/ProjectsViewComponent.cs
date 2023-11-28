using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Data;
using Microsoft.AspNetCore.Mvc;
using DevCard.Models;

namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        private readonly List<DevCard.Models.Project> projects = new List<DevCard.Models.Project>();
        public IViewComponentResult Invoke(string s)
        {
            var projects = ProjectStore.GetProjects();
            return View("_Projects",projects);
        }
    }
}
