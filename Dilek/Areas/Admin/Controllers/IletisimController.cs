﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dilek.Areas.Admin.Controllers
{
    public class IletisimController : BaseController
    {
        // GET: Admin/Iletisim
        public ActionResult Index()
        {
            return View();
        }
    }
}