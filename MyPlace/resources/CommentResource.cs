using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.resources
{
    public class CommentResource
    {
        public int Id { get; set; }

        public int ArticleId { get; set; }
        public ArticleResource Article { get; set; }

        [StringLength(255)]
        [Required]
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }

        public int UserId { get; set; }


        public CommentResource()
        {
            this.DateAdded = DateTime.Now;
        }
    }
}
