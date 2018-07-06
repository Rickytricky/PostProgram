using System;

namespace PostProgram.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public Post PostId { get; set; }
    }
}