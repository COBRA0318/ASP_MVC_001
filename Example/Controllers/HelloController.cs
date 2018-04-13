using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Example.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult HelloView()
		{
			Hello hl = new Hello();
			hl.Str1 = this.Request.QueryString["prm1"];
			hl.Str2 = this.Request.QueryString["prm2"];
			return View(hl);
		}

    }
}