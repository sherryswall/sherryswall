using System;
using System.Collections.Generic;
using System.Text;

namespace SherrysWall.DAL.Models
{
    public class Blog {
        public int Id { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
    }
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
    }
}
