using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADO.BL;
using ADO.Entidades;
using System.Threading.Tasks;
using System.Net;

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

        public ActionResult Details(int? id) //Aceptar Nulos por el signo "?"
        {
            if (id== null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Product product = productBL.VerDetalle( Convert.ToInt32(id) );
            if(product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    }
}