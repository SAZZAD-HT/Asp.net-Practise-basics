using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using validation.Models;
using Validation = validation.Models.Validation;

namespace validation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
      
        public ActionResult Index()
        {
            ViewBag.Subscription = "Normal Subscription";

            ViewBag.price = new String[] { "10.00", "2.00", "3.00", "4.00" };

            return View();
        }
        [HttpGet]
        public ActionResult CreateAccount()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult CreateAccount(Validation valid )
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(valid);
        }
    }
}