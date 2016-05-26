using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCControladores.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public string Index()
        {
            return "ACCION INDEX SIN PARAMETROS";
        }

        public string Procesar(string name, string city)
        {
            return "PARAMETRO 1: " + name + " PARAMETRO 2: "+ city;
        }

        public ActionResult Listar(string titulo, int nveces=0)
        {
            ViewBag.Titulo = titulo;
            ViewBag.NumeroVeces = nveces;
            return View();
        }
    }
}