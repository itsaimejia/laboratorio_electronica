using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLaboratorioElectronica.Modelos
{
	public class Prestamo
	{
		
		public string IdPrestamo { get; set; }
		public string IdArticulo { get; set; }
		public string NombreArticulo { get; set; }
		public int Cantidad { get; set; }
		public string NoControl { get; set; }
		public string TipoPrestamo { get; set; }


	}
}
