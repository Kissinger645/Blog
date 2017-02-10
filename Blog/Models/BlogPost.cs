using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCBlog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string TeaserText { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }

    }

    public class BlogPostContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }

    }
}