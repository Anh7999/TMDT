using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT.Models;

namespace TMDT.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TMDTDAEntities db = new TMDTDAEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Conntact()
        {
            return View();
        }
        public ActionResult Blog ()
        {
            return View();
        }
        public ActionResult BlogD()
        {
            return View();
        }
        public ActionResult Shop( int id)
        {
            var sp  = from s in db.SanPhams where s.IdLoaiSP == id select s;
            return View(sp);
        }
        public ActionResult Product(int id)
        {

            var sp = from s in db.SanPhams
                       where s.IdSP == id
                       select s;
            return View(sp.Single());
        }
       
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Shopbycategory()
        {
            var category = from cd in db.LoaiSanPhams select cd;
            return PartialView(category);
        }
        public ActionResult getSanPham()
        {
            var sp = from cd in db.SanPhams  select cd;
            return PartialView(sp);
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Compare()
        {
            return View();
        }
        public ActionResult Wishlish()
        {
            return View();
        }
    }
}