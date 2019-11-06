using ControlLaboratorioElectronica.CRUD;
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
			this.dgvDocentes.Columns[0].ReadOnly = true;
			this.dgvDocentes.Columns[1].ReadOnly = true;
			this.dgvDocentes.Columns[1].ReadOnly = true;
		}

		public void updateDataClases()
		{
			ArrayList row;
			foreach (var clase in clases)
			{
				row = new ArrayList();
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
				string grupo = datos.Cells["Grupo"].Value.ToString();
				string nombre = datos.Cells["NombreProfesor"].Value.ToString();
				string materia = datos.Cells["Materia"].Value.ToString();
				extDetalleClase extDetalleClase = new extDetalleClase()
				{
					CodigoClase = codigoClase(grupo, materia, nombre)
				};
				extDetalleClase.Show();
			}
		}

		private void btnNuevaClase_Click(object sender, EventArgs e)
		{
			extNuevaClase fr = new extNuevaClase();
			fr.Show();

			
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
		public string codigoClase(string grupo, string materia, string nombre)
		{
			return string.Format($"{grupo}{materia.Substring(0, 3)}{nombre.Substring(0, 2)}");
		}
	}
}
