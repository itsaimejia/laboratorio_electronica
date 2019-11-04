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

		public extDetalleClase()
		{
			InitializeComponent();
			
		}


		

		private void extDetalleClase_Load(object sender, EventArgs e)
		{
			
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void txtBuscarNum_OnValueChanged(object sender, EventArgs e)
		{
			if (txtBuscarNum.Text != "")
			{
				dgvListaAlumnos.CurrentCell = null;
				foreach (DataGridViewRow r in dgvListaAlumnos.Rows)
				{
					r.Visible = false;
				}
				foreach (DataGridViewRow r in dgvListaAlumnos.Rows)
				{
					foreach (DataGridViewCell c in r.Cells)
					{
						if (c.Value.ToString().ToUpper().IndexOf(txtBuscarNum.Text.ToUpper()) == 0)
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

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDate.Text = string.Format($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToString("h:mm:ss")}");
		}
	}
}
