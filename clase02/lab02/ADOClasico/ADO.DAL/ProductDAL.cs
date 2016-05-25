using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.Entidades;
using System.Data.SqlClient;

namespace ADO.DAL
{
    public class ProductDAL
    {
        public List<Product> Listar()
        {
            string cc = "Server=tcp:server20486csp.database.windows.net,1433;Data Source=server20486csp.database.windows.net;Initial Catalog=AdventureWorks;Persist Security Info=False;User ID=adminazure;Password=Pa$$w0rd;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            var productos = new List<Product>();

            using (var con = new SqlConnection(cc))
            {
                con.Open();

                var query = new SqlCommand(
                    "SELECT ProductID, Name, ListPrice FROM SalesLT.Product", con
                    );

                using (var dr = query.ExecuteReader())
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
    }
}
