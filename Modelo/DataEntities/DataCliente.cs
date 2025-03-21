using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;
namespace Modelo

{
    public class DataCliente : ConexionMySql
    {
        public List<ClienteEntity> MostrarCliente()
        {
            List<ClienteEntity> clientes = new List<ClienteEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM users where ID_cliente = ";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ClienteEntity clienteActual = new ClienteEntity();
                clienteActual.ID_cliente = dr.GetInt32(0);
                clienteActual.Nombre_cliente = dr.GetString(1);
                clienteActual.Email = dr.GetString(2);
                clienteActual.Telefono = dr.GetString(3);

                clientes.Add(clienteActual);
            }
            return clientes;
        }

        public int RegistrarCliente(int ID_cliente, string Nombre_cliente, string Email, string Telefono)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO users (ID_cliente,Nombre_cliente,Email,Telefono) VALUES ('" + ID_cliente + "','" + Nombre_cliente + "','"+ Email +"','"+ Telefono +"')";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

    }
}
