using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using EFWeb.Models;

namespace EFWeb.Controllers.Tests
{
    [TestClass()]
    public class CategoriesControllerTests
    {

        [TestMethod()]
        public void IndexTest()
        {
            //Instanciar la Clase
            CategoriesController controlador = new CategoriesController();
            //Obtener resultado
            var resultado = controlador.Index() as ViewResult;
            //Comparar resultado real vs esperado
            Assert.AreEqual("Index", resultado.ViewName);
        }
    }
}