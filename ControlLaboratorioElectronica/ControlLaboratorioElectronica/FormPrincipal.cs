using ControlLaboratorioElectronica.CRUD;
using ControlLaboratorioElectronica.Vistas;
using System;
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
	public partial class FormPrincipal : Form
	{
		public FormPrincipal()
		{
			InitializeComponent();
			var form = Application.OpenForms.OfType<canvasPrincipal>().FirstOrDefault();
			var reg = form ?? new canvasPrincipal();
			FillCanvas(reg);
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			despliegueMenu();
		}

		private void despliegueMenu()
		{
			if (panelMenu.Width == 49)
			{
				panelMenu.Visible = false;
				panelMenu.Width = 190;
				panelTransicion.ShowSync(panelMenu);
			}
			else
			{
				panelMenu.Visible = false;
				panelMenu.Width = 49;
				panelTransicion.ShowSync(panelMenu);

			}
		}

		private void canvas_MouseClick(object sender, MouseEventArgs e)
		{
			despliegueMenu();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		

		private void btnPrincipal_Click(object sender, EventArgs e)
		{
			Form frm = canvas.Controls.OfType<Form>().Where(o => o.Name.Contains("canvasPrincipal")).FirstOrDefault();
			if (frm == null)
			{
				canvas.Controls.Clear();
				var form = Application.OpenForms.OfType<canvasPrincipal>().FirstOrDefault();
				var reg = form ?? new canvasPrincipal();
				FillCanvas(reg);
			}
			if (panelMenu.Width > 49)
				despliegueMenu();
		}
		private void FillCanvas(Form fh)
		{
			if (canvas.Controls.Count > 0)
				canvas.Controls.RemoveAt(0);
			fh.TopLevel = false;
			fh.FormBorderStyle = FormBorderStyle.None;
			fh.Dock = DockStyle.Fill;
			canvas.Controls.Add(fh);
			canvas.Tag = fh;
			fh.Show();
		}

		private void btnPrestamosExt_Click(object sender, EventArgs e)
		{
			Form frm = canvas.Controls.OfType<Form>().Where(o => o.Name.Contains("canvasPrestamosExt")).FirstOrDefault();
			if (frm == null)
			{
				canvas.Controls.Clear();
				var form = Application.OpenForms.OfType<canvasPrestamosExt>().FirstOrDefault();
				var reg = form ?? new canvasPrestamosExt();
				FillCanvas(reg);
			}
			if (panelMenu.Width > 49)
				despliegueMenu();
		}

		private void btnEstadistico_Click(object sender, EventArgs e)
		{
			
			Form frm = canvas.Controls.OfType<Form>().Where(o => o.Name.Contains("canvasEstadistico")).FirstOrDefault();
			if (frm == null)
			{
				canvas.Controls.Clear();
				var form = Application.OpenForms.OfType<canvasEstadistico>().FirstOrDefault();
				var reg = form ?? new canvasEstadistico();
				FillCanvas(reg);
			}
			if (panelMenu.Width > 49)
				despliegueMenu();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

	}
}
