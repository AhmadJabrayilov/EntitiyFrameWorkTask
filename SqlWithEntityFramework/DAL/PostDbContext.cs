using Microsoft.EntityFrameworkCore;
using SqlWithEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace SqlWithEntityFramework.DAL
{
    internal class PostDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-GUSCMO0\SQLEXPRESS;Database=Blog;Trusted_Connection=True;");
        }

        public DbSet<Post>  Posts { get; set; }


    }
}
