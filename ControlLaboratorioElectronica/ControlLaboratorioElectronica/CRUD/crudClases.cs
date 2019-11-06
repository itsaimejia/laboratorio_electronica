using ControlLaboratorioElectronica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace ControlLaboratorioElectronica.CRUD
{
	public class crudClases
	{
		private static Conexion con = new Conexion();
		
		private DataSet ds;
		private SqlCommand cmd;
		public bool Alta(Clase clase)
		{
			string query = string.Format($"INSERT INTO Clases VALUES(" +
				$"'{clase.CodigoClase}', '{clase.NoEmpleado}','{clase.Grupo}','{clase.Materia}','{clase.NombreDocente}')");
			cmd = new SqlCommand(query, con.AbrirConexion());
			int filasAfectadas = cmd.ExecuteNonQuery();
			con.CerrarConexion();
			return (filasAfectadas > 0) ? true : false;
		}

		public static List<Clase> ObtenerClases()
		{
			List<Clase> lista = new List<Clase>();
			string query = @"SELECT CodigoClase, NoEmpleado, Grupo, Materia, NombreDocente FROM Clases";
			SqlCommand cmd = new SqlCommand(query, con.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new Clase
				{
					CodigoClase = Convert.ToString(reader["CodigoClase"]),
					NoEmpleado = Convert.ToString(reader["NoEmpleado"]),
					Grupo = Convert.ToString(reader["Grupo"]),
					Materia = Convert.ToString(reader["Materia"]),
					NombreDocente = Convert.ToString(reader["NombreDocente"])
				});
			}
			reader.Close();
			return lista;
		}

		public static Clase ObtenerClase(string CodigoClase)
		{
			List<Clase> listaClases = ObtenerClases();
			Clase clase = null;
			foreach(var item in listaClases)
			{
				if (item.CodigoClase.Equals(CodigoClase))
				{
					clase = item;
					break;
				}
			}
			return clase;
		}
	}
}
