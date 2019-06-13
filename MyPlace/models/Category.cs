using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }

        public Category()
        {
            Articles = new Collection<Article>();
        }
    }
}
