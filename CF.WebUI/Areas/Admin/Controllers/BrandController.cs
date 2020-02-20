using CF.Common.Tools;
using CF.Model.Entities;
using CF.Model.Enums;
using CF.Service.Options;
using PagedList;
using System;
using System.Web;
using System.Web.Mvc;

namespace CF.WebUI.Areas.Admin.Controllers
{
    public class BrandController : Controller
    {
        BrandService db = new BrandService();

        public ActionResult Index(int? page)
        {
            return View(db.GetActive().ToPagedList(page ?? 1, 10));
        }

        public ActionResult Add()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Add")]
        public ActionResult AddCompleted(Brand model, HttpPostedFileBase LogoImagePath)
        {
            if (ModelState.IsValid)
            {
                if (!db.Any(x => x.BrandName == model.BrandName))
                {
                    string ImagePath = ImageUtility.Upload("~/Uploads/BrandLogos/", model.BrandName, LogoImagePath);

                    if (ImagePath == "0")
                    {
                        ViewBag.ErrorImage = "Bu dosya adına sahip bir görsel mevcut";

                        return View();
                    }
                    else if (ImagePath == "1")
                    {
                        ViewBag.ErrorImage = "Lütfen geçerli bir dosya seçin";

                        return View();
                    }
                    else
                    {
                        model.Active = Active.Aktif;
                        model.Id = Guid.NewGuid();
                        model.LogoImagePath = ImagePath;
                        db.Add(model);
                        db.Save();
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ViewBag.Error = "Bu marka daha önce tanımlanmış";

                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(Guid Id)
        {
            return View(db.GetById(Id));
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Edit")]
        public ActionResult EditCompleted(Brand model)
        {
            Brand brand = db.GetById(model.Id);
            brand.BrandName = model.BrandName;
            brand.ListOrder = model.ListOrder;
            brand.Active = model.Active;

            if (ModelState.IsValid)
            {
                db.Update(brand);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Remove(Guid Id)
        {
            return View(db.GetById(Id));
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Remove")]
        public ActionResult RemoveCompleted(Brand model)
        {
            Brand brand = db.GetById(model.Id);

            brand.RemovedBy = Guid.NewGuid();
            brand.RemovedDate = DateTime.Now;
            brand.Status = Status.Deleted;
            db.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Removed(int? page)
        {
            return View(db.GetDeleted().ToPagedList(page ?? 1, 10));
        }

        public ActionResult Deactive(Guid Id)
        {
            db.GetById(Id).Active = Active.Pasif;
            db.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Reactive(Guid Id)
        {
            db.GetById(Id).Active = Active.Aktif;
            db.Save();

            return RedirectToAction("Index");
        }

        public ActionResult EditLogo(Guid Id)
        {
            return View(db.GetById(Id));
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("EditLogo")]
        public ActionResult EditLogoCompleted(Brand model, HttpPostedFileBase LogoImagePath)
        {
            Brand brand = db.GetById(model.Id);
            
            ImageUtility.Delete(brand.LogoImagePath);
            string ImagePath = ImageUtility.Upload("~/Uploads/BrandLogos/", brand.BrandName, LogoImagePath);

            if (ImagePath == "0")
            {
                ViewBag.ErrorImage = "Bu dosya adına sahip bir görsel mevcut";

                return View();
            }
            else if (ImagePath == "1")
            {
                ViewBag.ErrorImage = "Lütfen geçerli bir dosya seçin";

                return View();
            }
            else
            {
                brand.LogoImagePath = ImagePath;
                db.Save();
                return RedirectToAction("Index");
            }
        }
    }
}