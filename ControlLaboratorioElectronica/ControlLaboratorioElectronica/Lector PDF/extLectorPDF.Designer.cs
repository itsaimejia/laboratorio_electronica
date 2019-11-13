namespace ControlLaboratorioElectronica.Vistas
{
	partial class extLectorPDF
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(extLectorPDF));
			this.pdfReader = new AxAcroPDFLib.AxAcroPDF();
			((System.ComponentModel.ISupportInitialize)(this.pdfReader)).BeginInit();
			this.SuspendLayout();
			// 
			// pdfReader
			// 
			this.pdfReader.Enabled = true;
			this.pdfReader.Location = new System.Drawing.Point(2, 2);
			this.pdfReader.Name = "pdfReader";
			this.pdfReader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfReader.OcxState")));
			this.pdfReader.Size = new System.Drawing.Size(723, 506);
			this.pdfReader.TabIndex = 0;
			this.pdfReader.Enter += new System.EventHandler(this.pdfReader_Enter);
			// 
			// extLectorPDF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 504);
			this.Controls.Add(this.pdfReader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "extLectorPDF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lector pdf";
			this.Load += new System.EventHandler(this.extLectorPDF_Load);
			((System.ComponentModel.ISupportInitialize)(this.pdfReader)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private AxAcroPDFLib.AxAcroPDF pdfReader;
	}
}