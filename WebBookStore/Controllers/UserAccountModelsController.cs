using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBookStore.Models;

namespace WebBookStore.Controllers
{
    public class UserAccountModelsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: UserAccountModels
        public ActionResult Index()
        {
            //return View(db.UserModels.ToList());
            return View();
        }       

        [HttpPost]
        public ActionResult Index(ViewModel vm)
        {
            //return View(db.UserModels.ToList());
            

            //var trazenaOsoba1 = db.UserModels.Find(vm.UserAccount.Password);
            var trazenaOsoba = db.UserModels.First(user=>user.Password == vm.UserAccount.Password && user.Username == vm.UserAccount.Username);
            if (trazenaOsoba != null)
            {
                return RedirectToAction("Index","Book");
            }else
            {
                return Content("Ne postoji takva osoba");
            }            
        }

        public ActionResult registerPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult registerPage(ViewModel vm)
        {

            //string fileName = Path.GetFileNameWithoutExtension(vm.UserAccount.ImageFile.FileName);
            //string extension = Path.GetExtension(vm.UserAccount.ImageFile.FileName);
            //fileName = fileName + DateTime.Now.ToString("yymmssffff");
            //vm.UserAccount.ImagePath = "~/Image/" + fileName;
            //fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            //vm.UserAccount.ImageFile.SaveAs(fileName);

            db.UserModels.Add(vm.UserAccount);
                
            db.SaveChanges();
            ModelState.Clear();
            return View("Index");       
        }

        public ActionResult testPage()
        {
            return View();
        }

        public ActionResult Test()
        {
            //return View(db.UserModels.ToList());
            return View();
        }

        [HttpPost]
        public ActionResult testPage(string username, int password)
        {
            return Content("Korisnik je "+ username + " a sifra je "+ password.ToString());
        }

        public ActionResult Test1(string x, string y)
        {
            return Content(x+y);
        }
        
        public ActionResult Edit(int idNum)
        {
            return Content(idNum.ToString());
        }

        [HttpPost]
        public ContentResult Login(ViewModel log)
        {
            var x = log.UserAccount.Password.ToString();
            return Content(x);
        }

        [HttpPost]
        public ContentResult Login1(string id, string numb)
        {
            
            return Content(id + numb);
        }

        // GET: UserAccountModels/Details/5
        public ActionResult Details(string id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //UserAccountModel userAccountModel = db.UserModels.Find(id);
            //if (userAccountModel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(userAccountModel);
            return Content("Details");
        }

        //// GET: UserAccountModels/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: UserAccountModels/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "UserAccountID,Username,Password,isDeleted")] UserAccountModel userAccountModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.UserModels.Add(userAccountModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(userAccountModel);
        //}

        //// GET: UserAccountModels/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    UserAccountModel userAccountModel = db.UserModels.Find(id);
        //    if (userAccountModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userAccountModel);
        //}

        //// POST: UserAccountModels/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "UserAccountID,Username,Password,isDeleted")] UserAccountModel userAccountModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(userAccountModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(userAccountModel);
        //}

        //// GET: UserAccountModels/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    UserAccountModel userAccountModel = db.UserModels.Find(id);
        //    if (userAccountModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userAccountModel);
        //}

        //// POST: UserAccountModels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    UserAccountModel userAccountModel = db.UserModels.Find(id);
        //    db.UserModels.Remove(userAccountModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
