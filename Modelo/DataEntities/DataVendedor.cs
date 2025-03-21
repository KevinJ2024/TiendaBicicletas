using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Modelo.Entities;

namespace Modelo.DataEntities
{
    public class DataVendedor : ConexionMySql
    {
        public List<VendedorEntity> MostrarVendedores()
        {
            List<VendedorEntity> vendedores = new List<VendedorEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM vendedor";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                VendedorEntity vendedorEntity = new VendedorEntity();
                vendedorEntity.ID_vendedor = dr.GetInt32(0);
                vendedorEntity.Nombre_vendedor = dr.GetString(1);
                vendedorEntity.Email = dr.GetString(2);
                vendedorEntity.salario = dr.GetInt32(3);
                vendedorEntity.telefono = dr.GetString(4);

                vendedores.Add(vendedorEntity);
            }
            return vendedores;
        }

        public int RegistrarVendedor(int ID_vendedor, string Nombre_vendedor, string Email, int salario, string telefono)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO vendedor (ID_vendedor, Nombre_vendedor, Email, salario, telefono) " +
                              "VALUES (@ID_vendedor, @Nombre_vendedor, @Email, @salario, @telefono)";

            cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
            cmd.Parameters.AddWithValue("@Nombre_vendedor", Nombre_vendedor);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@salario", salario);
            cmd.Parameters.AddWithValue("@telefono", telefono);

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}
