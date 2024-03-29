﻿using ControlLaboratorioElectronica.Modelos;
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
		
		private static SqlCommand cmd;
		public static void Alta(Alumno alumno)
		{
			if (Consulta(alumno.NoControl)==null)
			{
				string script = string.Format($"INSERT INTO Alumnos values(" +
				$"'{alumno.NoControl}','{alumno.Nombre}')");
				
				cmd = new SqlCommand(script, con.AbrirConexion());
				cmd.ExecuteNonQuery();
				con.CerrarConexion();
				AlumnoClase(alumno.NoControl, alumno.CodigoClase);
			}
			else
			{
				AlumnoClase(alumno.NoControl, alumno.CodigoClase);
			}
		}

		public static Alumno Consulta(string NoControl)
		{
			Alumno alumno = null;
			string query = $"SELECT * FROM Alumnos WHERE NoControl='{NoControl}'";
			SqlCommand cmd = new SqlCommand(query, con.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				alumno=new Alumno
				{
					NoControl = Convert.ToString(reader["NoControl"]),
					Nombre = Convert.ToString(reader["Nombre"])
				};
			}
			reader.Close();
			return alumno;
		}
	
		public static List<Alumno> ObtenerAlumnos()
		{
			List<Alumno> lista = new List<Alumno>();
			string query = @"SELECT NoControl, Nombre FROM Alumnos";
			cmd = new SqlCommand(query, con.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				lista.Add(new Alumno
				{
					NoControl = Convert.ToString(reader["NoControl"]),
					Nombre = Convert.ToString(reader["Nombre"])
				});
			}
			reader.Close();
			return lista;
		}

		public static List<Alumno> ObtenerAlumnosxClase(string codigoClase)
		{
			List<Alumno> extraer = new List<Alumno>();
			string query = $"SELECT Alumnos.NoControl, Alumnos.Nombre, AlumnoClase.CodigoClase " +
				$"FROM AlumnoClase " +
				$"INNER JOIN Alumnos ON AlumnoClase.NoControl = Alumnos.NoControl " +
				$"WHERE AlumnoClase.CodigoClase = '{codigoClase}'";
			SqlCommand cmd = new SqlCommand(query, con.AbrirConexion());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				extraer.Add(new Alumno
				{
					NoControl = Convert.ToString(reader["NoControl"]),
					Nombre = Convert.ToString(reader["Nombre"]),
					CodigoClase = Convert.ToString(reader["CodigoClase"])
				});
			}
			reader.Close();
			return extraer;
		}

		
		private static void AlumnoClase(string NoControl, string CodigoClase)
		{
			string script = string.Format($"INSERT INTO AlumnoClase values(" +
				$"'{NoControl}','{CodigoClase}')");
			cmd = new SqlCommand(script, con.AbrirConexion());
			cmd.ExecuteNonQuery();
			con.CerrarConexion();
		}
	}
}
