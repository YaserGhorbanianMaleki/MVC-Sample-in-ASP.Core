using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(string title, string description, string image)
        {
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
