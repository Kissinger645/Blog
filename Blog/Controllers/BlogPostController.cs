using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Models;

namespace MVCBlog.Controllers
{
    public class BlogPostController : Controller
    {
        BlogPostContext db = new BlogPostContext();

        public ActionResult Index()
        {
            ViewBag.AllBlogPosts = db.BlogPosts.OrderByDescending(b => b.Created).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogPost blogPost)
        {
            using (var db = new BlogPostContext())
            {
                blogPost.Created = DateTime.Now;
                db.BlogPosts.Add(blogPost);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            BlogPost blog = db.BlogPosts.First(b => b.Id == id);
            return View(blog);
        }
    }
}
