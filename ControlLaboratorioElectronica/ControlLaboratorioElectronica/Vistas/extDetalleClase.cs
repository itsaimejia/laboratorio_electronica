using ControlLaboratorioElectronica.CRUD;
using ControlLaboratorioElectronica.Modelos;
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

namespace ControlLaboratorioElectronica.Vistas
{
	public partial class extDetalleClase : Form
	{

		public string CodigoClase { get; set; }
		public extDetalleClase()
		{
			InitializeComponent();
			
		}

		public extDetalleClase(string codigoClase)
		{
			this.CodigoClase = codigoClase;
		}
		

		private void extDetalleClase_Load(object sender, EventArgs e)
		{
			updateInformacionClase();
			updateListaAlumnos();
		}
		public void updateInformacionClase()
		{
			Clase clase = crudClases.ObtenerClase(this.CodigoClase);
			lblNombreDocente.Text = clase.NombreDocente;
			lblGrupo.Text = clase.Grupo;
			lblMateria.Text = clase.Materia;
		}
		public void updateListaAlumnos()
		{
			ArrayList row;

			List<Alumno> alumnos = crudAlumnos.ObtenerAlumnosxClase(this.CodigoClase);
			foreach (var alumno in alumnos)
			{
				row = new ArrayList();
				row.Add(alumno.NoControl);
				row.Add(alumno.Nombre);
				dgvListaAlumnos.Rows.Add(row.ToArray());
			}
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
				dgvListaAlumnos.Rows.Clear();
				dgvListaAlumnos.Update();
				updateListaAlumnos();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDate.Text = string.Format($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToString("h:mm:ss")}");
		}
	}
}
