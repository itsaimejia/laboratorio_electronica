namespace ControlLaboratorioElectronica.Vistas
{
	partial class extNuevaClase
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
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtGrupo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtMateria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.dgvAlumnos = new System.Windows.Forms.DataGridView();
			this.NoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNoEmpleado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnCargarPractica = new Bunifu.Framework.UI.BunifuFlatButton();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.panel1.Controls.Add(this.bunifuImageButton1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-1, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(827, 40);
			this.panel1.TabIndex = 0;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = global::ControlLaboratorioElectronica.Properties.Resources.exit;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(799, 3);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(25, 23);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 1;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(272, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Formulario nueva clase";
			// 
			// txtNombre
			// 
			this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.Black;
			this.txtNombre.HintForeColor = System.Drawing.Color.Black;
			this.txtNombre.HintText = "Nombre docente (apellidos->nombres)";
			this.txtNombre.isPassword = false;
			this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtNombre.LineThickness = 4;
			this.txtNombre.Location = new System.Drawing.Point(55, 82);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(379, 33);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtGrupo
			// 
			this.txtGrupo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGrupo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGrupo.ForeColor = System.Drawing.Color.Black;
			this.txtGrupo.HintForeColor = System.Drawing.Color.Black;
			this.txtGrupo.HintText = "Grupo";
			this.txtGrupo.isPassword = false;
			this.txtGrupo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtGrupo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtGrupo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtGrupo.LineThickness = 4;
			this.txtGrupo.Location = new System.Drawing.Point(64, 135);
			this.txtGrupo.Margin = new System.Windows.Forms.Padding(4);
			this.txtGrupo.Name = "txtGrupo";
			this.txtGrupo.Size = new System.Drawing.Size(119, 33);
			this.txtGrupo.TabIndex = 2;
			this.txtGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtMateria
			// 
			this.txtMateria.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMateria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMateria.ForeColor = System.Drawing.Color.Black;
			this.txtMateria.HintForeColor = System.Drawing.Color.Black;
			this.txtMateria.HintText = "Materia";
			this.txtMateria.isPassword = false;
			this.txtMateria.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtMateria.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtMateria.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtMateria.LineThickness = 4;
			this.txtMateria.Location = new System.Drawing.Point(211, 135);
			this.txtMateria.Margin = new System.Windows.Forms.Padding(4);
			this.txtMateria.Name = "txtMateria";
			this.txtMateria.Size = new System.Drawing.Size(223, 33);
			this.txtMateria.TabIndex = 3;
			this.txtMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dgvAlumnos
			// 
			this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoControl,
            this.NombreAlumno});
			this.dgvAlumnos.Location = new System.Drawing.Point(6, 23);
			this.dgvAlumnos.Name = "dgvAlumnos";
			this.dgvAlumnos.Size = new System.Drawing.Size(464, 187);
			this.dgvAlumnos.TabIndex = 4;
			// 
			// NoControl
			// 
			this.NoControl.HeaderText = "No. Control";
			this.NoControl.Name = "NoControl";
			this.NoControl.Width = 120;
			// 
			// NombreAlumno
			// 
			this.NombreAlumno.HeaderText = "Nombre alumno";
			this.NombreAlumno.Name = "NombreAlumno";
			this.NombreAlumno.Width = 300;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dgvAlumnos);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(28, 250);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(482, 235);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lista de alumnos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 213);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "*Nota: Presione TAB después de ingresar el ultimo nombre";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtNoEmpleado);
			this.groupBox2.Controls.Add(this.txtNombre);
			this.groupBox2.Controls.Add(this.txtMateria);
			this.groupBox2.Controls.Add(this.txtGrupo);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(28, 62);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(482, 182);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información docente";
			// 
			// txtNoEmpleado
			// 
			this.txtNoEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNoEmpleado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoEmpleado.ForeColor = System.Drawing.Color.Black;
			this.txtNoEmpleado.HintForeColor = System.Drawing.Color.Black;
			this.txtNoEmpleado.HintText = "No. Empleado";
			this.txtNoEmpleado.isPassword = false;
			this.txtNoEmpleado.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtNoEmpleado.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtNoEmpleado.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtNoEmpleado.LineThickness = 4;
			this.txtNoEmpleado.Location = new System.Drawing.Point(139, 41);
			this.txtNoEmpleado.Margin = new System.Windows.Forms.Padding(4);
			this.txtNoEmpleado.Name = "txtNoEmpleado";
			this.txtNoEmpleado.Size = new System.Drawing.Size(217, 33);
			this.txtNoEmpleado.TabIndex = 1;
			this.txtNoEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnCargarPractica);
			this.groupBox3.Controls.Add(this.listBox1);
			this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(536, 62);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(250, 404);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Practicas";
			// 
			// btnCargarPractica
			// 
			this.btnCargarPractica.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnCargarPractica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnCargarPractica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCargarPractica.BorderRadius = 0;
			this.btnCargarPractica.ButtonText = "Cargar practica";
			this.btnCargarPractica.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCargarPractica.DisabledColor = System.Drawing.Color.Gray;
			this.btnCargarPractica.Enabled = false;
			this.btnCargarPractica.Iconcolor = System.Drawing.Color.Transparent;
			this.btnCargarPractica.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.agregar_carpeta;
			this.btnCargarPractica.Iconimage_right = null;
			this.btnCargarPractica.Iconimage_right_Selected = null;
			this.btnCargarPractica.Iconimage_Selected = null;
			this.btnCargarPractica.IconMarginLeft = 0;
			this.btnCargarPractica.IconMarginRight = 0;
			this.btnCargarPractica.IconRightVisible = true;
			this.btnCargarPractica.IconRightZoom = 0D;
			this.btnCargarPractica.IconVisible = true;
			this.btnCargarPractica.IconZoom = 90D;
			this.btnCargarPractica.IsTab = false;
			this.btnCargarPractica.Location = new System.Drawing.Point(16, 356);
			this.btnCargarPractica.Margin = new System.Windows.Forms.Padding(9);
			this.btnCargarPractica.Name = "btnCargarPractica";
			this.btnCargarPractica.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnCargarPractica.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnCargarPractica.OnHoverTextColor = System.Drawing.Color.White;
			this.btnCargarPractica.selected = false;
			this.btnCargarPractica.Size = new System.Drawing.Size(214, 36);
			this.btnCargarPractica.TabIndex = 16;
			this.btnCargarPractica.Text = "Cargar practica";
			this.btnCargarPractica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCargarPractica.Textcolor = System.Drawing.Color.White;
			this.btnCargarPractica.TextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCargarPractica.Click += new System.EventHandler(this.btnCargarPractica_Click);
			// 
			// listBox1
			// 
			this.listBox1.Enabled = false;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 19;
			this.listBox1.Location = new System.Drawing.Point(16, 36);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(214, 289);
			this.listBox1.TabIndex = 0;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar.BorderRadius = 0;
			this.btnGuardar.ButtonText = "Guardar";
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
			this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
			this.btnGuardar.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.guardar;
			this.btnGuardar.Iconimage_right = null;
			this.btnGuardar.Iconimage_right_Selected = null;
			this.btnGuardar.Iconimage_Selected = null;
			this.btnGuardar.IconMarginLeft = 0;
			this.btnGuardar.IconMarginRight = 0;
			this.btnGuardar.IconRightVisible = true;
			this.btnGuardar.IconRightZoom = 0D;
			this.btnGuardar.IconVisible = true;
			this.btnGuardar.IconZoom = 90D;
			this.btnGuardar.IsTab = false;
			this.btnGuardar.Location = new System.Drawing.Point(349, 494);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(6);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
			this.btnGuardar.selected = false;
			this.btnGuardar.Size = new System.Drawing.Size(137, 33);
			this.btnGuardar.TabIndex = 16;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Textcolor = System.Drawing.Color.White;
			this.btnGuardar.TextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			// 
			// ttMensaje
			// 
			this.ttMensaje.IsBalloon = true;
			// 
			// extNuevaClase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(823, 532);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "extNuevaClase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nueva clase";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtGrupo;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtMateria;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvAlumnos;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoControl;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBox1;
		private Bunifu.Framework.UI.BunifuFlatButton btnCargarPractica;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtNoEmpleado;
		private System.Windows.Forms.ToolTip ttMensaje;
		private System.Windows.Forms.Label label2;
	}
}