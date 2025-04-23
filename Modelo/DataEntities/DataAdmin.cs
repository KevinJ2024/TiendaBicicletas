using System;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities
{
    public class DataAdmin : ConexionMySql
    {

        public bool VerificarAdmin(string Email_admin, string Contraseña_admin)
        {
            bool adminExiste = false;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM administrador WHERE Email_admin = @Email_admin AND Contraseña_admin = @Contraseña_admin";
            cmd.Parameters.AddWithValue("@Email_admin", Email_admin);
            cmd.Parameters.AddWithValue("@Contraseña_admin", Contraseña_admin);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                adminExiste = true;
            }

            return adminExiste;
        }

        public AdministradorEntity ConsultarAdmin(string Email)
        {
            AdministradorEntity admin = new AdministradorEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM administrador WHERE Email_admin = @Email_admin";
            cmd.Parameters.AddWithValue("@Email_admin", Email);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                admin.ID_admin = dr.GetInt32(0);
                admin.Nombre_admin = dr.GetString(1);
                admin.Email_admin = dr.GetString(2);
                admin.Telefono_admin = dr.GetString(3);
                admin.Contraseña_admin = dr.GetString(4);
            }

            return admin;
        }


        public int RegistrarAdmin(int ID_admin, string Nombre_admin, string Email_admin, string Telefono_admin, string Contraseña_admin)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO administrador (ID_admin, Nombre_admin, Email_admin, Telefono_admin, Contraseña_admin) VALUES (@ID_admin, @Nombre_admin, @Email_admin, @Telefono_admin, @Contraseña_admin)";
            cmd.Parameters.AddWithValue("@ID_admin", ID_admin);
            cmd.Parameters.AddWithValue("@Nombre_admin", Nombre_admin);
            cmd.Parameters.AddWithValue("@Email_admin", Email_admin);
            cmd.Parameters.AddWithValue("@Telefono_admin", Telefono_admin);
            cmd.Parameters.AddWithValue("@Contraseña_admin", Contraseña_admin);

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

    }
}