﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavaScript.Controllers
{
    public class JavaScriptController : Controller
    {
        //
        // GET: /JavaScript/
        public ActionResult CachKhaiBaoBien()
        {
            return View();
        }
        public ActionResult AngularJSAjax()
        {
            return View();
        }

        //get
        public ActionResult GetDataResponse()
        {
            return View();
        }

        //post
        public ActionResult PostDataResponse()
        {
            return View();
        }
	}
}