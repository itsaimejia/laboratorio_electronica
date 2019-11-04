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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
			this.label5 = new System.Windows.Forms.Label();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.dgvListaAlumnos = new System.Windows.Forms.DataGridView();
			this.NumeroControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Asistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Prestamo = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblNombreDocente = new System.Windows.Forms.Label();
			this.lblMateria = new System.Windows.Forms.Label();
			this.lblGrupo = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtNombrePractica = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtNumPractica = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtAula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtBuscarNum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnFinClase = new Bunifu.Framework.UI.BunifuFlatButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.panel1.Location = new System.Drawing.Point(-4, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(739, 40);
			this.panel1.TabIndex = 2;
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizar.Image = global::ControlLaboratorioElectronica.Properties.Resources.minimizar;
			this.btnMinimizar.ImageActive = null;
			this.btnMinimizar.Location = new System.Drawing.Point(680, 8);
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
			this.label5.Location = new System.Drawing.Point(257, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(210, 22);
			this.label5.TabIndex = 3;
			this.label5.Text = "Detalles de la clase";
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = global::ControlLaboratorioElectronica.Properties.Resources.exit;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(711, 8);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Grupo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Materia";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Docente";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(593, 55);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(66, 13);
			this.lblDate.TabIndex = 7;
			this.lblDate.Text = "fecha y hora";
			// 
			// dgvListaAlumnos
			// 
			this.dgvListaAlumnos.AllowUserToAddRows = false;
			this.dgvListaAlumnos.AllowUserToDeleteRows = false;
			this.dgvListaAlumnos.BackgroundColor = System.Drawing.Color.White;
			this.dgvListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroControl,
            this.NombreAlumno,
            this.Asistencia,
            this.Prestamo});
			this.dgvListaAlumnos.GridColor = System.Drawing.Color.White;
			this.dgvListaAlumnos.Location = new System.Drawing.Point(16, 63);
			this.dgvListaAlumnos.Name = "dgvListaAlumnos";
			this.dgvListaAlumnos.Size = new System.Drawing.Size(684, 150);
			this.dgvListaAlumnos.TabIndex = 11;
			// 
			// NumeroControl
			// 
			this.NumeroControl.HeaderText = "Num. Control";
			this.NumeroControl.Name = "NumeroControl";
			this.NumeroControl.Width = 140;
			// 
			// NombreAlumno
			// 
			this.NombreAlumno.HeaderText = "Nombre del alumno";
			this.NombreAlumno.Name = "NombreAlumno";
			this.NombreAlumno.Width = 300;
			// 
			// Asistencia
			// 
			this.Asistencia.HeaderText = "Asistencia";
			this.Asistencia.Name = "Asistencia";
			// 
			// Prestamo
			// 
			this.Prestamo.HeaderText = "Prestamo";
			this.Prestamo.Name = "Prestamo";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(439, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(220, 276);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Archivos";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 19;
			this.listBox1.Location = new System.Drawing.Point(6, 25);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(208, 232);
			this.listBox1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblNombreDocente);
			this.groupBox2.Controls.Add(this.lblMateria);
			this.groupBox2.Controls.Add(this.lblGrupo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(75, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(357, 125);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información clase";
			// 
			// lblNombreDocente
			// 
			this.lblNombreDocente.AutoSize = true;
			this.lblNombreDocente.Location = new System.Drawing.Point(119, 96);
			this.lblNombreDocente.Name = "lblNombreDocente";
			this.lblNombreDocente.Size = new System.Drawing.Size(117, 19);
			this.lblNombreDocente.TabIndex = 8;
			this.lblNombreDocente.Text = "Predito Sola";
			// 
			// lblMateria
			// 
			this.lblMateria.AutoSize = true;
			this.lblMateria.Location = new System.Drawing.Point(119, 63);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(108, 19);
			this.lblMateria.TabIndex = 7;
			this.lblMateria.Text = "Electronica";
			// 
			// lblGrupo
			// 
			this.lblGrupo.AutoSize = true;
			this.lblGrupo.Location = new System.Drawing.Point(119, 34);
			this.lblGrupo.Name = "lblGrupo";
			this.lblGrupo.Size = new System.Drawing.Size(36, 19);
			this.lblGrupo.TabIndex = 6;
			this.lblGrupo.Text = "4SA";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtNombrePractica);
			this.groupBox3.Controls.Add(this.txtNumPractica);
			this.groupBox3.Controls.Add(this.txtAula);
			this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(75, 222);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(357, 134);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Registro de uso de laboratorio";
			// 
			// txtNombrePractica
			// 
			this.txtNombrePractica.BackColor = System.Drawing.Color.White;
			this.txtNombrePractica.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombrePractica.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombrePractica.ForeColor = System.Drawing.Color.Black;
			this.txtNombrePractica.HintForeColor = System.Drawing.Color.Black;
			this.txtNombrePractica.HintText = "Nombre de la practica";
			this.txtNombrePractica.isPassword = false;
			this.txtNombrePractica.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtNombrePractica.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtNombrePractica.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtNombrePractica.LineThickness = 4;
			this.txtNombrePractica.Location = new System.Drawing.Point(20, 80);
			this.txtNombrePractica.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombrePractica.Name = "txtNombrePractica";
			this.txtNombrePractica.Size = new System.Drawing.Size(313, 35);
			this.txtNombrePractica.TabIndex = 13;
			this.txtNombrePractica.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txtNumPractica
			// 
			this.txtNumPractica.BackColor = System.Drawing.Color.White;
			this.txtNumPractica.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNumPractica.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumPractica.ForeColor = System.Drawing.Color.Black;
			this.txtNumPractica.HintForeColor = System.Drawing.Color.Black;
			this.txtNumPractica.HintText = "Núm de practica";
			this.txtNumPractica.isPassword = false;
			this.txtNumPractica.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtNumPractica.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtNumPractica.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtNumPractica.LineThickness = 4;
			this.txtNumPractica.Location = new System.Drawing.Point(163, 27);
			this.txtNumPractica.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumPractica.Name = "txtNumPractica";
			this.txtNumPractica.Size = new System.Drawing.Size(153, 35);
			this.txtNumPractica.TabIndex = 12;
			this.txtNumPractica.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txtAula
			// 
			this.txtAula.BackColor = System.Drawing.Color.White;
			this.txtAula.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAula.ForeColor = System.Drawing.Color.Black;
			this.txtAula.HintForeColor = System.Drawing.Color.Black;
			this.txtAula.HintText = "Aula";
			this.txtAula.isPassword = false;
			this.txtAula.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtAula.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtAula.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtAula.LineThickness = 4;
			this.txtAula.Location = new System.Drawing.Point(20, 26);
			this.txtAula.Margin = new System.Windows.Forms.Padding(4);
			this.txtAula.Name = "txtAula";
			this.txtAula.Size = new System.Drawing.Size(135, 36);
			this.txtAula.TabIndex = 11;
			this.txtAula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtBuscarNum);
			this.groupBox4.Controls.Add(this.dgvListaAlumnos);
			this.groupBox4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(15, 362);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(706, 224);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Lista Alumnos";
			// 
			// txtBuscarNum
			// 
			this.txtBuscarNum.BackColor = System.Drawing.Color.White;
			this.txtBuscarNum.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBuscarNum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscarNum.ForeColor = System.Drawing.Color.Black;
			this.txtBuscarNum.HintForeColor = System.Drawing.Color.Black;
			this.txtBuscarNum.HintText = "No Control";
			this.txtBuscarNum.isPassword = false;
			this.txtBuscarNum.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtBuscarNum.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtBuscarNum.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtBuscarNum.LineThickness = 4;
			this.txtBuscarNum.Location = new System.Drawing.Point(16, 20);
			this.txtBuscarNum.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscarNum.Name = "txtBuscarNum";
			this.txtBuscarNum.Size = new System.Drawing.Size(144, 36);
			this.txtBuscarNum.TabIndex = 14;
			this.txtBuscarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtBuscarNum.OnValueChanged += new System.EventHandler(this.txtBuscarNum_OnValueChanged);
			// 
			// btnFinClase
			// 
			this.btnFinClase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnFinClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnFinClase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFinClase.BorderRadius = 0;
			this.btnFinClase.ButtonText = "Finalizar clase";
			this.btnFinClase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFinClase.DisabledColor = System.Drawing.Color.Gray;
			this.btnFinClase.Iconcolor = System.Drawing.Color.Transparent;
			this.btnFinClase.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.finalizar;
			this.btnFinClase.Iconimage_right = null;
			this.btnFinClase.Iconimage_right_Selected = null;
			this.btnFinClase.Iconimage_Selected = null;
			this.btnFinClase.IconMarginLeft = 0;
			this.btnFinClase.IconMarginRight = 0;
			this.btnFinClase.IconRightVisible = true;
			this.btnFinClase.IconRightZoom = 0D;
			this.btnFinClase.IconVisible = true;
			this.btnFinClase.IconZoom = 90D;
			this.btnFinClase.IsTab = false;
			this.btnFinClase.Location = new System.Drawing.Point(275, 608);
			this.btnFinClase.Margin = new System.Windows.Forms.Padding(6);
			this.btnFinClase.Name = "btnFinClase";
			this.btnFinClase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnFinClase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnFinClase.OnHoverTextColor = System.Drawing.Color.White;
			this.btnFinClase.selected = false;
			this.btnFinClase.Size = new System.Drawing.Size(188, 33);
			this.btnFinClase.TabIndex = 17;
			this.btnFinClase.Text = "Finalizar clase";
			this.btnFinClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinClase.Textcolor = System.Drawing.Color.White;
			this.btnFinClase.TextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// extDetalleClase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(733, 656);
			this.Controls.Add(this.btnFinClase);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "extDetalleClase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "extDetalleClase";
			this.Load += new System.EventHandler(this.extDetalleClase_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumnos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView dgvListaAlumnos;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblNombreDocente;
		private System.Windows.Forms.Label lblMateria;
		private System.Windows.Forms.Label lblGrupo;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombrePractica;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumPractica;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtAula;
		private System.Windows.Forms.GroupBox groupBox4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscarNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumeroControl;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Asistencia;
		private System.Windows.Forms.DataGridViewButtonColumn Prestamo;
		private Bunifu.Framework.UI.BunifuFlatButton btnFinClase;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
		private System.Windows.Forms.Timer timer1;
	}
}