namespace ControlLaboratorioElectronica.Vistas
{
    partial class extNuevoProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(extNuevoProfesor));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_materia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_carrera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_grupo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.alum = new System.Windows.Forms.DataGridView();
            this.NumControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton_prac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.boton_guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alum)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.ForeColor = System.Drawing.Color.Black;
            this.txt_nom.HintForeColor = System.Drawing.Color.Empty;
            this.txt_nom.HintText = "Nombre ";
            this.txt_nom.isPassword = false;
            this.txt_nom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.txt_nom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.txt_nom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.txt_nom.LineThickness = 3;
            this.txt_nom.Location = new System.Drawing.Point(392, 115);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(6);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(326, 64);
            this.txt_nom.TabIndex = 0;
            this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 67);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(272, 28);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Registro de Profesor";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.Image = global::ControlLaboratorioElectronica.Properties.Resources.exit;
            this.salir.ImageActive = null;
            this.salir.Location = new System.Drawing.Point(968, 11);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(35, 25);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salir.TabIndex = 0;
            this.salir.TabStop = false;
            this.salir.Zoom = 10;
            this.salir.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // txt_materia
            // 
            this.txt_materia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_materia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_materia.ForeColor = System.Drawing.Color.Black;
            this.txt_materia.HintForeColor = System.Drawing.Color.Empty;
            this.txt_materia.HintText = "Materia";
            this.txt_materia.isPassword = false;
            this.txt_materia.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.txt_materia.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.txt_materia.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.txt_materia.LineThickness = 3;
            this.txt_materia.Location = new System.Drawing.Point(392, 212);
            this.txt_materia.Margin = new System.Windows.Forms.Padding(6);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(326, 64);
            this.txt_materia.TabIndex = 2;
            this.txt_materia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_materia.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox2_OnValueChanged);
            // 
            // txt_carrera
            // 
            this.txt_carrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_carrera.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carrera.ForeColor = System.Drawing.Color.Black;
            this.txt_carrera.HintForeColor = System.Drawing.Color.Empty;
            this.txt_carrera.HintText = "Carrera";
            this.txt_carrera.isPassword = false;
            this.txt_carrera.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.txt_carrera.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.txt_carrera.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.txt_carrera.LineThickness = 3;
            this.txt_carrera.Location = new System.Drawing.Point(392, 319);
            this.txt_carrera.Margin = new System.Windows.Forms.Padding(6);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(326, 64);
            this.txt_carrera.TabIndex = 3;
            this.txt_carrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_grupo
            // 
            this.txt_grupo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_grupo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grupo.ForeColor = System.Drawing.Color.Black;
            this.txt_grupo.HintForeColor = System.Drawing.Color.Empty;
            this.txt_grupo.HintText = "Grupo";
            this.txt_grupo.isPassword = false;
            this.txt_grupo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.txt_grupo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.txt_grupo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.txt_grupo.LineThickness = 3;
            this.txt_grupo.Location = new System.Drawing.Point(392, 415);
            this.txt_grupo.Margin = new System.Windows.Forms.Padding(6);
            this.txt_grupo.Name = "txt_grupo";
            this.txt_grupo.Size = new System.Drawing.Size(326, 64);
            this.txt_grupo.TabIndex = 4;
            this.txt_grupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // alum
            // 
            this.alum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumControl,
            this.Nombre});
            this.alum.Location = new System.Drawing.Point(232, 542);
            this.alum.Margin = new System.Windows.Forms.Padding(4);
            this.alum.Name = "alum";
            this.alum.Size = new System.Drawing.Size(752, 120);
            this.alum.TabIndex = 5;
            // 
            // NumControl
            // 
            this.NumControl.HeaderText = "Num Control";
            this.NumControl.Name = "NumControl";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // boton_prac
            // 
            this.boton_prac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.boton_prac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.boton_prac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_prac.BorderRadius = 0;
            this.boton_prac.ButtonText = "Subir Practicas";
            this.boton_prac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_prac.DisabledColor = System.Drawing.Color.Gray;
            this.boton_prac.Iconcolor = System.Drawing.Color.Transparent;
            this.boton_prac.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.agregar_carpeta;
            this.boton_prac.Iconimage_right = null;
            this.boton_prac.Iconimage_right_Selected = null;
            this.boton_prac.Iconimage_Selected = null;
            this.boton_prac.IconMarginLeft = 0;
            this.boton_prac.IconMarginRight = 0;
            this.boton_prac.IconRightVisible = true;
            this.boton_prac.IconRightZoom = 0D;
            this.boton_prac.IconVisible = true;
            this.boton_prac.IconZoom = 90D;
            this.boton_prac.IsTab = false;
            this.boton_prac.Location = new System.Drawing.Point(740, 319);
            this.boton_prac.Margin = new System.Windows.Forms.Padding(4);
            this.boton_prac.Name = "boton_prac";
            this.boton_prac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.boton_prac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.boton_prac.OnHoverTextColor = System.Drawing.Color.White;
            this.boton_prac.selected = false;
            this.boton_prac.Size = new System.Drawing.Size(184, 73);
            this.boton_prac.TabIndex = 6;
            this.boton_prac.Text = "Subir Practicas";
            this.boton_prac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_prac.Textcolor = System.Drawing.Color.White;
            this.boton_prac.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_prac.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(618, 994);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(429, 102);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Text = "bunifuFlatButton2";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Guardar";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(864, 1045);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(543, 102);
            this.bunifuFlatButton3.TabIndex = 8;
            this.bunifuFlatButton3.Text = "Guardar";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // boton_guardar
            // 
            this.boton_guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.boton_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.boton_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_guardar.BorderRadius = 0;
            this.boton_guardar.ButtonText = "Guardar";
            this.boton_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_guardar.DisabledColor = System.Drawing.Color.Gray;
            this.boton_guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.boton_guardar.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.guardar;
            this.boton_guardar.Iconimage_right = null;
            this.boton_guardar.Iconimage_right_Selected = null;
            this.boton_guardar.Iconimage_Selected = null;
            this.boton_guardar.IconMarginLeft = 0;
            this.boton_guardar.IconMarginRight = 0;
            this.boton_guardar.IconRightVisible = true;
            this.boton_guardar.IconRightZoom = 0D;
            this.boton_guardar.IconVisible = true;
            this.boton_guardar.IconZoom = 90D;
            this.boton_guardar.IsTab = false;
            this.boton_guardar.Location = new System.Drawing.Point(496, 691);
            this.boton_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.boton_guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.boton_guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.boton_guardar.selected = false;
            this.boton_guardar.Size = new System.Drawing.Size(183, 72);
            this.boton_guardar.TabIndex = 9;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_guardar.Textcolor = System.Drawing.Color.White;
            this.boton_guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // extNuevoProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 880);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.boton_prac);
            this.Controls.Add(this.alum);
            this.Controls.Add(this.txt_grupo);
            this.Controls.Add(this.txt_carrera);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nom);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "extNuevoProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "extNuevoProfesor";
            this.Load += new System.EventHandler(this.ExtNuevoProfesor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_materia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_carrera;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_grupo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton boton_prac;
        private System.Windows.Forms.DataGridView alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private Bunifu.Framework.UI.BunifuFlatButton boton_guardar;
        private Bunifu.Framework.UI.BunifuImageButton salir;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}