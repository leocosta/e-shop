﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult List(String id)
        {
            return View();
        }

    }
}
