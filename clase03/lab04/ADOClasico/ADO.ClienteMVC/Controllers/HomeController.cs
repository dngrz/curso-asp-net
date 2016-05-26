using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADO.BL;
using ADO.Entidades;
using System.Threading.Tasks;

namespace ADO.ClienteMVC.Controllers
{
    public class HomeController : Controller
    {
        private ProductBL productBL = new ProductBL();

        // GET: Home
        public async Task<ActionResult> Index()
        {
            return View(await productBL.listar());
        }
    }
}