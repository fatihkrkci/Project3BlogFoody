using Microsoft.EntityFrameworkCore;
using Project3BlogFoody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BlogFoody.DataAccessLayer.Context
{
    public class BlogFoodyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FATIHKUREKCI\\SQLEXPRESS;initial catalog=Project3BlogFoody;integrated security=true");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
    }
}
