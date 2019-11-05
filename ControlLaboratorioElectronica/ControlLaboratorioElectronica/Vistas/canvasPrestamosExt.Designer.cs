namespace ControlLaboratorioElectronica.Vistas
{
	partial class canvasPrestamosExt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(canvasPrestamosExt));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtNumControl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtCarrera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.dgvMaterial = new System.Windows.Forms.DataGridView();
			this.id_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnListaPrestamos = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btn_guardar = new Bunifu.Framework.UI.BunifuFlatButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// txtNombre
			// 
			this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
			this.txtNombre.HintText = "Nombre";
			this.txtNombre.isPassword = false;
			this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtNombre.LineThickness = 3;
			this.txtNombre.Location = new System.Drawing.Point(159, 105);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(270, 33);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txtNumControl
			// 
			this.txtNumControl.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNumControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtNumControl.HintForeColor = System.Drawing.Color.Empty;
			this.txtNumControl.HintText = "No. Control";
			this.txtNumControl.isPassword = false;
			this.txtNumControl.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtNumControl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtNumControl.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtNumControl.LineThickness = 3;
			this.txtNumControl.Location = new System.Drawing.Point(159, 48);
			this.txtNumControl.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumControl.Name = "txtNumControl";
			this.txtNumControl.Size = new System.Drawing.Size(270, 36);
			this.txtNumControl.TabIndex = 1;
			this.txtNumControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNumControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumControl_KeyPress);
			// 
			// txtCarrera
			// 
			this.txtCarrera.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCarrera.Enabled = false;
			this.txtCarrera.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCarrera.HintForeColor = System.Drawing.Color.Empty;
			this.txtCarrera.HintText = "Carrera";
			this.txtCarrera.isPassword = false;
			this.txtCarrera.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.txtCarrera.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.txtCarrera.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.txtCarrera.LineThickness = 3;
			this.txtCarrera.Location = new System.Drawing.Point(159, 165);
			this.txtCarrera.Margin = new System.Windows.Forms.Padding(4);
			this.txtCarrera.Name = "txtCarrera";
			this.txtCarrera.Size = new System.Drawing.Size(270, 35);
			this.txtCarrera.TabIndex = 2;
			this.txtCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// dgvMaterial
			// 
			this.dgvMaterial.AllowUserToResizeColumns = false;
			this.dgvMaterial.AllowUserToResizeRows = false;
			this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_material,
            this.Descripcion,
            this.Cantidad,
            this.Quitar});
			this.dgvMaterial.Enabled = false;
			this.dgvMaterial.Location = new System.Drawing.Point(17, 25);
			this.dgvMaterial.Name = "dgvMaterial";
			this.dgvMaterial.Size = new System.Drawing.Size(620, 175);
			this.dgvMaterial.TabIndex = 8;
			// 
			// id_material
			// 
			this.id_material.HeaderText = "ID Material";
			this.id_material.Name = "id_material";
			this.id_material.Width = 150;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Width = 250;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			// 
			// Quitar
			// 
			this.Quitar.HeaderText = "Quitar";
			this.Quitar.Name = "Quitar";
			this.Quitar.Width = 75;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvMaterial);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(103, 234);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(643, 210);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Materiales";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnGuardar);
			this.groupBox2.Controls.Add(this.btnListaPrestamos);
			this.groupBox2.Controls.Add(this.bunifuFlatButton3);
			this.groupBox2.Controls.Add(this.bunifuFlatButton2);
			this.groupBox2.Controls.Add(this.txtCarrera);
			this.groupBox2.Controls.Add(this.txtNombre);
			this.groupBox2.Controls.Add(this.txtNumControl);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(34, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(760, 500);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Prestamos Externos";
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
			this.btnGuardar.Enabled = false;
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
			this.btnGuardar.Location = new System.Drawing.Point(304, 457);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(6);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
			this.btnGuardar.selected = false;
			this.btnGuardar.Size = new System.Drawing.Size(136, 34);
			this.btnGuardar.TabIndex = 15;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Textcolor = System.Drawing.Color.White;
			this.btnGuardar.TextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnListaPrestamos
			// 
			this.btnListaPrestamos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnListaPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnListaPrestamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnListaPrestamos.BorderRadius = 0;
			this.btnListaPrestamos.ButtonText = "Lista prestamos";
			this.btnListaPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListaPrestamos.DisabledColor = System.Drawing.Color.Gray;
			this.btnListaPrestamos.Iconcolor = System.Drawing.Color.Transparent;
			this.btnListaPrestamos.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.lista;
			this.btnListaPrestamos.Iconimage_right = null;
			this.btnListaPrestamos.Iconimage_right_Selected = null;
			this.btnListaPrestamos.Iconimage_Selected = null;
			this.btnListaPrestamos.IconMarginLeft = 0;
			this.btnListaPrestamos.IconMarginRight = 0;
			this.btnListaPrestamos.IconRightVisible = true;
			this.btnListaPrestamos.IconRightZoom = 0D;
			this.btnListaPrestamos.IconVisible = true;
			this.btnListaPrestamos.IconZoom = 90D;
			this.btnListaPrestamos.IsTab = false;
			this.btnListaPrestamos.Location = new System.Drawing.Point(550, 37);
			this.btnListaPrestamos.Margin = new System.Windows.Forms.Padding(4);
			this.btnListaPrestamos.Name = "btnListaPrestamos";
			this.btnListaPrestamos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btnListaPrestamos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnListaPrestamos.OnHoverTextColor = System.Drawing.Color.White;
			this.btnListaPrestamos.selected = false;
			this.btnListaPrestamos.Size = new System.Drawing.Size(202, 37);
			this.btnListaPrestamos.TabIndex = 14;
			this.btnListaPrestamos.Text = "Lista prestamos";
			this.btnListaPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListaPrestamos.Textcolor = System.Drawing.Color.White;
			this.btnListaPrestamos.TextFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// bunifuFlatButton3
			// 
			this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "Guardar";
			this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = true;
			this.bunifuFlatButton3.IconRightZoom = 0D;
			this.bunifuFlatButton3.IconVisible = true;
			this.bunifuFlatButton3.IconZoom = 90D;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new System.Drawing.Point(348, 513);
			this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(9);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new System.Drawing.Size(136, 45);
			this.bunifuFlatButton3.TabIndex = 13;
			this.bunifuFlatButton3.Text = "Guardar";
			this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// bunifuFlatButton2
			// 
			this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
			this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0D;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 90D;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new System.Drawing.Point(410, 624);
			this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(362, 70);
			this.bunifuFlatButton2.TabIndex = 10;
			this.bunifuFlatButton2.Text = "bunifuFlatButton2";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 90D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(279, 611);
			this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(362, 70);
			this.bunifuFlatButton1.TabIndex = 7;
			this.bunifuFlatButton1.Text = "bunifuFlatButton1";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// btn_guardar
			// 
			this.btn_guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_guardar.BorderRadius = 0;
			this.btn_guardar.ButtonText = "Guardar";
			this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_guardar.DisabledColor = System.Drawing.Color.Gray;
			this.btn_guardar.Iconcolor = System.Drawing.Color.Transparent;
			this.btn_guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Iconimage")));
			this.btn_guardar.Iconimage_right = null;
			this.btn_guardar.Iconimage_right_Selected = null;
			this.btn_guardar.Iconimage_Selected = null;
			this.btn_guardar.IconMarginLeft = 0;
			this.btn_guardar.IconMarginRight = 0;
			this.btn_guardar.IconRightVisible = true;
			this.btn_guardar.IconRightZoom = 0D;
			this.btn_guardar.IconVisible = true;
			this.btn_guardar.IconZoom = 90D;
			this.btn_guardar.IsTab = false;
			this.btn_guardar.Location = new System.Drawing.Point(294, 624);
			this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
			this.btn_guardar.Name = "btn_guardar";
			this.btn_guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btn_guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.btn_guardar.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_guardar.selected = false;
			this.btn_guardar.Size = new System.Drawing.Size(231, 72);
			this.btn_guardar.TabIndex = 6;
			this.btn_guardar.Text = "Guardar";
			this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_guardar.Textcolor = System.Drawing.Color.White;
			this.btn_guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// canvasPrestamosExt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(831, 524);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bunifuFlatButton1);
			this.Controls.Add(this.btn_guardar);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "canvasPrestamosExt";
			this.Text = "canvasPrestamosExt";
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_guardar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCarrera;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumControl;
		private System.Windows.Forms.DataGridView dgvMaterial;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_material;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewButtonColumn Quitar;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
		private Bunifu.Framework.UI.BunifuFlatButton btnListaPrestamos;
		private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
	}
}