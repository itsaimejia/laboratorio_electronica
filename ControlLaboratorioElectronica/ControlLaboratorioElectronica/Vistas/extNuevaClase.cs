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
	public partial class extNuevaClase : Form
	{
		
		public extNuevaClase()
		{
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			this.Close();
			foreach (Form frm in Application.OpenForms)
			{
				if (frm.GetType() == typeof(FormPrincipal))
				{
					frm.WindowState = FormWindowState.Normal;
					break;
				}
			}
		}

		private void btnCargarPractica_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\");
		}

		public void limpiar()
		{
			txtNoEmpleado.Text = string.Empty;
			txtGrupo.Text = string.Empty;
			txtMateria.Text = string.Empty;
			txtNombre.Text = string.Empty;
			dgvAlumnos.Rows.Clear();
			dgvAlumnos.Refresh();
			txtNoEmpleado.Focus();

		}


		private void btnGuardar_Click(object sender, EventArgs e)
		{
			crudAlumnos crudAlumnos = new crudAlumnos();
			crudClases crudClases = new crudClases();
			if (txtNoEmpleado.Text == string.Empty)
				txtNoEmpleado.Focus();
			else if (txtNombre.Text == string.Empty)
				txtNombre.Focus();
			else if (txtGrupo.Text == string.Empty)
				txtGrupo.Focus();
			else if (txtMateria.Text == string.Empty)
				txtMateria.Focus();
			else if (dgvAlumnos.Rows.Count < 2)
			{
				MessageBox.Show("La lista de alumnos se encuentra vacia");
				dgvAlumnos.Focus();
			}
			else
			{
				Clase clase = new Clase()
				{
					NoEmpleado = txtNoEmpleado.Text.ToUpper(),
					Grupo = txtGrupo.Text.ToUpper(),
					Materia = txtMateria.Text.ToUpper(),
					NombreDocente = txtNombre.Text.ToUpper()
				};
				clase.CodigoClase = clase.GenerarCodigoClase();
				Alumno alumno;

				bool correcto = crudClases.Alta(clase);
				if (correcto)
				{
					foreach (DataGridViewRow row in dgvAlumnos.Rows)
					{
						if (Convert.ToString(row.Cells["NoControl"].Value) != "" && Convert.ToString(row.Cells["NombreAlumno"].Value) != "")
						{
							alumno = new Alumno();

							alumno.NoControl = Convert.ToString(row.Cells["NoControl"].Value).ToUpper();
							alumno.Nombre = Convert.ToString(row.Cells["NombreAlumno"].Value).ToUpper();
							alumno.CodigoClase = clase.CodigoClase.ToUpper();
							crudAlumnos.Alta(alumno);

						}
					}
					MessageBox.Show("Se agregó la clase");
					limpiar();
				}
				else
				{
					MessageBox.Show("No se agregó la clase, revisar");
				}
			}
			

		}
	}
}
