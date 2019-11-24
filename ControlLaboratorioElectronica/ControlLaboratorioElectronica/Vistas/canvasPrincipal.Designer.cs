namespace ControlLaboratorioElectronica
{
	partial class canvasPrincipal
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
			this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnApagar = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnEditar = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnNueva = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.lblDate = new System.Windows.Forms.Label();
			this.btnLimpiar = new Bunifu.Framework.UI.BunifuImageButton();
			this.dgvDocentes = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnApagar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNueva)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.White;
			this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.ForeColor = System.Drawing.Color.Transparent;
			this.txtBuscar.HintForeColor = System.Drawing.Color.Black;
			this.txtBuscar.HintText = "Buscar grupo";
			this.txtBuscar.isPassword = false;
			this.txtBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtBuscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtBuscar.LineThickness = 4;
			this.txtBuscar.Location = new System.Drawing.Point(7, 36);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(313, 35);
			this.txtBuscar.TabIndex = 0;
			this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtBuscar.OnValueChanged += new System.EventHandler(this.txtBuscar_OnValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.bunifuImageButton1);
			this.groupBox1.Controls.Add(this.lblDate);
			this.groupBox1.Controls.Add(this.btnLimpiar);
			this.groupBox1.Controls.Add(this.dgvDocentes);
			this.groupBox1.Controls.Add(this.txtBuscar);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 500);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Clases activas";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnApagar);
			this.groupBox2.Controls.Add(this.btnEliminar);
			this.groupBox2.Controls.Add(this.btnEditar);
			this.groupBox2.Controls.Add(this.btnNueva);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(568, 15);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(233, 68);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Administrar clases";
			// 
			// btnApagar
			// 
			this.btnApagar.BackColor = System.Drawing.Color.Red;
			this.btnApagar.Image = global::ControlLaboratorioElectronica.Properties.Resources.apagado;
			this.btnApagar.ImageActive = null;
			this.btnApagar.Location = new System.Drawing.Point(124, 21);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(43, 35);
			this.btnApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnApagar.TabIndex = 3;
			this.btnApagar.TabStop = false;
			this.toolTip3.SetToolTip(this.btnApagar, "Apagar clase");
			this.btnApagar.Zoom = 10;
			this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Red;
			this.btnEliminar.Image = global::ControlLaboratorioElectronica.Properties.Resources.eliminar;
			this.btnEliminar.ImageActive = null;
			this.btnEliminar.Location = new System.Drawing.Point(184, 21);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(43, 35);
			this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.TabStop = false;
			this.toolTip3.SetToolTip(this.btnEliminar, "Eliminar clase");
			this.btnEliminar.Zoom = 10;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnEditar.Image = global::ControlLaboratorioElectronica.Properties.Resources.editar;
			this.btnEditar.ImageActive = null;
			this.btnEditar.Location = new System.Drawing.Point(66, 21);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(43, 35);
			this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnEditar.TabIndex = 1;
			this.btnEditar.TabStop = false;
			this.toolTip2.SetToolTip(this.btnEditar, "Consultar/Editar pase de lista");
			this.btnEditar.Zoom = 10;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnNueva
			// 
			this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnNueva.Image = global::ControlLaboratorioElectronica.Properties.Resources.mas;
			this.btnNueva.ImageActive = null;
			this.btnNueva.Location = new System.Drawing.Point(6, 21);
			this.btnNueva.Name = "btnNueva";
			this.btnNueva.Size = new System.Drawing.Size(41, 35);
			this.btnNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnNueva.TabIndex = 0;
			this.btnNueva.TabStop = false;
			this.toolTip1.SetToolTip(this.btnNueva, "Añadir nueva clase");
			this.btnNueva.Zoom = 10;
			this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.bunifuImageButton1.ErrorImage = global::ControlLaboratorioElectronica.Properties.Resources.refresh;
			this.bunifuImageButton1.Image = global::ControlLaboratorioElectronica.Properties.Resources.refresh;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(7, 78);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 9;
			this.bunifuImageButton1.TabStop = false;
			this.toolTip4.SetToolTip(this.bunifuImageButton1, "Actualizar listado de clases");
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(615, -3);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(91, 15);
			this.lblDate.TabIndex = 8;
			this.lblDate.Text = "fecha y hora";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
			this.btnLimpiar.Image = global::ControlLaboratorioElectronica.Properties.Resources.limpiar;
			this.btnLimpiar.ImageActive = null;
			this.btnLimpiar.Location = new System.Drawing.Point(336, 37);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(30, 34);
			this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.TabStop = false;
			this.toolTip5.SetToolTip(this.btnLimpiar, "Limpiar busqueda");
			this.btnLimpiar.Zoom = 10;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// dgvDocentes
			// 
			this.dgvDocentes.AllowUserToAddRows = false;
			this.dgvDocentes.AllowUserToDeleteRows = false;
			this.dgvDocentes.AllowUserToResizeColumns = false;
			this.dgvDocentes.AllowUserToResizeRows = false;
			this.dgvDocentes.BackgroundColor = System.Drawing.Color.White;
			this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Grupo,
            this.NombreProfesor,
            this.Materia,
            this.Detalles});
			this.dgvDocentes.Location = new System.Drawing.Point(6, 109);
			this.dgvDocentes.MultiSelect = false;
			this.dgvDocentes.Name = "dgvDocentes";
			this.dgvDocentes.ReadOnly = true;
			this.dgvDocentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvDocentes.Size = new System.Drawing.Size(795, 385);
			this.dgvDocentes.TabIndex = 3;
			this.dgvDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellContentClick);
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Código clase";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			this.Codigo.Width = 160;
			// 
			// Grupo
			// 
			this.Grupo.HeaderText = "Grupo";
			this.Grupo.Name = "Grupo";
			this.Grupo.ReadOnly = true;
			this.Grupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Grupo.Width = 80;
			// 
			// NombreProfesor
			// 
			this.NombreProfesor.HeaderText = "Nombre profesor";
			this.NombreProfesor.Name = "NombreProfesor";
			this.NombreProfesor.ReadOnly = true;
			this.NombreProfesor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NombreProfesor.Width = 260;
			// 
			// Materia
			// 
			this.Materia.HeaderText = "Materia";
			this.Materia.Name = "Materia";
			this.Materia.ReadOnly = true;
			this.Materia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Materia.Width = 160;
			// 
			// Detalles
			// 
			this.Detalles.HeaderText = "Detalles";
			this.Detalles.Name = "Detalles";
			this.Detalles.ReadOnly = true;
			this.Detalles.Text = "Detalles";
			this.Detalles.UseColumnTextForButtonValue = true;
			this.Detalles.Width = 90;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 10;
			// 
			// canvasPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(831, 524);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "canvasPrincipal";
			this.Text = "canvasPrincipal";
			this.Load += new System.EventHandler(this.canvasPrincipal_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnApagar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNueva)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvDocentes;
		private Bunifu.Framework.UI.BunifuImageButton btnLimpiar;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Timer timer1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
		private Bunifu.Framework.UI.BunifuImageButton btnEditar;
		private Bunifu.Framework.UI.BunifuImageButton btnNueva;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
		private System.Windows.Forms.DataGridViewButtonColumn Detalles;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolTip toolTip2;
		private System.Windows.Forms.ToolTip toolTip3;
		private System.Windows.Forms.ToolTip toolTip4;
		private System.Windows.Forms.ToolTip toolTip5;
		private Bunifu.Framework.UI.BunifuImageButton btnApagar;
	}
}