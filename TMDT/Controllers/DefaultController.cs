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
        public ActionResult Shop()
        {

            return View();
        }
        public ActionResult Product()
        {

            return View();
        }
        public ActionResult Product1(long id)
        {
            var v = from t in db.SanPhams
                    where t.IdLoaiSP == id && t.Hie == true
                    orderby t.Order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Shopbycategory()
        {
            return View();
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