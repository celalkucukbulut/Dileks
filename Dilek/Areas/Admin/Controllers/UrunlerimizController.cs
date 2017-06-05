using Domain.Enums;
using Services.ContentsServices;
using Services.DBCodesServices;
using Services.ImagesServices;
using Services.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dilek.Areas.Admin.Controllers
{
    public class UrunlerimizController : BaseController
    {
        public readonly IImagesServices _imagesServices;
        public readonly IDBCodesServices _dbCodesServices;
        public readonly IContentsServices _contentsServices;
        public UrunlerimizController()
        {
        }
        public UrunlerimizController(IImagesServices imagesServices,
            IContentsServices contentsServices,
            IDBCodesServices dbCodesServices)
        {
            _imagesServices = imagesServices;
            _contentsServices = contentsServices;
            _dbCodesServices = dbCodesServices;
        }
        public ActionResult Index()
        {
            var result = new ProductResult();
            result.Images = _imagesServices.getAllProducts();
            result.Contents = _contentsServices.getAllProductContents();
            result.Gender = Gender.Female;
            return View(result);
        }
        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase files, string text,Gender gender)
        {
            int a = (int)gender;
            if (files != null && files.ContentLength > 0)
            {
                var fileName = Path.GetFileName(files.FileName);
                var path = Path.Combine(Server.MapPath("~/Images"), fileName);
                files.SaveAs(path);
                _imagesServices.InsertImage(fileName, text,(int)gender);
            }
            return RedirectToAction("Index");
        }
    }
}