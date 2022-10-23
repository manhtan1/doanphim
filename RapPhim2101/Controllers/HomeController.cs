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
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult dangky(FormCollection collection)
        {
            KhachHang kh = new KhachHang();
            var taikhoan = collection["TenDN"];
            var dienthoai = collection["DienThoai"];
            var hoten = collection["hoten"];
            var matkhau = collection["MatKhau"];
            var nhaplaimatkhau = collection["NhapLaiMatKhau"];
            var diachi = collection["DiaChi"];
            //var mk = collection["matkhau"];

            if (String.IsNullOrEmpty(taikhoan))
            {
                ViewData["Loi2"] = "Bạn chưa nhập Tài khoản!!";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Bạn chưa cài mật khẩu !!";
            }
            else if (String.IsNullOrEmpty(nhaplaimatkhau))
            {
                if (matkhau != nhaplaimatkhau)
                {
                    ViewData["Loi8"] = "Mật khẩu nhập lại không trùng với mật khẩu !!";
                }
                ViewData["Loi4"] = "Bạn phải nhập lại mật khẩu!!";
            }
            else if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi6"] = "Bạn để trống số điện thoại của bạn !!";
            }
            else if (String.IsNullOrEmpty(diachi))
            {
                ViewData["Loi7"] = "Bạn để trống địa chỉ bạn đang ở !!";
            }
            else if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Bạn để trống họ tên";
            }
            else
            {
                kh.taikhoan = taikhoan;
                kh.SDTKH = dienthoai;
                kh.TenKH = hoten;
                kh.matkhau = matkhau;
                kh.DiaChi = diachi;
                db.KhachHangs.Add(kh);
                db.SaveChanges();

                return RedirectToAction("DangNhap");
            }
            return this.DangKy();
        }
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult DangNhap(FormCollection collection)
        {
            var tendn = collection["TenDN"];
            var mk = collection["MatKhau"];
            if (string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập";
            }
            else if (string.IsNullOrEmpty(mk))
            {
                ViewData["Loi2"] = "Cần nhập mật khẩu";
            }
            else
            {
                KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.taikhoan == tendn && n.matkhau == mk );
                if (kh != null)
                {
                    ViewBag.ThongBao = "Đăng nhập thành công";
                    Session["TaiKhoan"] = kh;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ThongBao = "Tài khoản hoặc mật khẩu không chính xác"; ;
                }
            }
            return View();
        }

        public ActionResult ChitietPhim(int id)
        {
            return View(db.Phims.Find(id));
        }
    }
}