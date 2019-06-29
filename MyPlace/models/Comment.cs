using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.models
{

    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

        [StringLength(255)]
        [Required]
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }

        public int UserId {get; set;}


        
    }
}
