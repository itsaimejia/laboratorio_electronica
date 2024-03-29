﻿using ControlLaboratorioElectronica.CRUD;
using ControlLaboratorioElectronica.Modelos;
using ControlLaboratorioElectronica.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlLaboratorioElectronica
{
	public partial class canvasPrincipal : Form
	{
		static List<Clase> clases;
		public canvasPrincipal()
		{
			InitializeComponent();
			recargaListado();
		}

		private void canvasPrincipal_Load(object sender, EventArgs e)
		{
			updateDataClases();
			recargaListado();
			RefrescarTabla();
		}

		public void updateDataClases()
		{
			ArrayList row;
			foreach (var clase in clases)
			{
				row = new ArrayList();
				row.Add(clase.CodigoClase);
				row.Add(clase.Grupo);
				row.Add(clase.NombreDocente);
				row.Add(clase.Materia);
				dgvDocentes.Rows.Add(row.ToArray());
			}

		}

		private void txtBuscar_OnValueChanged(object sender, EventArgs e)
		{
			if (txtBuscar.Text != "")
			{
				dgvDocentes.CurrentCell = null;
				foreach (DataGridViewRow r in dgvDocentes.Rows)
				{
					r.Visible = false;
				}
				foreach (DataGridViewRow r in dgvDocentes.Rows)
				{
					foreach (DataGridViewCell c in r.Cells)
					{
						if (c.Value.ToString().ToUpper().IndexOf(txtBuscar.Text.ToUpper()) == 0)
						{
							r.Visible = true;
							break;
						}
					}
				}
			}
			else
			{
				RefrescarTabla();
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBuscar.Text = "";
			txtBuscar.Focus();
		}

		public void RefrescarTabla()
		{
			dgvDocentes.Rows.Clear();
			dgvDocentes.Refresh();
			updateDataClases();
		}


		private void dgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			if (dgvDocentes.Columns[e.ColumnIndex].Name.Equals("Detalles"))
			{
				DataGridViewRow datos = dgvDocentes.Rows[e.RowIndex];
				string codigoClase = datos.Cells["Codigo"].Value.ToString();
				extDetalleClase extDetalleClase = new extDetalleClase()
				{
					CodigoClase = codigoClase,
					HoraEntrada = DateTime.Now.ToString("h:mm:ss")
				};
				extDetalleClase.Show();
				minimizarFormPrincipal();
			}
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDate.Text = string.Format($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToString("h:mm:ss")}");
		}

		private void bunifuImageButton1_Click_1(object sender, EventArgs e)
		{
			recargaListado();
			RefrescarTabla();
		}

		private void recargaListado()
		{
			clases = crudClases.ObtenerClases();
		}
		private void btnNueva_Click(object sender, EventArgs e)
		{
			extNuevaClase fr = new extNuevaClase();
			fr.Show();
			minimizarFormPrincipal();

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			string CodigoClase = Microsoft.VisualBasic.Interaction.InputBox("Ingrese código de clase","Consulta de clase","").ToUpper();
			if (CodigoClase != string.Empty)
			{
				if (crudClases.ObtenerClase(CodigoClase) != null)
				{
					extConsultaClase fr = new extConsultaClase();
					fr.CodigoClase = CodigoClase;
					fr.Show();
					minimizarFormPrincipal();
				}
				else
				{
					MessageBox.Show("La clase que buscas no existe\nO se encuentra inactiva\n", "Prueba con un código diferente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			}
		}

		private static void minimizarFormPrincipal()
		{
			foreach (Form frm in Application.OpenForms)
			{
				if (frm.GetType() == typeof(FormPrincipal))
				{
					frm.WindowState = FormWindowState.Minimized;
					break;
				}
			}
		}

		private void btnApagar_Click(object sender, EventArgs e)
		{
			string CodigoClase = Microsoft.VisualBasic.Interaction.InputBox("Ingrese código de clase", "Desactivar clase","").ToUpper();
			if (CodigoClase != string.Empty)
			{
				if (crudClases.ObtenerClase(CodigoClase) != null)
				{
					DialogResult result = MessageBox.Show($"Vas a descativar la clase: {CodigoClase}\n¿Deseas continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.Yes)
					{
						if (crudClases.DesactivarClase(CodigoClase))
						{
							MessageBox.Show("Clase desactivada", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							recargaListado();
							RefrescarTabla();
						}
						else
							MessageBox.Show("La clase no fue desactivada\nPrueba después", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("La clase que buscas no existe\nO ya se encuentra inactiva\n", "Prueba con un código diferente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			string CodigoClase = Microsoft.VisualBasic.Interaction.InputBox("Ingrese código de clase", "Eliminar clase", "").ToUpper();
			if (CodigoClase != string.Empty)
			{
				if (crudClases.ObtenerClase(CodigoClase) != null)
				{
					DialogResult result = MessageBox.Show($"Vas a eliminar la clase: {CodigoClase}\n¿Deseas continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.Yes)
					{
						if (crudClases.EliminarClase(CodigoClase))
						{
							MessageBox.Show("Clase eliminada", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							recargaListado();
							RefrescarTabla();
						}
						else
							MessageBox.Show("La clase no fue eliminada\nPrueba después", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("La clase que buscas no existe", "Prueba con un código diferente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}
