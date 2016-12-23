
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WedDLV.Areas.Admin.Code;
using WedDLV.Areas.Admin.Models;
using Entity;

namespace WedDLV.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(LoginModel model)
        {
            var result = new TaikhoanModel().Login(model.Username, model.Password);
            if(result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { Username = model.Username });
                //FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("","Tên đăng nhập hoặc mật khẩu không đúng !");
            }

            return View(model);
        }
        public ActionResult Logout()
        {
            SessionHelper.SetSession(null);
            return RedirectToAction("Index", "Login");
        }
    }
}