using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities
{
    public class DataVendedor : ConexionMySql
    {

        public int RegistrarVendedor(int ID_vendedor, string Nombre_vendedor, string Email, string Telefono, decimal Salario, string Contraseña)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO vendedor (ID_vendedor,Nombre_vendedor,Email,Telefono,Salario,Contraseña) VALUES ('" + ID_vendedor + "','" + Nombre_vendedor + "','" + Email + "','" + Telefono + "','" + Salario + "','" + Contraseña + "')";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public VendedorEntity ConsultarVendedor(int ID_vendedor)
        {
            VendedorEntity vendedor = new VendedorEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM vendedor WHERE ID_vendedor = @ID_vendedor";
            cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                vendedor.ID_vendedor = dr.GetInt32(0);
                vendedor.Nombre_vendedor = dr.GetString(1);
                vendedor.Email = dr.GetString(2);
                vendedor.Telefono = dr.GetString(3);
                vendedor.Salario = dr.GetDecimal(4);
                vendedor.Contraseña = dr.GetString(5);

            }
            return vendedor;
        }

        public List<VendedorEntity> MostrarVendedores()
        {
            List<VendedorEntity> vendedores = new List<VendedorEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM vendedor";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                VendedorEntity vendedorActual = new VendedorEntity();
                vendedorActual.ID_vendedor = dr.GetInt32(0);
                vendedorActual.Nombre_vendedor = dr.GetString(1);
                vendedorActual.Email = dr.GetString(2);
                vendedorActual.Telefono = dr.GetString(3);
                vendedorActual.Salario = dr.GetDecimal(4);
                vendedorActual.Contraseña = dr.GetString(5);

                vendedores.Add(vendedorActual);
            }
            return vendedores;
        }

        public int ActualizarVendedor(int ID_vendedor, string Nombre_vendedor, string Email, string Telefono, decimal Salario, string Contraseña)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE vendedor SET Nombre_vendedor = @Nombre_vendedor, Email = @Email, Telefono = @Telefono, Salario = @Salario, Contraseña = @Contraseña WHERE ID_vendedor = @ID_vendedor";
            cmd.Parameters.AddWithValue("@Nombre_vendedor", Nombre_vendedor);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
            cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int EliminarVendedor(int ID_vendedor)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM vendedor WHERE ID_vendedor = @ID_vendedor";
            cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}
