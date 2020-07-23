using book.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace book.Data
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public ApplicationContext() : base("name=ApplicationConnectionString")
        {

        }
    }
}