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

		private SqlConnection con = new SqlConnection(Properties.Settings.Default.Conectar);

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