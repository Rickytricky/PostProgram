using PostProgram.Db;
using PostProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostProgram.ViewModel
{
    public class VModel
    {
        public Post post { get; set; }
        public List<Post> postsList { get; set; }
        public List<Category> categories { get; set; }
    }
}