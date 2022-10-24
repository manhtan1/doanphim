using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RapPhim2101.Models;

namespace RapPhim2101.Areas.Admin.Controllers
{
    public class PhimsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Admin/Phims
        public ActionResult Index()
        {
            var phims = db.Phims.Include(p => p.DinhDangPhim).Include(p => p.TheLoaiPhim);
            return View(phims.ToList());
        }

        // GET: Admin/Phims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phim phim = db.Phims.Find(id);
            if (phim == null)
            {
                return HttpNotFound();
            }
            return View(phim);
        }

        // GET: Admin/Phims/Create
        public ActionResult Create()
        {
            ViewBag.MaDP = new SelectList(db.DinhDangPhims, "MaDP", "DangPhim");
            ViewBag.MaLP = new SelectList(db.TheLoaiPhims, "MaLP", "LoaiPhim");
            return View();
        }

        // POST: Admin/Phims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhim,MaDP,TenPhim,QuocGia,MaLP,traller,hinhtraller,MoTa,thoiluong,ThoigianChieu,luotxem")] Phim phim)
        {
            if (ModelState.IsValid)
            {
                db.Phims.Add(phim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDP = new SelectList(db.DinhDangPhims, "MaDP", "DangPhim", phim.MaDP);
            ViewBag.MaLP = new SelectList(db.TheLoaiPhims, "MaLP", "LoaiPhim", phim.MaLP);
            return View(phim);
        }

        // GET: Admin/Phims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phim phim = db.Phims.Find(id);
            if (phim == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDP = new SelectList(db.DinhDangPhims, "MaDP", "DangPhim", phim.MaDP);
            ViewBag.MaLP = new SelectList(db.TheLoaiPhims, "MaLP", "LoaiPhim", phim.MaLP);
            return View(phim);
        }

        // POST: Admin/Phims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhim,MaDP,TenPhim,QuocGia,MaLP,traller,hinhtraller,MoTa,thoiluong,ThoigianChieu,luotxem")] Phim phim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDP = new SelectList(db.DinhDangPhims, "MaDP", "DangPhim", phim.MaDP);
            ViewBag.MaLP = new SelectList(db.TheLoaiPhims, "MaLP", "LoaiPhim", phim.MaLP);
            return View(phim);
        }

        // GET: Admin/Phims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phim phim = db.Phims.Find(id);
            if (phim == null)
            {
                return HttpNotFound();
            }
            return View(phim);
        }

        // POST: Admin/Phims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Phim phim = db.Phims.Find(id);
            db.Phims.Remove(phim);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
