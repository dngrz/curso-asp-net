using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.Entidades;
using ADO.DAL;

namespace ADO.BL
{
    public class ProductBL
    {
        private ProductDAL productDAL = new ProductDAL();

        public List<Product> listar()
        {
            return productDAL.Listar();
        }
    }
}
