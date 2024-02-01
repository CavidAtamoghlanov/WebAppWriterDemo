using EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class MyAppDbContext : DbContext
    {
        //public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        //{
        //}
        public MyAppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0121-08;Initial Catalog=MyAppDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<NewLetter> NewLetters { get; set; }
    }
}
