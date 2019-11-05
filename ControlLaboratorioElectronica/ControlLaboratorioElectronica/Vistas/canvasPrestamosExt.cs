﻿using System;
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
		}

		private void txtNumControl_KeyPress(object sender, KeyPressEventArgs e)
		{ 
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				if (txtNumControl.Text.Equals("1234"))
				{
					habilitar();
					txtNombre.Text = "Itsai";
					txtCarrera.Text = "Sistemas";
				}
				else
				{
					habilitar();
				}
			}
		}
	}
}
