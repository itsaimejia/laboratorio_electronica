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
	public partial class extLectorPDF : Form
	{
		public string documento { get; set; }
		public extLectorPDF()
		{
			InitializeComponent();
		}

		private void extLectorPDF_Load(object sender, EventArgs e)
		{
			pdfReader.LoadFile(documento+".pdf");
		}

		private void pdfReader_Enter(object sender, EventArgs e)
		{

		}
	}
}
