using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LMS.Model.Entites
{
    public class Library_Context : DbContext
    {
        public DbSet<user> User_Accounts { get; set; }
        public DbSet<Book> Library_Books { get; set; }
        public Library_Context() : base("Library_Context") { }
    }
}