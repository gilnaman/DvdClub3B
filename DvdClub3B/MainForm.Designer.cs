/*
 * Created by SharpDevelop.
 * User: Gilberto
 * Date: 26/06/2018
 * Time: 10:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DvdClub3B
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPanelPelis = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPanelGeneros = new System.Windows.Forms.ToolStripMenuItem();
			this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rentarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.devolverPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peliculasADevolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDevolverHoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lasMasRentadasDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasSemanalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resumenDeRecargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.respaldarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restaurarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aCercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.multarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.catalogosToolStripMenuItem,
									this.operacionesToolStripMenuItem,
									this.informesToolStripMenuItem,
									this.herramientasToolStripMenuItem,
									this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(740, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// catalogosToolStripMenuItem
			// 
			this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.peliculasToolStripMenuItem,
									this.clientesToolStripMenuItem,
									this.generosToolStripMenuItem});
			this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
			this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.catalogosToolStripMenuItem.Text = "&Catalogos";
			// 
			// peliculasToolStripMenuItem
			// 
			this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuPanelPelis,
									this.agregarPeliculaToolStripMenuItem,
									this.buscarPeliculaToolStripMenuItem});
			this.peliculasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peliculasToolStripMenuItem.Image")));
			this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
			this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.peliculasToolStripMenuItem.Text = "Peliculas";
			// 
			// mnuPanelPelis
			// 
			this.mnuPanelPelis.Name = "mnuPanelPelis";
			this.mnuPanelPelis.Size = new System.Drawing.Size(160, 22);
			this.mnuPanelPelis.Text = "Panel peliculas";
			this.mnuPanelPelis.ToolTipText = "Gestión de películas";
			this.mnuPanelPelis.Click += new System.EventHandler(this.MnuPanelPelisClick);
			// 
			// agregarPeliculaToolStripMenuItem
			// 
			this.agregarPeliculaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarPeliculaToolStripMenuItem.Image")));
			this.agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
			this.agregarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.agregarPeliculaToolStripMenuItem.Text = "A&gregar Pelicula";
			// 
			// buscarPeliculaToolStripMenuItem
			// 
			this.buscarPeliculaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarPeliculaToolStripMenuItem.Image")));
			this.buscarPeliculaToolStripMenuItem.Name = "buscarPeliculaToolStripMenuItem";
			this.buscarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.buscarPeliculaToolStripMenuItem.Text = "Buscar Pelicula";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.panelDeClienteToolStripMenuItem,
									this.agregarClienteToolStripMenuItem});
			this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			// 
			// panelDeClienteToolStripMenuItem
			// 
			this.panelDeClienteToolStripMenuItem.Name = "panelDeClienteToolStripMenuItem";
			this.panelDeClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.panelDeClienteToolStripMenuItem.Text = "Panel de cliente";
			// 
			// agregarClienteToolStripMenuItem
			// 
			this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
			this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.agregarClienteToolStripMenuItem.Text = "Agregar cliente";
			// 
			// generosToolStripMenuItem
			// 
			this.generosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuPanelGeneros});
			this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
			this.generosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.generosToolStripMenuItem.Text = "Generos";
			// 
			// mnuPanelGeneros
			// 
			this.mnuPanelGeneros.Name = "mnuPanelGeneros";
			this.mnuPanelGeneros.Size = new System.Drawing.Size(164, 22);
			this.mnuPanelGeneros.Text = "Panel de generos";
			this.mnuPanelGeneros.Click += new System.EventHandler(this.MnuPanelGenerosClick);
			// 
			// operacionesToolStripMenuItem
			// 
			this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.rentarToolStripMenuItem,
									this.devolverPeliculasToolStripMenuItem,
									this.cambiarPeliculaToolStripMenuItem});
			this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
			this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.operacionesToolStripMenuItem.Text = "&Operaciones";
			this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.OperacionesToolStripMenuItemClick);
			// 
			// rentarToolStripMenuItem
			// 
			this.rentarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.nuevaToolStripMenuItem,
									this.cancelarToolStripMenuItem});
			this.rentarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentarToolStripMenuItem.Image")));
			this.rentarToolStripMenuItem.Name = "rentarToolStripMenuItem";
			this.rentarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.rentarToolStripMenuItem.Text = "Rentas";
			// 
			// nuevaToolStripMenuItem
			// 
			this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
			this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.nuevaToolStripMenuItem.Text = "Nueva";
			// 
			// cancelarToolStripMenuItem
			// 
			this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
			this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.cancelarToolStripMenuItem.Text = "Cancelar";
			// 
			// devolverPeliculasToolStripMenuItem
			// 
			this.devolverPeliculasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("devolverPeliculasToolStripMenuItem.Image")));
			this.devolverPeliculasToolStripMenuItem.Name = "devolverPeliculasToolStripMenuItem";
			this.devolverPeliculasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.devolverPeliculasToolStripMenuItem.Text = "Devolver peliculas";
			// 
			// cambiarPeliculaToolStripMenuItem
			// 
			this.cambiarPeliculaToolStripMenuItem.Name = "cambiarPeliculaToolStripMenuItem";
			this.cambiarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.cambiarPeliculaToolStripMenuItem.Text = "Cambiar Pelicula";
			// 
			// informesToolStripMenuItem
			// 
			this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.peliculasADevolverToolStripMenuItem,
									this.ventasToolStripMenuItem,
									this.ingresosToolStripMenuItem});
			this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
			this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.informesToolStripMenuItem.Text = "Informes";
			// 
			// peliculasADevolverToolStripMenuItem
			// 
			this.peliculasADevolverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aDevolverHoyToolStripMenuItem,
									this.lasMasRentadasDelMesToolStripMenuItem});
			this.peliculasADevolverToolStripMenuItem.Name = "peliculasADevolverToolStripMenuItem";
			this.peliculasADevolverToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.peliculasADevolverToolStripMenuItem.Text = "Peliculas";
			// 
			// aDevolverHoyToolStripMenuItem
			// 
			this.aDevolverHoyToolStripMenuItem.Name = "aDevolverHoyToolStripMenuItem";
			this.aDevolverHoyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.aDevolverHoyToolStripMenuItem.Text = "A devolver hoy";
			// 
			// lasMasRentadasDelMesToolStripMenuItem
			// 
			this.lasMasRentadasDelMesToolStripMenuItem.Name = "lasMasRentadasDelMesToolStripMenuItem";
			this.lasMasRentadasDelMesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.lasMasRentadasDelMesToolStripMenuItem.Text = "Las mas rentadas del mes";
			// 
			// ventasToolStripMenuItem
			// 
			this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ventasDelDiaToolStripMenuItem,
									this.ventasSemanalesToolStripMenuItem});
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.ventasToolStripMenuItem.Text = "Ventas";
			// 
			// ventasDelDiaToolStripMenuItem
			// 
			this.ventasDelDiaToolStripMenuItem.Name = "ventasDelDiaToolStripMenuItem";
			this.ventasDelDiaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.ventasDelDiaToolStripMenuItem.Text = "Ventas del dia";
			// 
			// ventasSemanalesToolStripMenuItem
			// 
			this.ventasSemanalesToolStripMenuItem.Name = "ventasSemanalesToolStripMenuItem";
			this.ventasSemanalesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.ventasSemanalesToolStripMenuItem.Text = "Ventas semanales";
			// 
			// ingresosToolStripMenuItem
			// 
			this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.resumenDeRecargosToolStripMenuItem});
			this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
			this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.ingresosToolStripMenuItem.Text = "Ingresos";
			// 
			// resumenDeRecargosToolStripMenuItem
			// 
			this.resumenDeRecargosToolStripMenuItem.Name = "resumenDeRecargosToolStripMenuItem";
			this.resumenDeRecargosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.resumenDeRecargosToolStripMenuItem.Text = "Resumen de recargos";
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.respaldarBDToolStripMenuItem,
									this.restaurarBDToolStripMenuItem,
									this.calculadoraToolStripMenuItem});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.herramientasToolStripMenuItem.Text = "Herramientas";
			// 
			// respaldarBDToolStripMenuItem
			// 
			this.respaldarBDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("respaldarBDToolStripMenuItem.Image")));
			this.respaldarBDToolStripMenuItem.Name = "respaldarBDToolStripMenuItem";
			this.respaldarBDToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.respaldarBDToolStripMenuItem.Text = "Respaldar BD";
			// 
			// restaurarBDToolStripMenuItem
			// 
			this.restaurarBDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restaurarBDToolStripMenuItem.Image")));
			this.restaurarBDToolStripMenuItem.Name = "restaurarBDToolStripMenuItem";
			this.restaurarBDToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.restaurarBDToolStripMenuItem.Text = "Restaurar BD";
			// 
			// calculadoraToolStripMenuItem
			// 
			this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
			this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.calculadoraToolStripMenuItem.Text = "Calculadora";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aCercaDeToolStripMenuItem,
									this.fAQToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// aCercaDeToolStripMenuItem
			// 
			this.aCercaDeToolStripMenuItem.Name = "aCercaDeToolStripMenuItem";
			this.aCercaDeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.aCercaDeToolStripMenuItem.Text = "A cerca de";
			// 
			// fAQToolStripMenuItem
			// 
			this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
			this.fAQToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.fAQToolStripMenuItem.Text = "FAQ";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripSeparator1,
									this.toolStripButton2,
									this.toolStripButton3,
									this.toolStripButton4,
									this.toolStripSeparator2,
									this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(740, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Agregar un nueva pelicula";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Registrar una renta";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.ToolTipText = "Registrar una devolción";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.ToolTipText = "Cambiar una película";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.nuevoClienteToolStripMenuItem,
									this.darDeBajaToolStripMenuItem,
									this.multarToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.ToolTipText = "Gestión de clientes";
			// 
			// nuevoClienteToolStripMenuItem
			// 
			this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
			this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.nuevoClienteToolStripMenuItem.Text = "Nuevo cliente";
			// 
			// darDeBajaToolStripMenuItem
			// 
			this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
			this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.darDeBajaToolStripMenuItem.Text = "Dar de baja";
			// 
			// multarToolStripMenuItem
			// 
			this.multarToolStripMenuItem.Name = "multarToolStripMenuItem";
			this.multarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.multarToolStripMenuItem.Text = "Multar";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 471);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(740, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(245, 17);
			this.toolStripStatusLabel1.Text = "UNIVERSIDAD TECNOLÓGICA DEL CENTRO";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(740, 493);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Sistema de control para DVDclub";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem multarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aCercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restaurarBDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem respaldarBDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resumenDeRecargosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasSemanalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasDelDiaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lasMasRentadasDelMesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDevolverHoyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem peliculasADevolverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cambiarPeliculaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem devolverPeliculasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rentarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuPanelGeneros;
		private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem panelDeClienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buscarPeliculaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarPeliculaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuPanelPelis;
		private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
