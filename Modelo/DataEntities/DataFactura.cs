using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Modelo.DataEntities

{
	public class DataFactura : ConexionMySql
	{
<<<<<<< HEAD
<<<<<<< HEAD
        public int RegistrarFactura(int ID_cliente, int ID_vendedor, int ID_producto, DateTime Fecha)
		{
            int resultado = 0;
			MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO factura (ID_cliente, ID_vendedor, ID_producto, Fecha) VALUES ('" + ID_cliente + "','" + ID_vendedor + "','" + ID_producto + "','" + Fecha + "')";
=======
        public int RegistrarFactura(int ID_cliente, int ID_vendedor, DateTime Fecha)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "CALL registrar_factura(@ID_cliente, @ID_vendedor, @Fecha)";

            cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
            cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);

>>>>>>> e2f8aee21698a9c72cd83aa099f483864c140912
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public FacturaEntity ConsultarFactura(int ID_factura)
        {
            FacturaEntity factura = new FacturaEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM factura WHERE ID_factura = @ID_factura";
            cmd.Parameters.AddWithValue("@ID_factura", ID_factura);
			MySqlDataReader dr = cmd.ExecuteReader();

<<<<<<< HEAD
			while (dr.Read())
			{
                factura.ID_cliente = dr.GetInt32(0);
                factura.ID_vendedor = dr.GetInt32(1);
                factura.ID_producto = dr.GetInt32(2);
=======
            while (dr.Read())
            {
                factura.ID_factura= dr.GetInt32(0);
                factura.ID_cliente = dr.GetInt32(1);
                factura.ID_vendedor = dr.GetInt32(2);
>>>>>>> e2f8aee21698a9c72cd83aa099f483864c140912
                factura.Fecha = dr.GetDateTime(3);
                factura.Total = dr.GetDecimal(4);

			}
            return factura;
		}

        public List<FacturaEntity> MostrarFacturas()
        {
            List<FacturaEntity> facturas = new List<FacturaEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM factura";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
		{
                FacturaEntity facturaActual = new FacturaEntity();
                facturaActual.ID_factura = dr.GetInt32(0);
                facturaActual.ID_cliente = dr.GetInt32(1);
                facturaActual.ID_vendedor = dr.GetInt32(2);
                facturaActual.Fecha = dr.GetDateTime(3);
                facturaActual.Total = dr.GetDecimal(4);

            resultado = cmd.ExecuteNonQuery();

                facturas.Add(facturaActual);
            }
            return facturas;
		}

=======
        public int RegistrarFactura(int ID_cliente, int ID_vendedor, int ID_producto, DateTime Fecha)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO factura (ID_cliente, ID_vendedor, ID_producto, Fecha) " +
                              "VALUES (@ID_cliente, @ID_vendedor, @ID_producto, @Fecha)";

            cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
            cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
            cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public FacturaEntity ConsultarFactura(int ID_factura)
        {
            FacturaEntity factura = new FacturaEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM factura WHERE ID_factura = @ID_factura";
            cmd.Parameters.AddWithValue("@ID_factura", ID_factura);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                factura.ID_factura= dr.GetInt32(1);
                factura.ID_cliente = dr.GetInt32(2);
                factura.ID_vendedor = dr.GetInt32(3);
                factura.ID_producto = dr.GetInt32(4);
                factura.Fecha = dr.GetDateTime(5);

            }
            return factura;
        }

        public List<FacturaEntity> MostrarFacturas()
        {
            List<FacturaEntity> facturas = new List<FacturaEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM factura";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                FacturaEntity facturaActual = new FacturaEntity();
                facturaActual.ID_factura = dr.GetInt32(0);
                facturaActual.ID_cliente = dr.GetInt32(1);
                facturaActual.ID_vendedor = dr.GetInt32(2);
                facturaActual.ID_producto = dr.GetInt32(3);
                facturaActual.Fecha = dr.GetDateTime(4);


                facturas.Add(facturaActual);
            }
            return facturas;
        }

>>>>>>> ee4cced6066a2a30304e6ef147a90dd2ff44c696
        //public int ActualizarFactura(int ID_cliente, int ID_vendedor, int ID_producto, DateTime Fecha)
        //{
        //    int resultado = 0;
        //    MySqlCommand cmd = GetConnection().CreateCommand();
        //    cmd.CommandText = "UPDATE cliente SET I = @Nombre_cliente, Email = @Email, Telefono = @Telefono, Contraseña = @Contraseña WHERE ID_cliente = @ID_cliente";
        //    cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
        //    cmd.Parameters.AddWithValue("@ID_vendedor", ID_vendedor);
        //    cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
        //    cmd.Parameters.AddWithValue("@Fecha", Fecha);
        //    resultado = cmd.ExecuteNonQuery();

        //    return resultado;
        //}
<<<<<<< HEAD
	}
=======
    }
>>>>>>> ee4cced6066a2a30304e6ef147a90dd2ff44c696
}