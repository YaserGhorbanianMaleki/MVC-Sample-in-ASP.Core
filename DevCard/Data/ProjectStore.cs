using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Models;

namespace DevCard.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1, "Taxi", "تاکسی انلاین", "Yas", "taxi.jpg"),
                new Project(2,"ZoodFood", "سفارش انلاین غذا", "Yas", "food.jpg"),
                new Project(3,"HumabResource", "مدیریت منابع انسانی", "Yas", "humanresource.png"),
                new Project(4, "Turn", "نوبت انلاین", "Yas", "turn.png")
             };
        }

        public static Project GetProjectBy(int id)
        {
            return GetProjects().FirstOrDefault(p => p.Id == id);
        }
    }
}
