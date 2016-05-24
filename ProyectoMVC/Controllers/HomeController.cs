using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Este es el Método Index()";
        }

        public string Proceso()
        {
            return "Este es el metodo Proceso()";
        }
    }
}