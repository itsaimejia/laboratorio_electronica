using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLaboratorioElectronica.Modelos
{
	public class AlmAsistencia:Alumno
	{
		public string Fecha { get; set; }
		public int Asistio { get; set; }

		public override string ToString()
		{
			return $"{Fecha}-{NoControl}-{Asistio}";
		}
	}
}
