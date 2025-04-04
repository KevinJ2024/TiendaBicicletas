using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities
{
    public class DataProductoFactura : ConexionMySql
    {
        public int RegistrarProductoFactura(int ID_factura, int ID_producto, int Cantidad)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO productofactura (ID_factura, ID_producto, Cantidad) " +
                              "VALUES (@ID_factura, @ID_producto, @Cantidad)";

            cmd.Parameters.AddWithValue("@ID_factura", ID_factura);
            cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public List<ProductoFacturaEntity> ConsultarProductosFacturas(int ID_factura)
        {
            List<ProductoFacturaEntity> productosfacturas = new List<ProductoFacturaEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM productofactura WHERE ID_factura = @ID_factura";
            cmd.Parameters.AddWithValue("@ID_factura", ID_factura);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductoFacturaEntity productofacturaActual = new ProductoFacturaEntity();
                productofacturaActual.ID_productofactura = dr.GetInt32(0);
                productofacturaActual.ID_factura = dr.GetInt32(1);
                productofacturaActual.ID_producto = dr.GetInt32(2);
                productofacturaActual.Cantidad = dr.GetInt32(3);

                productosfacturas.Add(productofacturaActual);
            }
            return productosfacturas;
        }

        public List<ProductoFacturaEntity> MostrarProductoFactura()
        {
            List<ProductoFacturaEntity> productosfacturas = new List<ProductoFacturaEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM productofactura";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductoFacturaEntity productofacturaActual = new ProductoFacturaEntity();
                productofacturaActual.ID_productofactura = dr.GetInt32(0);
                productofacturaActual.ID_factura = dr.GetInt32(1);
                productofacturaActual.ID_producto = dr.GetInt32(2);
                productofacturaActual.Cantidad = dr.GetInt32(3);


                productosfacturas.Add(productofacturaActual);
            }
            return productosfacturas;
        }
    }
}
