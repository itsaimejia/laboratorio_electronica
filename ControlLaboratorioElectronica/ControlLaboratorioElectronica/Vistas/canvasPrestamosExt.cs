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
	public partial class canvasPrestamosExt : Form
	{
		public canvasPrestamosExt()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		public void limpiar()
		{
			txtCarrera.Text = string.Empty;
			txtNombre.Text = string.Empty;
			txtNumControl.Text = string.Empty;
			txtNumControl.Focus();
		}

		public void habilitar()
		{
			txtNombre.Enabled = true;
			txtCarrera.Enabled = true;
			dgvMaterial.Enabled = true;
			btnGuardar.Enabled = true;
			rbEnClase.Enabled = true;
			rbExterno.Enabled = true;
			cbClases.Enabled = true;
		}

		private void txtNumControl_KeyPress(object sender, KeyPressEventArgs e)
		{
			string control = txtNumControl.Text;
			if ((int)e.KeyChar == (int)Keys.Enter)
			{

				if (txtNumControl.Text.Equals("1234"))
				{
					limpiar();
					habilitar();
					txtNumControl.Text = control;
					txtNombre.Text = "Itsai";
					txtCarrera.Text = "Sistemas";
				}
				else
				{
					limpiar();
					habilitar();
				}
			}
		}

		private void txtNumControl_OnValueChanged(object sender, EventArgs e)
		{

		}
	}
}
