using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.resources
{
    public class UsersResource
    {
        public int Id { get; set; }

        public string Name { get; set; }

      
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

     
        public string Email { get; set; }

        public ICollection<ArticleResource> Articles { get; set; }

        public UsersResource()
        {
            Articles = new Collection<ArticleResource>();
        }
    }
}
