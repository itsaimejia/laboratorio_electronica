using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControlLaboratorioElectronica.CRUD
{
	class Conexion
	{

		static private string cadena = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\itsai\\Source\\Repos\\itsaimejia\\laboratorio_electronica\\ControlLaboratorioElectronica\\ControlLaboratorioElectronica\\LaboratorioElectronica.mdf;Integrated Security=True";
		private SqlConnection con = new SqlConnection(cadena);

		public SqlConnection AbrirConexion()
		{
			if (con.State == ConnectionState.Closed)
				con.Open();

			return con;
		}

		public SqlConnection CerrarConexion()
		{
			if (con.State == ConnectionState.Open)
				con.Close();
			return con;
		}

		
	}
}