using RapPhim2101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace RapPhim2101.Controllers
{
    public class HomeController : Controller
    {
        private DBContext db = new DBContext();
        public ActionResult Index(int ? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            return View(db.Phims.OrderByDescending(n=>n.ThoigianChieu<DateTime.Now).ToList().ToPagedList(pageNum,pageSize));
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
        public ActionResult phimsapchieu()
        {
            return View(db.Phims.OrderByDescending(n => n.ThoigianChieu > DateTime.Now).ToList());
        }
        public ActionResult phimdangchieu()
        {
            return View(db.Phims.OrderByDescending(n => n.ThoigianChieu < DateTime.Now).ToList());
        }
    }
}