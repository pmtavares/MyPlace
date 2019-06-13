using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public DateTime DateAdded { get; private set; }

        public DateTime? LastUpdate { get; set; }

        public DateTime? DateDeleted { get; set; }

        public int Likes { get; set; }

        public int Views { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public Article()
        {
            this.DateAdded = DateTime.Now;
        }
    }
}
