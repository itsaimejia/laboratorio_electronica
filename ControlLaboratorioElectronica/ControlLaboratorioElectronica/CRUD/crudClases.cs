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
		private static SqlCommand cmd;
		public bool Alta(Clase clase)
		{
			string query = string.Format($"INSERT INTO Clases VALUES(" +
				$"'{clase.CodigoClase}', '{clase.NoEmpleado}','{clase.Grupo}','{clase.Materia}','{clase.NombreDocente}','{clase.Activa}')");
			cmd = new SqlCommand(query, con.AbrirConexion());
			int filasAfectadas = cmd.ExecuteNonQuery();
			con.CerrarConexion();
			return (filasAfectadas > 0) ? true : false;
		}

		public static List<Clase> ObtenerClases()
		{
			List<Clase> lista = new List<Clase>();
			string query = "SELECT * FROM Clases WHERE Activa = 1";
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
			Clase clase = null;
			string query = $"SELECT * FROM Clases WHERE CodigoClase='{CodigoClase}' AND Activa = 1";
			SqlCommand cmd = new SqlCommand(query, con.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				clase = new Clase()
				{
					CodigoClase = Convert.ToString(reader["CodigoClase"]),
					NoEmpleado = Convert.ToString(reader["NoEmpleado"]),
					Grupo = Convert.ToString(reader["Grupo"]),
					Materia = Convert.ToString(reader["Materia"]),
					NombreDocente = Convert.ToString(reader["NombreDocente"])
				};
			}
			reader.Close();
			return clase;
		}

		public static bool GuardarClaseConcluida(ClaseConcluida clase)
		{
			string query = string.Format($"INSERT INTO ClasesConcluidas VALUES(" +
				$"'{clase.Fecha}', '{clase.HoraEntrada}','{clase.HoraSalida}','{clase.CodigoClase}','{clase.Aula}','{clase.NoPractica}','{clase.NombrePractica}')");
			cmd = new SqlCommand(query, con.AbrirConexion());
			int filasAfectadas = cmd.ExecuteNonQuery();
			con.CerrarConexion();
			return (filasAfectadas > 0) ? true : false;
		}

		public static bool DesactivarClase(string CodigoClase)
		{
			string query = string.Format($"UPDATE Clases " +
				$"SET Activa = 0" +
				$"WHERE CodigoClase = '{CodigoClase}'");
			cmd = new SqlCommand(query, con.AbrirConexion());
			int filasAfectadas = cmd.ExecuteNonQuery();
			con.CerrarConexion();
			return (filasAfectadas > 0) ? true : false;
		}
	}
}
