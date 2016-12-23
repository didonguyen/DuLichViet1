using Entity;
using Entity.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WedDLV.Areas.Admin.Controllers
{
    public class TouristController : Controller
    {
        // GET: Admin/Tourist
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // GET: Admin/Tourist/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpGet]
        // GET: Admin/Tourist/Add
        public ActionResult Add(string id)
        {
            ViewBag.Madoan = id;
            ViewBag.Customer = new CustomerDAO().CTMListAll();
            return View();
        }

        [HttpGet]

        public ActionResult Add1(string Makhachhang,string Madoan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new CustomerDAO();
                    int res = model.Add(Int32.Parse(Makhachhang), Madoan);
                    if (res > 0)
                    {
                        ModelState.AddModelError("", "Thêm mới thành công");
                        return RedirectToAction("Details","Tourist_Group",new { id =  Madoan });
                    }

                }
                return RedirectToAction("Details", "Tourist_Group", new { id = Madoan });
            }
            catch
            {
                return RedirectToAction("Details", "Tourist_Group", new { id = Madoan });
            }
        }

        [HttpGet]
        // GET: Admin/Tourist_Group/Delete/5
        public ActionResult Delete(string id,string Makhachhang)
        {
            ViewBag.Madoan = id;
            var TG = new CustomerDAO().GetById(Int32.Parse(Makhachhang));
            return View(TG);
        }

        [HttpPost]
        public ActionResult Delete(Customer collection,string Madoan)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    var model = new CustomerDAO();
                    int res = model.Delete(collection.Makhachhang,Madoan);
                    if (res > 0)
                    {
                        ModelState.AddModelError("", "Xóa thành công");
                        return RedirectToAction("Details","Tourist_Group",new {id = Madoan});

                    }

                }
                return View(collection);
            }
            catch
            {
                return RedirectToAction("Delete", new { id = Madoan, Makhachhang = collection.Makhachhang.ToString() });
            }
        }

    }
}