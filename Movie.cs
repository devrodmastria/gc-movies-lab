using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    internal class Movie
    {

        public string title {  get; set; }
        public string category { get; set; }

        public Movie (string newTitle, string newCategory)
        {
            title = newTitle;
            category = newCategory;
        }
    }
}
