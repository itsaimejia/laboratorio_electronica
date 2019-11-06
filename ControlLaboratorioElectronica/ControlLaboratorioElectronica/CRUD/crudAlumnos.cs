using ControlLaboratorioElectronica.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLaboratorioElectronica.CRUD
{
	public class crudAlumnos
	{
		private static Conexion con = new Conexion();
		
		private SqlCommand cmd;
		public void Alta(Alumno alumno)
		{
			string script = string.Format($"insert into Alumnos values(" +
				$"'{alumno.NoControl}','{alumno.Nombre}','{alumno.CodigoClase}')");
			cmd = new SqlCommand(script, con.AbrirConexion());
			cmd.ExecuteNonQuery();
			con.CerrarConexion();
		}

		public static List<Alumno> ObtenerAlumnos()
		{
			List<Alumno> lista = new List<Alumno>();
			string query = @"SELECT NoControl, Nombre, CodigoClase FROM Alumnos";
			SqlCommand cmd = new SqlCommand(query, con.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new Alumno
				{
					NoControl = Convert.ToString(reader["NoControl"]),
					Nombre = Convert.ToString(reader["Nombre"]),
					CodigoClase = Convert.ToString(reader["CodigoClase"])
				});
			}
			reader.Close();
			return lista;
		}

		public static List<Alumno> ObtenerAlumnosxClase(string codigoClase)
		{
			List<Alumno> grupo = ObtenerAlumnos();
			List<Alumno> extraer = new List<Alumno>();
			foreach(var item in grupo)
			{
				if (item.CodigoClase.Equals(codigoClase))
					extraer.Add(item);
			}
			return extraer;
		}
	}
}
