using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace barbari.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult single()
        {
            return View();
        }
    }
}
