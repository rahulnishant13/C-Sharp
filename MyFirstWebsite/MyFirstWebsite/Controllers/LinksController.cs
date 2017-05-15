using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    public class LinksController : Controller
    {
        //
        // GET: /Links/
        public ActionResult Index()
        {
            ViewBag.Message = "Rahul Nishant";
            return View();
        }
	}
}