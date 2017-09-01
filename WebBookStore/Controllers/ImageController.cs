using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBookStore.Models;

namespace WebBookStore.Controllers
{
    public class ImageController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Image
        public ActionResult GetImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetImage(ImageModel model, HttpPostedFileBase image)
        {
            if (image != null)
            {                
                model.Picture = new byte[image.ContentLength];
                image.InputStream.Read(model.Picture, 0, image.ContentLength);
            }
            db.ImageModels.Add(model);
            db.SaveChanges();
            return Content("Slika je sacuvana");
        }
    }
}