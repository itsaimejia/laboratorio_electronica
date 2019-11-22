namespace ControlLaboratorioElectronica.Vistas
{
	partial class extConsultaClase
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
			this.label5 = new System.Windows.Forms.Label();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblGrupo = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.lblNombreDocente = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblMateria = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.dgvListaAlumnos = new System.Windows.Forms.DataGridView();
			this.NoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnPDF = new Bunifu.Framework.UI.BunifuImageButton();
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.btnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPDF)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.panel1.Controls.Add(this.btnMinimizar);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.bunifuImageButton1);
			this.panel1.Location = new System.Drawing.Point(-5, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(853, 40);
			this.panel1.TabIndex = 8;
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizar.Image = global::ControlLaboratorioElectronica.Properties.Resources.minimizar;
			this.btnMinimizar.ImageActive = null;
			this.btnMinimizar.Location = new System.Drawing.Point(794, 3);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(25, 23);
			this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimizar.TabIndex = 6;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Zoom = 10;
			this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(331, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 22);
			this.label5.TabIndex = 3;
			this.label5.Text = "Pases de lista";
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = global::ControlLaboratorioElectronica.Properties.Resources.exit;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(825, 3);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(25, 23);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 2;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblGrupo);
			this.groupBox2.Controls.Add(this.lblNombreDocente);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lblMateria);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(37, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(777, 82);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información clase";
			// 
			// lblGrupo
			// 
			this.lblGrupo.AutoSize = true;
			this.lblGrupo.Location = new System.Drawing.Point(704, 53);
			this.lblGrupo.Name = "lblGrupo";
			this.lblGrupo.Size = new System.Drawing.Size(36, 19);
			this.lblGrupo.TabIndex = 8;
			this.lblGrupo.Text = "4SA";
			// 
			// lblNombreDocente
			// 
			this.lblNombreDocente.AutoSize = true;
			this.lblNombreDocente.Location = new System.Drawing.Point(11, 53);
			this.lblNombreDocente.Name = "lblNombreDocente";
			this.lblNombreDocente.Size = new System.Drawing.Size(180, 19);
			this.lblNombreDocente.TabIndex = 6;
			this.lblNombreDocente.Text = "Pedrito Sola cortez";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(688, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Grupo:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(218, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Materia:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nombre docente:";
			// 
			// lblMateria
			// 
			this.lblMateria.AutoSize = true;
			this.lblMateria.Location = new System.Drawing.Point(218, 53);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(423, 19);
			this.lblMateria.TabIndex = 7;
			this.lblMateria.Text = "Principios electricos y aplicaciones digitales";
			// 
			// dgvListaAlumnos
			// 
			this.dgvListaAlumnos.AllowUserToAddRows = false;
			this.dgvListaAlumnos.AllowUserToDeleteRows = false;
			this.dgvListaAlumnos.BackgroundColor = System.Drawing.Color.White;
			this.dgvListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoControl,
            this.NombreAlumno});
			this.dgvListaAlumnos.GridColor = System.Drawing.Color.Black;
			this.dgvListaAlumnos.Location = new System.Drawing.Point(37, 162);
			this.dgvListaAlumnos.MultiSelect = false;
			this.dgvListaAlumnos.Name = "dgvListaAlumnos";
			this.dgvListaAlumnos.Size = new System.Drawing.Size(777, 272);
			this.dgvListaAlumnos.TabIndex = 15;
			this.toolTip2.SetToolTip(this.dgvListaAlumnos, "*NOTA: No olvides presionar TAB al realizar un cambio o cambia de fila");
			// 
			// NoControl
			// 
			this.NoControl.HeaderText = "Num. Control";
			this.NoControl.Name = "NoControl";
			this.NoControl.ReadOnly = true;
			this.NoControl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NoControl.Width = 140;
			// 
			// NombreAlumno
			// 
			this.NombreAlumno.HeaderText = "Nombre del alumno";
			this.NombreAlumno.Name = "NombreAlumno";
			this.NombreAlumno.ReadOnly = true;
			this.NombreAlumno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NombreAlumno.Width = 250;
			// 
			// btnPDF
			// 
			this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnPDF.Enabled = false;
			this.btnPDF.Image = global::ControlLaboratorioElectronica.Properties.Resources.pdf;
			this.btnPDF.ImageActive = null;
			this.btnPDF.Location = new System.Drawing.Point(603, 455);
			this.btnPDF.Name = "btnPDF";
			this.btnPDF.Size = new System.Drawing.Size(39, 33);
			this.btnPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnPDF.TabIndex = 17;
			this.btnPDF.TabStop = false;
			this.toolTip1.SetToolTip(this.btnPDF, "Exportar lista en PDF");
			this.btnPDF.Zoom = 10;
			// 
			// toolTip2
			// 
			this.toolTip2.AutoPopDelay = 3000;
			this.toolTip2.InitialDelay = 500;
			this.toolTip2.ReshowDelay = 100;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(35, 436);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(294, 12);
			this.label4.TabIndex = 18;
			this.label4.Text = "*NOTA: No olvides presionar TAB al realizar un cambio o cambia de fila";
			// 
			// btnActualizar
			// 
			this.btnActualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnActualizar.BorderRadius = 0;
			this.btnActualizar.ButtonText = "Actualizar";
			this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizar.DisabledColor = System.Drawing.Color.Gray;
			this.btnActualizar.Iconcolor = System.Drawing.Color.Transparent;
			this.btnActualizar.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.refresh;
			this.btnActualizar.Iconimage_right = null;
			this.btnActualizar.Iconimage_right_Selected = null;
			this.btnActualizar.Iconimage_Selected = null;
			this.btnActualizar.IconMarginLeft = 0;
			this.btnActualizar.IconMarginRight = 0;
			this.btnActualizar.IconRightVisible = true;
			this.btnActualizar.IconRightZoom = 0D;
			this.btnActualizar.IconVisible = true;
			this.btnActualizar.IconZoom = 90D;
			this.btnActualizar.IsTab = false;
			this.btnActualizar.Location = new System.Drawing.Point(667, 455);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(6);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnActualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnActualizar.OnHoverTextColor = System.Drawing.Color.White;
			this.btnActualizar.selected = false;
			this.btnActualizar.Size = new System.Drawing.Size(147, 33);
			this.btnActualizar.TabIndex = 19;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActualizar.Textcolor = System.Drawing.Color.White;
			this.btnActualizar.TextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			// 
			// extConsultaClase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(846, 503);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnPDF);
			this.Controls.Add(this.dgvListaAlumnos);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "extConsultaClase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta clase";
			this.Load += new System.EventHandler(this.extConsultaClase_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPDF)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuCustomLabel lblGrupo;
		private Bunifu.Framework.UI.BunifuCustomLabel lblNombreDocente;
		private Bunifu.Framework.UI.BunifuCustomLabel lblMateria;
		private System.Windows.Forms.DataGridView dgvListaAlumnos;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoControl;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
		private Bunifu.Framework.UI.BunifuImageButton btnPDF;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolTip toolTip2;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuFlatButton btnActualizar;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
	}
}