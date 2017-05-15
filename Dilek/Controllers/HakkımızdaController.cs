using Services.ContentsServices;
using Services.ImagesServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dilek.Controllers
{
    public class HakkımızdaController : Controller
    {
        public readonly IImagesServices _imagesServices;
        public readonly IContentsServices _contentsServices;
        public HakkımızdaController()
        {
        }
        public HakkımızdaController(IImagesServices imagesServices,
            IContentsServices contentsServices)
        {
            _imagesServices = imagesServices;
            _contentsServices = contentsServices;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}