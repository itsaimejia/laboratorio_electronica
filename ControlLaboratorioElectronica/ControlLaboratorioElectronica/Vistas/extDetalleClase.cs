using ControlLaboratorioElectronica.CRUD;
using ControlLaboratorioElectronica.Lector_PDF;
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
		public string HoraEntrada { get; set; }
		static Clase clase;
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
			clase = crudClases.ObtenerClase(this.CodigoClase);
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
			foreach (Form frm in Application.OpenForms)
			{
				if (frm.GetType() == typeof(Form1))
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

		

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDate.Text = string.Format($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToString("h:mm:ss")}");
		}

		private void btnFinClase_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtAula.Text == string.Empty)
					txtAula.Focus();
				else if (txtNumPractica.Text == string.Empty)
					txtNumPractica.Focus();
				else if (txtNombrePractica.Text == string.Empty)
					txtNombrePractica.Focus();
				else if (dgvListaAlumnos.Enabled == true)
				{
					MessageBox.Show("Aun no has guardado el pase de lista");
					dgvListaAlumnos.Focus();
				}
				else
				{
					DialogResult result = MessageBox.Show("Continuar con el fin de la clase", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.Yes)
					{
						bool correcto = crudClases.GuardarClaseConcluida(new ClaseConcluida
						{
							Fecha = DateTime.Now.ToShortDateString(),
							HoraEntrada = this.HoraEntrada,
							HoraSalida = DateTime.Now.ToString("h:mm:ss"),
							CodigoClase = this.CodigoClase,
							Aula = txtAula.Text,
							NoPractica = txtNumPractica.Text,
							NombrePractica = txtNombrePractica.Text
						});

						if (correcto)
						{
							MessageBox.Show("Clase guardada\nYa puedes cerrar el formulario","Clase finalizada",MessageBoxButtons.OK,MessageBoxIcon.Information);
							txtAula.Enabled = false;
							txtNombrePractica.Enabled = false;
							txtNumPractica.Enabled = false;
							btnFinClase.Enabled = false;
						}
					}
					
				}
			}catch(Exception ex)
			{

			}
		}

		private void btnPaseLista_Click(object sender, EventArgs e)
		{
			
			DialogResult result = MessageBox.Show("¿El pase de lista es correcto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				foreach (DataGridViewRow row in dgvListaAlumnos.Rows)
				{
					var asistencia = new AlmAsistencia
					{
						CodigoClase=clase.CodigoClase,
						Fecha = DateTime.Now.ToShortDateString(),
						NoControl = Convert.ToString(row.Cells["NoControl"].Value).ToUpper(),
						Asistio = (Convert.ToBoolean(row.Cells["Asistencia"].Value) == true) ? 1 : 0
					};
					crudAlumnos.Asistencia(asistencia);
				}
				dgvListaAlumnos.Rows.Clear();
				dgvListaAlumnos.Refresh();
				dgvListaAlumnos.Enabled = false;
				btnPaseLista.Enabled = false;
			}
		}

		private void btnListaAsistencias_Click(object sender, EventArgs e)
		{

			PaseLista.crearDocumento(crudAlumnos.ObtenerAsistencias(clase.CodigoClase), clase);
			extLectorPDF pdf = new extLectorPDF();
			pdf.documento = CodigoClase;
			pdf.Show();

		}
	}
}
