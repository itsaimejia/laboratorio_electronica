using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLaboratorioElectronica.Vistas
{
	public partial class extDetalleClase : Form
	{
		public string grupo { get; set; }
		public string nombre { get; set; }
		public extDetalleClase()
		{
			InitializeComponent();
		}

		

		private void extDetalleClase_Load(object sender, EventArgs e)
		{
			lblNombre.Text = nombre;
			lblGrupo.Text = grupo;
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
