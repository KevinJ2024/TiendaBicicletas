using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo.DataEntities

{
	public class DataFactura : ConexionMySql
	{
		public List<FacturaEntity> MostrarFactura()
		{
			List<FacturaEntity> clientes = new List<FacturaEntity>();
			MySqlCommand cmd = GetConnection().CreateCommand();
			cmd.CommandText = "SELECT * FROM users where ID_cliente = ";
			MySqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				FacturaEntity facturaEntity = new FacturaEntity();
				facturaEntity.ID_factura = dr.GetInt32(0);
                facturaEntity.ID_cliente = dr.GetInt32(1);
				facturaEntity.ID_vendedor = dr.GetInt32(2);
				facturaEntity.ID_producto = dr.GetInt32(3);
				facturaEntity.Fecha = dr.GetDateTime(4);
					clientes.Add(facturaEntity);
			}
			return clientes;
		}

		public int RegistrarFactura(int ID_factura , int ID_cliente, int ID_vendedor, int ID_producto, DateTime Fecha)

		{
			int resultado = 0;
			MySqlCommand cmd = GetConnection().CreateCommand();
			cmd.CommandText = "INSERT INTO users (ID_factura,ID_cliente,ID_vendedor,ID_producto,Fecha) VALUES ('" + ID_factura + "','" + ID_cliente + "','" + ID_vendedor + "','" + ID_producto + "','" + Fecha +"')";

            resultado = cmd.ExecuteNonQuery();

			return resultado;
		}

	}
}