using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;
using RapPhim2101.Models;
using System.IO;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace RapPhim2101.Areas.Admin.Controllers
{
    public class PhimsController : Controller
    {
        private DBContext db = new DBContext();


        public ActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageNum = (page ?? 1);
            var phims = db.Phims.Include(p => p.DinhDangPhim).Include(p => p.TheLoaiPhim);
            return View(phims.ToList().ToPagedList(pageNum, pageSize));
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
        [HttpPost]
        public ActionResult ImportFilms(HttpPostedFileBase postedFile)
        {

            try
            {
                string filePath = string.Empty;
                if (postedFile != null)
                {
                    string path = Server.MapPath("~/Upload/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    //filePath = path + Path.GetFileName(postedFile.FileName);
                    filePath = path + Path.GetFileName(postedFile.FileName);

                    string extension = Path.GetExtension(postedFile.FileName);
                    postedFile.SaveAs(filePath);

                    string conString = string.Empty;
                    switch (extension)
                    {
                        case ".xls":
                            conString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                            break;
                        case ".xlsx":
                            conString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                            break;
                    }

                    DataTable dtExcel = new DataTable();
                    conString = string.Format(conString, filePath);
                    using (OleDbConnection connExcel = new OleDbConnection(conString))
                    {
                        using (OleDbCommand cmdExcel = new OleDbCommand())
                        {
                            using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                            {
                                cmdExcel.Connection = connExcel;
                                connExcel.Open();
                                DataTable dtExcelSchema;
                                dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                                string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                                connExcel.Close();

                                connExcel.Open();
                                cmdExcel.CommandText = "SELECT * from [" + sheetName + "]";
                                odaExcel.SelectCommand = cmdExcel;
                                odaExcel.Fill(dtExcel);
                                connExcel.Close();
                            }
                        }
                    }
                    conString = ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            sqlBulkCopy.DestinationTableName = "[dbo].[Phim]";
                            sqlBulkCopy.ColumnMappings.Add("MaPhim", "MaPhim");
                            sqlBulkCopy.ColumnMappings.Add("MaDP", "MaDP");
                            sqlBulkCopy.ColumnMappings.Add("TenPhim", "TenPhim");
                            sqlBulkCopy.ColumnMappings.Add("QuocGia", "QuocGia");
                            sqlBulkCopy.ColumnMappings.Add("MaLP", "MaLP");
                            sqlBulkCopy.ColumnMappings.Add("traller", "traller");
                            sqlBulkCopy.ColumnMappings.Add("hinhtraller", "hinhtraller");
                            sqlBulkCopy.ColumnMappings.Add("MoTa", "MoTa");
                            sqlBulkCopy.ColumnMappings.Add("thoiluong", "thoiluong");
                            sqlBulkCopy.ColumnMappings.Add("ThoigianChieu", "ThoigianChieu");
                            sqlBulkCopy.ColumnMappings.Add("ThoiGianKetThuc", "ThoiGianKetThuc");
                            sqlBulkCopy.ColumnMappings.Add("luotxem", "luotxem");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dtExcel);
                            con.Close();
                        }
                    }

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
