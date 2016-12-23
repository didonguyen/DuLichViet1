
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;

namespace WedDLV.Areas.Admin.Controllers
{
    public class CustomerController : BaseController
    {
        // GET: Admin/Customer
        public ActionResult Index()
        {
            var CTM = new CustomerDAO();
            var model = CTM.CTMListAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult TK(int id, DateTime? Ngaybatdau, DateTime? Ngayketthuc)
        {

            var CTM = new CustomerDAO().GetById(id);
            var CTML = new CustomerDAO();
            var model = CTML.TK(id, Ngaybatdau, Ngayketthuc);
            ViewBag.RES = model;
            return View(model);

        }

        
    }
}