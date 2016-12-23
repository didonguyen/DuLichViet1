using Entity;
using Entity.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace WedDLV.Areas.Admin.Controllers
{
    public class Tourist_GroupController : BaseController
    {
        // GET: Admin/Tourist_Group
        public ActionResult Index()
        {
            var TG = new Tourist_GroupModel();
            var model = TG.ListAll();
            return View(model);
        }

        [HttpGet]
        // GET: Admin/Tourist_Group/Details/5
        public ActionResult Details(string id)
        {
            var TG = new Tourist_GroupModel().GetById(id);
            ViewBag.Customers = new CustomerDAO().ListAll(id);
            return View(TG);
        }

       
        [HttpGet]
        // GET: Admin/Tourist_Group/Create
        public ActionResult Create()
        {
            ViewBag.Tour = new TourModel().TourListAll();
            
            return View();
        }
        [HttpGet]
        // GET: Admin/Tourist_Group/AjaxLoadTourById/5
        [WebMethod]
        public string AjaxLoadTourById(string id)
        {
            var jsonSerialiser = new JavaScriptSerializer();
            var CT = new TourModel().TourListID(id);
            var json = jsonSerialiser.Serialize(CT);
            return json;
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            ViewBag.Tour = new TourModel().TourListAll();
            var TG = new Tourist_GroupModel().GetById(id);
            return View(TG);
        }

        // POST: Admin/Tourist_Group/Create
        [ValidateAntiForgeryToken]
        [HttpPost]

        public ActionResult Create(Tourist_Group collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var model = new Tourist_GroupModel();
                    int res = model.Create(collection.Madoan,collection.Matour,collection.Tendoan,collection.Chuongtrinhthamquan,collection.Ngaykhoihanh,collection.Ngayketthuc,collection.Phuongtien);
                    if(res>0)
                    {
                        ModelState.AddModelError("", "Thêm mới thành công");
                        return RedirectToAction("Index");
                    }
                    
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Edit(Tourist_Group collection)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var model = new Tourist_GroupModel();
                    int res = model.Edit(collection.Madoan,collection.Matour, collection.Tendoan, collection.Chuongtrinhthamquan, collection.Ngaykhoihanh, collection.Ngayketthuc, collection.Phuongtien);
                    if (res > 0)
                    {
                        ModelState.AddModelError("", "Sửa thành công");
                        return RedirectToAction("Index");

                    }

                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        // GET: Admin/Tourist_Group/Delete/5
        public ActionResult Delete(string id)
        {
            var TG = new Tourist_GroupModel().GetById(id);
            return View(TG);
        }

        // POST: Admin/Tourist_Group/Delete/5
        [HttpPost]
        public ActionResult Delete(Tourist_Group collection)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    var model = new Tourist_GroupModel();
                    int res = model.Delete(collection.Madoan);
                    if (res > 0)
                    {
                        ModelState.AddModelError("", "Xóa thành công");
                        return RedirectToAction("Index");

                    }

                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }
    }
}
