using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostProgram.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Category CategoryId { get; set; }
        public DateTime Time { get; set; }
    }
}