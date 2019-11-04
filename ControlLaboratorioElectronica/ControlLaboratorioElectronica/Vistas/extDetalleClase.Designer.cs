namespace ControlLaboratorioElectronica.Vistas
{
	partial class extDetalleClase
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
			this.components = new System.ComponentModel.Container();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblGrupo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(313, 59);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(0, 13);
			this.lblNombre.TabIndex = 0;
			// 
			// lblGrupo
			// 
			this.lblGrupo.AutoSize = true;
			this.lblGrupo.Location = new System.Drawing.Point(278, 120);
			this.lblGrupo.Name = "lblGrupo";
			this.lblGrupo.Size = new System.Drawing.Size(0, 13);
			this.lblGrupo.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.panel1.Controls.Add(this.bunifuImageButton1);
			this.panel1.Location = new System.Drawing.Point(-4, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(908, 40);
			this.panel1.TabIndex = 2;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = global::ControlLaboratorioElectronica.Properties.Resources.exit;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(880, 3);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(25, 23);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 2;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			// 
			// extDetalleClase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(902, 492);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblGrupo);
			this.Controls.Add(this.lblNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "extDetalleClase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "extDetalleClase";
			this.Load += new System.EventHandler(this.extDetalleClase_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Label lblGrupo;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
	}
}