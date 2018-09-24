using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        //GET: Products/Class 
        public ActionResult Class( String ClassName)
        {
            ViewBag.ClassName = ClassName;
            return View();
        }
    }
}