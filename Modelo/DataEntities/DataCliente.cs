using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities

{
    public class DataCliente : ConexionMySql
    {

        public int RegistrarCliente(int ID_cliente, string Nombre_cliente, string Email, string Telefono, string Contraseña)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO cliente (ID_cliente,Nombre_cliente,Email,Telefono,Contraseña) VALUES ('" + ID_cliente + "','" + Nombre_cliente + "','"+ Email +"','"+ Telefono +"','"+ Contraseña + "')";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public ClienteEntity ConsultarCliente(int ID_cliente)
        {
            ClienteEntity cliente = new ClienteEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM cliente WHERE ID_cliente = @ID_cliente";
            cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cliente.ID_cliente = dr.GetInt32(0);
                cliente.Nombre_cliente = dr.GetString(1);
                cliente.Email = dr.GetString(2);
                cliente.Telefono = dr.GetString(3);
                cliente.Contraseña = dr.GetString(4);

            }
            return cliente;
        }

        public List<ClienteEntity> MostrarClientes()
        {
            List<ClienteEntity> clientes = new List<ClienteEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM cliente";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ClienteEntity clienteActual = new ClienteEntity();
                clienteActual.ID_cliente = dr.GetInt32(0);
                clienteActual.Nombre_cliente = dr.GetString(1);
                clienteActual.Email = dr.GetString(2);
                clienteActual.Telefono = dr.GetString(3);
                clienteActual.Contraseña = dr.GetString(4);

                clientes.Add(clienteActual);
            }
            return clientes;
        }

        public int ActualizarCliente(int ID_cliente, string Nombre_cliente, string Email, string Telefono, string Contraseña)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE cliente SET Nombre_cliente = @Nombre_cliente, Email = @Email, Telefono = @Telefono, Contraseña = @Contraseña WHERE ID_cliente = @ID_cliente";
            cmd.Parameters.AddWithValue("@Nombre_cliente", Nombre_cliente);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
            cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int EliminarCliente(int ID_cliente)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM cliente WHERE ID_cliente = @ID_cliente";
            cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public bool VerificarCliente(string Email, string Contraseña)
        {
            bool clienteExiste = false;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM cliente WHERE Email = @Email AND Contraseña = @Contraseña";
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                clienteExiste = true;
            }

            return clienteExiste;
        }
    }
}
