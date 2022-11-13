using RapPhim2101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapPhim2101.Controllers
{
    public class DatVeController : Controller
    {
        // GET: DatVe
        private DBContext db = new DBContext();

        public ActionResult TrangDatVe(int id)
        {
            /*List<GioHangItem> lstgiohang = Laygiohang();
            GioHangItem product = lstgiohang.Find(n => n.MaPhim == id);
            ViewBag.tongtien = Tongtien();*/
            ViewBag.tongtien = Tongtien();
            Phim phim = db.Phims.Find(id);
            if (phim == null)
            {
                return HttpNotFound();
            }
            /*if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "Home");
            }*/
            return View(phim);
        }
        public ActionResult test()
        {
            List<GioHangItem> lstgiohang = Laygiohang();
            ViewBag.tongtien = Tongtien();

            if (lstgiohang.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(lstgiohang);
        }
        public List<GioHangItem> Laygiohang()
        {
            List<GioHangItem> lstgiohang = Session["GioHang"] as List<GioHangItem>;
            if (lstgiohang == null)
            {
                lstgiohang = new List<GioHangItem>();
                Session["GioHang"] = lstgiohang;
            }
            return lstgiohang;
        }
        public ActionResult Themgiohang(int MaPhim,string ghe, string strURL)
        {
            //
            List<GioHangItem> lstgiohang = Laygiohang();
            GioHangItem product = lstgiohang.Find(n => n.MaPhim == MaPhim);
            if (product == null)
            {
                product = new GioHangItem(MaPhim);
                lstgiohang.Add(product);


                return Redirect(strURL);

            }
            else
            {
                product.Ghe = ghe;
                product.SoLuong += 1;
                lstgiohang.Add(product);
                return Redirect(strURL);
            }
        }
        private double Tongtien()
        {
            double total = 0;
            List<GioHangItem> lstgiohang = Session["GioHang"] as List<GioHangItem>;
            if (lstgiohang != null)
            {
                total = lstgiohang.Sum(n => n.dthanhtien);
            }
            return total;
        }
    }
}