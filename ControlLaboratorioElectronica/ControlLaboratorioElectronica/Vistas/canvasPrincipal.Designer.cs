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
			this.btnNuevaClase = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnLimpiar = new Bunifu.Framework.UI.BunifuImageButton();
			this.dgvDocentes = new System.Windows.Forms.DataGridView();
			this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
			this.lblDate = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.lblDate);
			this.groupBox1.Controls.Add(this.btnNuevaClase);
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
			// btnNuevaClase
			// 
			this.btnNuevaClase.Activecolor = System.Drawing.Color.Transparent;
			this.btnNuevaClase.BackColor = System.Drawing.Color.Transparent;
			this.btnNuevaClase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNuevaClase.BorderRadius = 0;
			this.btnNuevaClase.ButtonText = "Nueva clase";
			this.btnNuevaClase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevaClase.DisabledColor = System.Drawing.Color.Gray;
			this.btnNuevaClase.Iconcolor = System.Drawing.Color.Transparent;
			this.btnNuevaClase.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.clase;
			this.btnNuevaClase.Iconimage_right = null;
			this.btnNuevaClase.Iconimage_right_Selected = null;
			this.btnNuevaClase.Iconimage_Selected = null;
			this.btnNuevaClase.IconMarginLeft = 0;
			this.btnNuevaClase.IconMarginRight = 0;
			this.btnNuevaClase.IconRightVisible = true;
			this.btnNuevaClase.IconRightZoom = 0D;
			this.btnNuevaClase.IconVisible = true;
			this.btnNuevaClase.IconZoom = 90D;
			this.btnNuevaClase.IsTab = false;
			this.btnNuevaClase.Location = new System.Drawing.Point(577, 24);
			this.btnNuevaClase.Margin = new System.Windows.Forms.Padding(5);
			this.btnNuevaClase.Name = "btnNuevaClase";
			this.btnNuevaClase.Normalcolor = System.Drawing.Color.Transparent;
			this.btnNuevaClase.OnHovercolor = System.Drawing.Color.White;
			this.btnNuevaClase.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnNuevaClase.selected = false;
			this.btnNuevaClase.Size = new System.Drawing.Size(222, 77);
			this.btnNuevaClase.TabIndex = 5;
			this.btnNuevaClase.Text = "Nueva clase";
			this.btnNuevaClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevaClase.Textcolor = System.Drawing.Color.Black;
			this.btnNuevaClase.TextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevaClase.Click += new System.EventHandler(this.btnNuevaClase_Click);
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
			this.btnLimpiar.Zoom = 10;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// dgvDocentes
			// 
			this.dgvDocentes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.dgvDocentes.AllowUserToAddRows = false;
			this.dgvDocentes.AllowUserToDeleteRows = false;
			this.dgvDocentes.AllowUserToResizeColumns = false;
			this.dgvDocentes.AllowUserToResizeRows = false;
			this.dgvDocentes.BackgroundColor = System.Drawing.Color.White;
			this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupo,
            this.NombreProfesor,
            this.Materia,
            this.Detalles});
			this.dgvDocentes.Location = new System.Drawing.Point(6, 109);
			this.dgvDocentes.Name = "dgvDocentes";
			this.dgvDocentes.ReadOnly = true;
			this.dgvDocentes.Size = new System.Drawing.Size(795, 385);
			this.dgvDocentes.TabIndex = 3;
			this.dgvDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellContentClick);
			// 
			// Grupo
			// 
			this.Grupo.HeaderText = "Grupo";
			this.Grupo.Name = "Grupo";
			this.Grupo.ReadOnly = true;
			this.Grupo.Width = 150;
			// 
			// NombreProfesor
			// 
			this.NombreProfesor.HeaderText = "Nombre profesor";
			this.NombreProfesor.Name = "NombreProfesor";
			this.NombreProfesor.ReadOnly = true;
			this.NombreProfesor.Width = 300;
			// 
			// Materia
			// 
			this.Materia.HeaderText = "Materia";
			this.Materia.Name = "Materia";
			this.Materia.ReadOnly = true;
			this.Materia.Width = 200;
			// 
			// Detalles
			// 
			this.Detalles.HeaderText = "Detalles";
			this.Detalles.Name = "Detalles";
			this.Detalles.ReadOnly = true;
			this.Detalles.Text = "Detalles";
			this.Detalles.UseColumnTextForButtonValue = true;
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
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
		private Bunifu.Framework.UI.BunifuFlatButton btnNuevaClase;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
		private System.Windows.Forms.DataGridViewButtonColumn Detalles;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Timer timer1;
	}
}