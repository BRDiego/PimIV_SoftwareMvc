using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimIV_Web.Controllers
{
    public class InicialController : Controller
    {
        // GET: Inicial
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajuda()
        {
            return View();
        }

        public ActionResult SaibaMais()
        {
            return View();
        }
    }
}