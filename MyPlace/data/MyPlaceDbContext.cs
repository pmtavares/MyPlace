using Microsoft.EntityFrameworkCore;
using MyPlace.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.data
{
    public class MyPlaceDbContext :DbContext
    {
        public MyPlaceDbContext(DbContextOptions<MyPlaceDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
