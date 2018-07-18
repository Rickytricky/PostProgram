using PostProgram.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PostProgram.Db
{
    public class CategoryContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

    }
}