using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBookStore.Models;

namespace WebBookStore.Controllers
{
    public class BookController : Controller
    {
        private AppDbContext db = new AppDbContext();
        // GET: Book
        public ActionResult Index()
        {
            var x = HttpContext.Request.Url.PathAndQuery.ToString();
            var username = x.Substring(11);
            Session["user"] = username;
            return View();
        }

        
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(ViewModel vm)
        {
            db.BookModels.Add(vm.Books);
            db.SaveChanges();
            return View();
        }
    }
}