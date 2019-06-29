using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.resources
{
    public class ArticleResource
    {
        public int Id { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public DateTime DateAdded { get; private set; }

        public DateTime? LastUpdate { get; set; }

        public DateTime? DateDeleted { get; set; }

        public int Likes { get; set; }

        public int Views { get; set; }


        public CategoryResource Category { get; set; }

        public int CategoryId { get; set; }
        public ICollection<CommentResource> Comments { get; set; }

        public ArticleResource()
        {
            this.DateAdded = DateTime.Now;
            this.Comments = new Collection<CommentResource>();
        }
    }
}
