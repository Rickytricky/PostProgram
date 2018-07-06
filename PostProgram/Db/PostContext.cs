using PostProgram.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PostProgram.Db
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Post { get; set; }
    }
}