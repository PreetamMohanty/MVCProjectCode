using MVCProject2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            TempData["FirstName"] = id;
            TempData.Keep("FirstName");
            return View();
        }

        public ActionResult Redirect()
        {
            return View();
        }
        public ActionResult New()
        {
            EmpDept ed = new EmpDept { FirstName = "Preetam", DeptName = "ECE" };
            return View(ed);
        }
    }
}