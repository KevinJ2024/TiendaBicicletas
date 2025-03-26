using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities
{
    public class DataProducto : ConexionMySql
    {

        public int RegistrarProducto(string Nombre_producto, decimal Precio_producto, int Stock, string Descripcion, byte[] Imagen)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO producto (Nombre_producto,precio_producto,Stock,Descripcion,Imagen) VALUES ('" + Nombre_producto + "','" + Precio_producto + "','" + Stock + "','" + Descripcion + "','" + Imagen + "')";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public ProductoEntity ConsultarProducto(int ID_producto)
        {
            ProductoEntity producto = new ProductoEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM producto WHERE ID_producto = @ID_producto";
            cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                producto.ID_producto = dr.GetInt32(0);
                producto.Nombre_producto = dr.GetString(1);
                producto.Precio_producto = dr.GetDecimal(2);
                producto.Stock = dr.GetInt32(3);
                producto.Descripcion = dr.GetString(4);
                producto.Imagen = (byte[])dr.GetValue(5);
            }
            return producto;
        }

        public List<ProductoEntity> MostrarProductos()
        {
            List<ProductoEntity> productos = new List<ProductoEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM producto";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductoEntity productoActual = new ProductoEntity();
                productoActual.ID_producto = dr.GetInt32(0);
                productoActual.Nombre_producto = dr.GetString(1);
                productoActual.Precio_producto = dr.GetDecimal(2);
                productoActual.Stock = dr.GetInt32(3);
                productoActual.Descripcion = dr.GetString(4);
                productoActual.Imagen = (byte[])dr.GetValue(5);

                productos.Add(productoActual);
            }
            return productos;
        }

        //public int ActualizarVendedor(int ID_vendedor, string Nombre_vendedor, string Email, string Telefono, decimal Salario, string Contraseña)
        //{
        //    int resultado = 0;
        //    MySqlCommand cmd = GetConnection().CreateCommand();
        //    cmd.CommandText = "UPDATE vendedor SET Nombre_vendedor = @Nombre_vendedor, Email = @Email, Telefono = @Telefono, Salario = @Salario, Contraseña = @Contraseña WHERE ID_vendedor = @ID_vendedor";
        //    cmd.Parameters.AddWithValue("@Nombre_vendedor", Nombre_vendedor);
        //    cmd.Parameters.AddWithValue("@Email", Email);
        //    cmd.Parameters.AddWithValue("@Telefono", Telefono);
        //    cmd.Parameters.AddWithValue("@Salario", Salario);
        //    cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
        //    cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
        //    resultado = cmd.ExecuteNonQuery();

        //    return resultado;
        //}

        public int EliminarProducto(int ID_producto)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM producto WHERE ID_producto = @ID_producto";
            cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

    }
}
