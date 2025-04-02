using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities
{
    public class DataProveedor : ConexionMySql
    {
        public int RegistrarProveedor(int ID_proveedor, string Nombre_proveedor, string Email, string Telefono)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO proveedor (ID_proveedor,Nombre_proveedor,Email,Telefono) VALUES ('" + ID_proveedor + "','" + Nombre_proveedor + "','" + Email + "','" + Telefono + "')";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public ProveedorEntity ConsultarProveedor(int ID_proveedor)
        {
            ProveedorEntity proveedor = new ProveedorEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM proveedor WHERE ID_proveedor = @ID_proveedor";
            cmd.Parameters.AddWithValue("@ID_proveedor", ID_proveedor);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                proveedor.ID_proveedor = dr.GetInt32(0);
                proveedor.Nombre_proveedor = dr.GetString(1);
                proveedor.Email = dr.GetString(2);
                proveedor.Telefono = dr.GetString(3);

            }
            return proveedor;
        }

        public List<ProveedorEntity> MostrarProveedores()
        {
            List<ProveedorEntity> proveedores = new List<ProveedorEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM proveedor";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProveedorEntity proveedorActual = new ProveedorEntity();
                proveedorActual.ID_proveedor = dr.GetInt32(0);
                proveedorActual.Nombre_proveedor = dr.GetString(1);
                proveedorActual.Email = dr.GetString(2);
                proveedorActual.Telefono = dr.GetString(3);

                proveedores.Add(proveedorActual);
            }
            return proveedores;
        }

        public int ActualizarProveedor(int ID_proveedor, string Nombre_proveedor, string Email, string Telefono)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE proveedor SET Nombre_proveedor = @Nombre_proveedor, Email = @Email, Telefono = @Telefono WHERE ID_proveedor = @ID_proveedor";
            cmd.Parameters.AddWithValue("@Nombre_proveedor", Nombre_proveedor);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@ID_proveedor", ID_proveedor);
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int EliminarProveedor(int ID_proveedor)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM proveedor WHERE ID_proveedor = @ID_proveedor";
            cmd.Parameters.AddWithValue("@ID_proveedor", ID_proveedor);
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}
