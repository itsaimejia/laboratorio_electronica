using ControlLaboratorioElectronica.CRUD;
using ControlLaboratorioElectronica.Modelos;
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
				Alumno alumno = crudAlumnos.Consulta(control);
				if (alumno != null)
				{
					txtNumControl.Text = alumno.NoControl;
					txtNombre.Text = alumno.Nombre;
					habilitar();
				}
				else
				{
					habilitar();
				}
			}
		}

		
	}
}
