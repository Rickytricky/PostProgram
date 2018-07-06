using PostProgram.Models;
using PostProgram.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostProgram.ViewModel;

namespace PostProgram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            VModel models = new VModel();
            using (var db = new PostContext())
            {
                models.postsList = db.Post.ToList();
            }

            using (var db = new CategoryContext())
            {
                models.categories = db.Category.ToList();
            }

            return View(models);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post p)
        {
            p.Time = DateTime.Now;
            List<Post> postsList;
            using(var db = new PostContext())
            {
                postsList = db.Post.ToList();
                db.Post.Add(p);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            List<Post> postList;
            using(var db = new PostContext())
            {
                postList = db.Post.ToList();
            }

            Post post = postList.First(s => s.Id == id);
            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(Post p)
        {
            List<Post> postList;
            using (var db = new PostContext())
            {
                postList = db.Post.ToList();
                int index = postList.FindIndex(s => s.Id == p.Id);

                postList[index].Title = p.Title;
                postList[index].Content = p.Content;
                postList[index].CategoryId = p.CategoryId;

                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            VModel models = new VModel();
            using (var db = new PostContext())
            {
                models.postsList = db.Post.ToList();
            }

            models.post = models.postsList.First(s => s.Id == id);

            return View(models.post);
        }

        [HttpPost]
        public ActionResult Delete(Post p)
        {
            //List<Post> postsList;
            using (var db = new PostContext())
            {
                Post post = db.Post.Where(z => z.Id == p.Id).First();
                db.Post.Remove(post);
                //int index = postsList.FindIndex(s => s.Id == p.Id);

                //postsList.RemoveAt(index);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult ViewPost(int id)
        {
            List<Post> postsList;
            using (var db = new PostContext())
            {
                postsList = db.Post.ToList();
            }

            Post post = postsList.First(s => s.Id == id);

            return View(post);
        }
    }
}