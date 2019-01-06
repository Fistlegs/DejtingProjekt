using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DejtingProjekt.Models
{
    public class DejtDBContext : DbContext
    {
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<PostModel> Posts { get; set; }

        public DejtDBContext() : base("DejtDB") { }
    }
}