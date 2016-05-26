using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace ADO.DAL
{
    public class ProductDAL
    {
        private string cc = "Server=tcp:server20486csp.database.windows.net,1433;Data Source=server20486csp.database.windows.net;Initial Catalog=AdventureWorks;Persist Security Info=False;User ID=adminazure;Password=Pa$$w0rd;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public async Task<List<Product>> Listar()
        {
            var productos = new List<Product>();

            using (var con = new SqlConnection(cc))
            {
                await con.OpenAsync();

                var query = new SqlCommand(
                    "ListarProductos", con
                    );

                using (var dr = await query.ExecuteReaderAsync())
                {
                    while (dr.Read())
                    {
                        productos.Add(new Product
                        {
                            ProductID = Convert.ToInt32(dr["ProductID"]),
                            Name = dr["Name"].ToString(),
                            ListPrice = Convert.ToDecimal(dr["ListPrice"].ToString())
                        });
                    }
                }
            }

            return productos;
        }

        public Product VerDetalle (int IDProducto)
        {
            Product product = new Product();

            using (var con = new SqlConnection(cc))
            {
                SqlCommand command = new SqlCommand("VerProducto", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@aiProductID", IDProducto);

                con.Open();

                using (var dr = command.ExecuteReader())
                {
                    if (dr.Read()){
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.Name = dr["Name"].ToString();
                        product.ListPrice = Convert.ToDecimal(dr["ListPrice"]);
                    }
                }
            }
            
            return product;
        }

        public bool EditarProducto(Product product)
        {
            bool resultadoProceso = false;

            using (var con = new SqlConnection(cc))
            {
                SqlCommand command = new SqlCommand("ActualizarProducto", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@aiProductID", product.ProductID);
                command.Parameters.AddWithValue("@asNombreProducto", product.Name);
                command.Parameters.AddWithValue("@anPrecioProducto", product.ListPrice);

                con.Open();

                int cproceso = Convert.ToInt32(command.ExecuteNonQuery());
                if (cproceso > 0)
                {
                    resultadoProceso = true;
                }
                
            }
            return resultadoProceso;
        }
    }
}
