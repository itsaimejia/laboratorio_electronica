namespace ControlLaboratorioElectronica
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelTransicion = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.canvas = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnEstadistico = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnPrestamosExt = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnPrincipal = new Bunifu.Framework.UI.BunifuFlatButton();
			this.panelMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.panelMenu.Controls.Add(this.pictureBox1);
			this.panelMenu.Controls.Add(this.btnEstadistico);
			this.panelMenu.Controls.Add(this.btnPrestamosExt);
			this.panelMenu.Controls.Add(this.btnPrincipal);
			this.panelTransicion.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
			this.panelMenu.Location = new System.Drawing.Point(-1, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(49, 579);
			this.panelMenu.TabIndex = 1;
			// 
			// panelTransicion
			// 
			this.panelTransicion.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
			this.panelTransicion.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 1F;
			this.panelTransicion.DefaultAnimation = animation1;
			// 
			// canvas
			// 
			this.panelTransicion.SetDecoration(this.canvas, BunifuAnimatorNS.DecorationType.None);
			this.canvas.Location = new System.Drawing.Point(50, 55);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(831, 524);
			this.canvas.TabIndex = 2;
			this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
			this.panel1.Controls.Add(this.btnMinimizar);
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.bunifuCustomLabel1);
			this.panel1.Controls.Add(this.btnMenu);
			this.panelTransicion.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(881, 49);
			this.panel1.TabIndex = 3;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.panelTransicion.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 9);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(350, 28);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Laboratorio de Electronica";
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
			this.panelTransicion.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
			this.btnMinimizar.Image = global::ControlLaboratorioElectronica.Properties.Resources.minimizar;
			this.btnMinimizar.ImageActive = null;
			this.btnMinimizar.Location = new System.Drawing.Point(813, 9);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(25, 23);
			this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimizar.TabIndex = 5;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Zoom = 10;
			this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
			this.panelTransicion.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
			this.btnCerrar.Image = global::ControlLaboratorioElectronica.Properties.Resources.exit;
			this.btnCerrar.ImageActive = null;
			this.btnCerrar.Location = new System.Drawing.Point(844, 9);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(25, 23);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrar.TabIndex = 4;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Zoom = 10;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.Color.Transparent;
			this.panelTransicion.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
			this.btnMenu.Image = global::ControlLaboratorioElectronica.Properties.Resources.menu;
			this.btnMenu.ImageActive = null;
			this.btnMenu.Location = new System.Drawing.Point(12, 12);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(28, 29);
			this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMenu.TabIndex = 3;
			this.btnMenu.TabStop = false;
			this.btnMenu.Zoom = 10;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// pictureBox1
			// 
			this.panelTransicion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
			this.pictureBox1.Image = global::ControlLaboratorioElectronica.Properties.Resources.logo_tecnm;
			this.pictureBox1.Location = new System.Drawing.Point(51, 111);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(88, 89);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// btnEstadistico
			// 
			this.btnEstadistico.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnEstadistico.BackColor = System.Drawing.Color.Transparent;
			this.btnEstadistico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEstadistico.BorderRadius = 0;
			this.btnEstadistico.ButtonText = "Estadistico";
			this.btnEstadistico.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelTransicion.SetDecoration(this.btnEstadistico, BunifuAnimatorNS.DecorationType.None);
			this.btnEstadistico.DisabledColor = System.Drawing.Color.Gray;
			this.btnEstadistico.Iconcolor = System.Drawing.Color.Transparent;
			this.btnEstadistico.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.estadistica;
			this.btnEstadistico.Iconimage_right = null;
			this.btnEstadistico.Iconimage_right_Selected = null;
			this.btnEstadistico.Iconimage_Selected = null;
			this.btnEstadistico.IconMarginLeft = 0;
			this.btnEstadistico.IconMarginRight = 0;
			this.btnEstadistico.IconRightVisible = true;
			this.btnEstadistico.IconRightZoom = 0D;
			this.btnEstadistico.IconVisible = true;
			this.btnEstadistico.IconZoom = 90D;
			this.btnEstadistico.IsTab = false;
			this.btnEstadistico.Location = new System.Drawing.Point(-2, 376);
			this.btnEstadistico.Name = "btnEstadistico";
			this.btnEstadistico.Normalcolor = System.Drawing.Color.Transparent;
			this.btnEstadistico.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnEstadistico.OnHoverTextColor = System.Drawing.Color.White;
			this.btnEstadistico.selected = false;
			this.btnEstadistico.Size = new System.Drawing.Size(196, 49);
			this.btnEstadistico.TabIndex = 2;
			this.btnEstadistico.Text = "Estadistico";
			this.btnEstadistico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEstadistico.Textcolor = System.Drawing.Color.White;
			this.btnEstadistico.TextFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEstadistico.Click += new System.EventHandler(this.btnEstadistico_Click);
			// 
			// btnPrestamosExt
			// 
			this.btnPrestamosExt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnPrestamosExt.BackColor = System.Drawing.Color.Transparent;
			this.btnPrestamosExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPrestamosExt.BorderRadius = 0;
			this.btnPrestamosExt.ButtonText = "Prestamos Ext";
			this.btnPrestamosExt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelTransicion.SetDecoration(this.btnPrestamosExt, BunifuAnimatorNS.DecorationType.None);
			this.btnPrestamosExt.DisabledColor = System.Drawing.Color.Gray;
			this.btnPrestamosExt.Iconcolor = System.Drawing.Color.Transparent;
			this.btnPrestamosExt.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.prestamos;
			this.btnPrestamosExt.Iconimage_right = null;
			this.btnPrestamosExt.Iconimage_right_Selected = null;
			this.btnPrestamosExt.Iconimage_Selected = null;
			this.btnPrestamosExt.IconMarginLeft = 0;
			this.btnPrestamosExt.IconMarginRight = 0;
			this.btnPrestamosExt.IconRightVisible = true;
			this.btnPrestamosExt.IconRightZoom = 0D;
			this.btnPrestamosExt.IconVisible = true;
			this.btnPrestamosExt.IconZoom = 90D;
			this.btnPrestamosExt.IsTab = false;
			this.btnPrestamosExt.Location = new System.Drawing.Point(1, 305);
			this.btnPrestamosExt.Name = "btnPrestamosExt";
			this.btnPrestamosExt.Normalcolor = System.Drawing.Color.Transparent;
			this.btnPrestamosExt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnPrestamosExt.OnHoverTextColor = System.Drawing.Color.White;
			this.btnPrestamosExt.selected = false;
			this.btnPrestamosExt.Size = new System.Drawing.Size(193, 49);
			this.btnPrestamosExt.TabIndex = 1;
			this.btnPrestamosExt.Text = "Prestamos Ext";
			this.btnPrestamosExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrestamosExt.Textcolor = System.Drawing.Color.White;
			this.btnPrestamosExt.TextFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrestamosExt.Click += new System.EventHandler(this.btnPrestamosExt_Click);
			// 
			// btnPrincipal
			// 
			this.btnPrincipal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
			this.btnPrincipal.BackColor = System.Drawing.Color.Transparent;
			this.btnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPrincipal.BorderRadius = 0;
			this.btnPrincipal.ButtonText = "Principal";
			this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelTransicion.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
			this.btnPrincipal.DisabledColor = System.Drawing.Color.Gray;
			this.btnPrincipal.Iconcolor = System.Drawing.Color.Transparent;
			this.btnPrincipal.Iconimage = global::ControlLaboratorioElectronica.Properties.Resources.home1;
			this.btnPrincipal.Iconimage_right = null;
			this.btnPrincipal.Iconimage_right_Selected = null;
			this.btnPrincipal.Iconimage_Selected = null;
			this.btnPrincipal.IconMarginLeft = 0;
			this.btnPrincipal.IconMarginRight = 0;
			this.btnPrincipal.IconRightVisible = true;
			this.btnPrincipal.IconRightZoom = 0D;
			this.btnPrincipal.IconVisible = true;
			this.btnPrincipal.IconZoom = 90D;
			this.btnPrincipal.IsTab = false;
			this.btnPrincipal.Location = new System.Drawing.Point(1, 230);
			this.btnPrincipal.Name = "btnPrincipal";
			this.btnPrincipal.Normalcolor = System.Drawing.Color.Transparent;
			this.btnPrincipal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
			this.btnPrincipal.OnHoverTextColor = System.Drawing.Color.White;
			this.btnPrincipal.selected = false;
			this.btnPrincipal.Size = new System.Drawing.Size(193, 49);
			this.btnPrincipal.TabIndex = 0;
			this.btnPrincipal.Text = "Principal";
			this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrincipal.Textcolor = System.Drawing.Color.White;
			this.btnPrincipal.TextFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(881, 578);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.canvas);
			this.panelTransicion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panelMenu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panelMenu;
		private Bunifu.Framework.UI.BunifuFlatButton btnPrincipal;
		private Bunifu.Framework.UI.BunifuFlatButton btnEstadistico;
		private Bunifu.Framework.UI.BunifuFlatButton btnPrestamosExt;
		private System.Windows.Forms.PictureBox pictureBox1;
		private BunifuAnimatorNS.BunifuTransition panelTransicion;
		private System.Windows.Forms.Panel canvas;
		private Bunifu.Framework.UI.BunifuImageButton btnMenu;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
		private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
	}
}

