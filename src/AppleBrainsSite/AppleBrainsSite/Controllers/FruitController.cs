using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppleBrainsSite.Controllers
{
    [RoutePrefix("fruit")]
    public class FruitController : Controller
    {
        // GET: Fruit
        public ActionResult Index()
        {
            return View();
        }

        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }
    }
}