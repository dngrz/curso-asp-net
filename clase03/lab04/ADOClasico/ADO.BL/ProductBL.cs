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

        public async Task<List<Product>> listar()
        {
            return await productDAL.Listar();
        }

        public Product VerDetalle (int IDProducto)
        {
            Product product = new Product();
            product = productDAL.VerDetalle(IDProducto);
            return product;
        }
    }
}
