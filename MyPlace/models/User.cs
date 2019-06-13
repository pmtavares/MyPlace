using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<Article> Articles { get; set; }

        public User()
        {
            Articles = new Collection<Article>();
        }
    }
}
