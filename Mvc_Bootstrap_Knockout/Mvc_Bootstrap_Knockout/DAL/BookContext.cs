using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using Mvc_Bootstrap_Knockout.Models;
using System.Data.Entity;


namespace Mvc_Bootstrap_Knockout.DAL
{
    public class BookContext : DbContext
    {

        public BookContext() : base("BookContext")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}