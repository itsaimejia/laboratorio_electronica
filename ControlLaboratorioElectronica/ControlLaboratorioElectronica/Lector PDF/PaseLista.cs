using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ControlLaboratorioElectronica.Modelos;

namespace ControlLaboratorioElectronica.Lector_PDF
{
	public class PaseLista
	{
		public static void crearDocumento(List<AlmAsistencia> asistencia, Clase clase)
		{
			Document doc = new Document();
			PdfWriter.GetInstance(doc, new FileStream(clase.CodigoClase+".pdf", FileMode.Create));
			doc.Open();

			Paragraph title = new Paragraph();
			title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLUE);
			title.Add("Reporte pase de lista clase: "+clase.CodigoClase);
			doc.Add(title);


			doc.Add(new Paragraph("Profesor: "+clase.NombreDocente));
			doc.Add(new Paragraph("Materia: "+clase.Materia));
			doc.Add(new Paragraph("Grupo: "+clase.Grupo));
			doc.Add(new Paragraph("\n"));
			doc.Add(new Paragraph("\n"));
			PdfPTable table = new PdfPTable(3);
			//titulos
			table.AddCell("Fecha");
			table.AddCell("Numero de control");
			table.AddCell("Asistencia");
			
			foreach (var alm in asistencia)
			{
				table.AddCell(alm.Fecha);
				table.AddCell(alm.NoControl);
				table.AddCell(alm.Asistio.ToString());
			}
			doc.Add(table);
			doc.Close();
		}
	}
}
