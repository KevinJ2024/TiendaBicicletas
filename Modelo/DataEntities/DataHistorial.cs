using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities
{
    public class DataHistorial : ConexionMySql
    {
        public int IngresarProducto(int ID_cliente, int ID_producto)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO historial (ID_cliente, ID_producto) " +
                              "VALUES (@ID_cliente, @ID_producto)";

            cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
            cmd.Parameters.AddWithValue("@ID_Producto", ID_producto);

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public HistorialEntity ConsultarHistorial(int ID_producto)
        {
            HistorialEntity productoHistorial = new HistorialEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM historial WHERE ID_producto = @ID_producto";
            cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                productoHistorial.ID_cliente = dr.GetInt32(1);
                productoHistorial.ID_producto = dr.GetInt32(2);
            }
            return productoHistorial;
        }

        public List<HistorialEntity> MostrarProductos()
        {
            List<HistorialEntity> productosHistorial = new List<HistorialEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM historial";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                HistorialEntity productoHistorialActual = new HistorialEntity();
                productoHistorialActual.ID_cliente = dr.GetInt32(1);
                productoHistorialActual.ID_producto = dr.GetInt32(2);

                productosHistorial.Add(productoHistorialActual);
            }
            return productosHistorial;
        }

    }
}
