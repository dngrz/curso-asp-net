using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFuente
{
    public class Ventas
    {
        public double CalcularIGV(double montoFactura)
        {
            double resultado;
            resultado = montoFactura * 0.18;
            return resultado;
        }
    }
}
