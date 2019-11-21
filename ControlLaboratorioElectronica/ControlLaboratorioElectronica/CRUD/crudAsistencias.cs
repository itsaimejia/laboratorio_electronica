using ControlLaboratorioElectronica.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLaboratorioElectronica.CRUD
{
	class crudAsistencias
	{
		private static Conexion con = new Conexion();
		private static SqlCommand cmd;

		public static void Asistencia(AlmAsistencia asistencia)
		{
			string script = string.Format($"INSERT INTO Asistencias VALUES(" +
				$"'{asistencia.Fecha}','{asistencia.NoControl}','{asistencia.Asistio}','{asistencia.CodigoClase}')");
			cmd = new SqlCommand(script, con.AbrirConexion());
			cmd.ExecuteNonQuery();
			con.CerrarConexion();
		}

		public static List<AlmAsistencia> ObtenerAsistencias(string CodigoClase)
		{
			List<AlmAsistencia> lista = new List<AlmAsistencia>();
			string query = $"SELECT Fecha, NoControl, Asistencia FROM Asistencias WHERE CodigoClase='{CodigoClase}'";
			cmd = new SqlCommand(query, con.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new AlmAsistencia
				{
					Fecha = Convert.ToString(reader["Fecha"]),
					NoControl = Convert.ToString(reader["NoControl"]),
					Asistio = Convert.ToInt32(reader["Asistencia"])
				});
			}
			reader.Close();
			return lista;
		}

		public static int Actualizar(AlmAsistencia asistencia)
		{
			string script = string.Format($"UPDATE Asistencias " +
				$"SET Asistencia = '{asistencia.Asistio}' " +
				$"WHERE Fecha = '{asistencia.Fecha}' AND NoControl = '{asistencia.NoControl}' AND CodigoClase='{asistencia.CodigoClase}'");
			cmd = new SqlCommand(script, con.AbrirConexion());
			int filasAfectadas = cmd.ExecuteNonQuery();
			con.CerrarConexion();
			return filasAfectadas;

		}
	}
}
