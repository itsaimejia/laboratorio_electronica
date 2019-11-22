using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLaboratorioElectronica.Modelos
{
	public class Clase
	{
		public string CodigoClase { get; set; }
		public string Grupo { get; set; }
		public string NoEmpleado { get; set; }
		public string NombreDocente { get; set; }
		public string Materia { get; set; }
		public int Activa { get; set; }

		public string GenerarCodigoClase()
		{
			string[] palabras = Materia.Split(' ');
			string aux = (palabras.Length > 1) ? string.Format($"{palabras[0].Substring(0, 1)}{palabras[1].Substring(0, 1)}") :
				Materia.Substring(0, 2);
			return string.Format($"{Grupo}{aux}{DateTime.Now.Year}-{((DateTime.Now.Month <= 6) ? 1 : 2)}");
		}
	}
}
