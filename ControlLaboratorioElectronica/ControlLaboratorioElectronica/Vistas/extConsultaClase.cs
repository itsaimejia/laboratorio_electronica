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
	public partial class extConsultaClase : Form
	{
		public string CodigoClase { get; set; }
		Clase clase;
		List<AlmAsistencia> listaConsulta;
		List<AlmAsistencia> listaActualizada;
		public extConsultaClase()
		{
			InitializeComponent();
			listaActualizada = new List<AlmAsistencia>();
		}

		public void updateInformacionClase()
		{
			clase = crudClases.ObtenerClase(this.CodigoClase);
			lblNombreDocente.Text = clase.NombreDocente;
			lblGrupo.Text = clase.Grupo;
			lblMateria.Text = clase.Materia;
		}
		public void updateListaAlumnos()
		{
			ArrayList row;
			//Carga de la lista de alumnos en el dgv
			List<Alumno> alumnos = crudAlumnos.ObtenerAlumnosxClase(this.CodigoClase);
			foreach (var alumno in alumnos)
			{
				row = new ArrayList();
				row.Add(alumno.NoControl);
				row.Add(alumno.Nombre);
				dgvListaAlumnos.Rows.Add(row.ToArray());
			}

			//Consulta de las asistencias de la clase
			listaConsulta = crudAsistencias.ObtenerAsistencias(CodigoClase);


			if (listaConsulta.Count > 0)
			{
				//creacion y adicion de las columnas por fecha 
				DataGridViewCheckBoxColumn dgvcheck;
				string fechaCurrent = listaConsulta[0].Fecha;
				int i = 0;
				dgvcheck = new DataGridViewCheckBoxColumn();
				dgvcheck.Name = "fecha" + i;
				dgvcheck.HeaderText = fechaCurrent;
				dgvListaAlumnos.Columns.Add(dgvcheck);

				foreach (var f in listaConsulta)
				{
					if (fechaCurrent != f.Fecha)
					{
						i++;
						dgvcheck = new DataGridViewCheckBoxColumn();
						dgvcheck.Name = "fecha" + i;
						dgvcheck.HeaderText = f.Fecha;
						fechaCurrent = f.Fecha;
						dgvListaAlumnos.Columns.Add(dgvcheck);
					}
				}

				//relleno de la lista segun las asistencias
				foreach (DataGridViewRow r in dgvListaAlumnos.Rows)
				{
					var asistenciasAlumno = listaConsulta.Where(x => x.NoControl == Convert.ToString(r.Cells["NoControl"].Value)).ToList();
					int p = 0;
					foreach (var c in asistenciasAlumno)
					{
						r.Cells["fecha" + p].Value = (c.Asistio == 1) ? true : false;
						p++;
					}
				}
			}

		}

		private void extConsultaClase_Load(object sender, EventArgs e)
		{
			updateInformacionClase();
			updateListaAlumnos();
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

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}


		private void btnActualizar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				foreach (DataGridViewRow row in dgvListaAlumnos.Rows)
				{
					string auxNoControl = Convert.ToString(row.Cells["NoControl"].Value);
					int p = 2;
					for (int i = 0; i < dgvListaAlumnos.ColumnCount-2; i++)
					{
						var asistencia = new AlmAsistencia();
						asistencia.Fecha = dgvListaAlumnos.Columns[p].HeaderText;
						asistencia.NoControl = auxNoControl;
						asistencia.Asistio = Convert.ToBoolean(row.Cells["fecha" + i].Value) == true ? 1 : 0;
						asistencia.CodigoClase = this.CodigoClase;
						listaActualizada.Add(asistencia);
						p++;
					}
				}
			}

			List<AlmAsistencia> enviarActualizados = new List<AlmAsistencia>();
			foreach (var la in listaActualizada)
			{
				int coincidencia = 0;
				foreach (var lc in listaConsulta)
				{
					if (la.ToString().Equals(lc.ToString()))
						coincidencia++;
				}
				if (coincidencia == 0)
					enviarActualizados.Add(la);
			}

			int exito = 0;
			foreach (var actual in enviarActualizados)
			{
				exito+=crudAsistencias.Actualizar(actual);
			}

			if (exito > 0)
				MessageBox.Show("Cambios guardados", "Cambios",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

	}
}
