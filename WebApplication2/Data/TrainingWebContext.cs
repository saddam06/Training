using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Training.Web.Models;

namespace Training.Web.Data
{
    public class TrainingWebContext : DbContext
    {
        public DbSet<Training.Web.Models.Product> Product { get; set; }

        public DbSet<Training.Web.Models.Category> Category { get; set; }
        public TrainingWebContext (DbContextOptions<TrainingWebContext> options)
            : base(options)
        {
        }
        public DbSet<Training.Web.Models.Users> Users { get; set; }
        public DbSet<Training.Web.Models.UserResponds> UserResponds { get; set; }

       

       
    }
}
