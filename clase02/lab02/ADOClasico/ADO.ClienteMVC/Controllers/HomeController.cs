using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADO.BL;
using ADO.Entidades;

namespace ADO.ClienteMVC.Controllers
{
    public class HomeController : Controller
    {
        private ProductBL productBL = new ProductBL();

        // GET: Home
        public ActionResult Index()
        {
            return View(productBL.listar().ToList());
        }
    }
}