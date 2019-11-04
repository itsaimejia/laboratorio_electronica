using ControlLaboratorioElectronica.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLaboratorioElectronica
{
	public partial class canvasPrincipal : Form
	{
		public canvasPrincipal()
		{
			InitializeComponent();
		}

		private void canvasPrincipal_Load(object sender, EventArgs e)
		{
			update();
		}

		public void update()
		{
			ArrayList row = new ArrayList();
			row = new ArrayList();
			row.Add("4sa");
			row.Add("Dtsai Zempoatecatl Mejia");
			row.Add("Electronica");
			dgvDocentes.Rows.Add(row.ToArray());

			row = new ArrayList();
			row.Add("5sa");
			row.Add("Etsai Zempoatecatl Mejia");
			row.Add("Matematicas");
			dgvDocentes.Rows.Add(row.ToArray());

			row = new ArrayList();
			row.Add("6sa");
			row.Add("Ttsai Zempoatecatl Mejia");
			row.Add("Fisica");
			dgvDocentes.Rows.Add(row.ToArray());

			row = new ArrayList();
			row.Add("7sa");
			row.Add("Ptsai Zempoatecatl Mejia");
			row.Add("Quimica");
			dgvDocentes.Rows.Add(row.ToArray());
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
				//Método recargar informacion del data grid view
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBuscar.Text = "";
			txtBuscar.Focus();
		}



		private void dgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow datos = dgvDocentes.Rows[e.RowIndex];
			extDetalleClase extDetalleClase = new extDetalleClase();
			extDetalleClase.Show();
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
	}
}
