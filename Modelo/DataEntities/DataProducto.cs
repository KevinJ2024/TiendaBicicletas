using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Modelo.Entities;

namespace Modelo.DataEntities
{
    public class DataProducto : ConexionMySql
    {
        public List<ProductoEntity> MostrarProductos()
        {
            List<ProductoEntity> productos = new List<ProductoEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM producto";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductoEntity productoEntity = new ProductoEntity();
                productoEntity.ID_producto = dr.GetInt32(0);
                productoEntity.Nombre_producto = dr.GetString(1);
                productoEntity.Precio_producto = dr.GetInt32(2);
                productoEntity.Stock = dr.GetInt32(3);
                productoEntity.Descripcion = dr.GetString(4);

            //    if (!dr.IsDBNull(5))
            //    {
            //        long tamaño = dr.GetBytes(5, 0, null, 0, 0);
            //        byte[] imagen = new byte[tamaño];
            //        dr.GetBytes(5, 0, imagen, 0, (int)tamaño);
            //        productoEntity.Imagen = imagen;
            //    }

            //    productos.Add(productoEntity);
            }
            return productos;
        }

        public int RegistrarProducto(int ID_producto, string Nombre_producto, int Precio_producto, int Stock, string Descripcion, byte[] Imagen)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO producto (ID_producto, Nombre_producto, Precio_producto, Stock, Descripcion, Imagen) " +
                              "VALUES (@ID_producto, @Nombre_producto, @Precio_producto, @Stock, @Descripcion, @Imagen)";

            cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
            cmd.Parameters.AddWithValue("@Nombre_producto", Nombre_producto);
            cmd.Parameters.AddWithValue("@Precio_producto", Precio_producto);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Imagen", Imagen);

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}
