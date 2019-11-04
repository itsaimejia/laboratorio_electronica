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
	public partial class extNuevaClase : Form
	{
		public extNuevaClase()
		{
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCargarPractica_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\");
		}
	}
}
