using Domain.Domains;
using Services.ContentsServices;
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
    public class AnasayfaController : BaseController
    {
        private readonly IImagesServices _imagesServices;
        private readonly IContentsServices _contentsServices;
        public AnasayfaController(IImagesServices imagesServices
            , IContentsServices contentsService)
        {
            _imagesServices = imagesServices;
            _contentsServices = contentsService;
        }
        public ActionResult Index()
        {
            var result = new HomepageResult();
            result.Images = _imagesServices.getImagesByDBCodes(8);
            result.Contents = _contentsServices.getAllContentsByDBCode(1);
            return View(result);
        }
        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase files)
        {
            if (files != null && files.ContentLength > 0)
            {
                var fileName = Path.GetFileName(files.FileName);
                var path = Path.Combine(Server.MapPath("~/Images"), fileName);
                files.SaveAs(path);
                _imagesServices.InsertSliderImage(fileName);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult UpdateText(int ID, string title, string text,DateTime CreatedDate, int DBCode)
        {
            Contents content = new Contents() {
                CreatedDate = CreatedDate,
                DBCode = DBCode,
                ID = ID,
                Text = text,
                Title = title
            };
            _contentsServices.UpdateContent(content);
            return RedirectToAction("Index");
        }
    }
}