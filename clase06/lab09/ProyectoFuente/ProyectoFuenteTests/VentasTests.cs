using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFuente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFuente.Tests
{
    [TestClass()]
    public class VentasTests
    {
        [TestMethod()]
        public void CalcularIGVTest()
        {
            Ventas ventas = new Ventas();
            double resultado = ventas.CalcularIGV(100);
            Assert.AreEqual(18, resultado);
        }
    }
}