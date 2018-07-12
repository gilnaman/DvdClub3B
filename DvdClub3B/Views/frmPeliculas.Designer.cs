/*
 * Created by SharpDevelop.
 * User: Gilberto
 * Date: 10/07/2018
 * Time: 10:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DvdClub3B.Views
{
	partial class frmPeliculas
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
			this.cmbCategorias = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cmbCategorias
			// 
			this.cmbCategorias.FormattingEnabled = true;
			this.cmbCategorias.Location = new System.Drawing.Point(137, 23);
			this.cmbCategorias.Name = "cmbCategorias";
			this.cmbCategorias.Size = new System.Drawing.Size(247, 21);
			this.cmbCategorias.TabIndex = 0;
			// 
			// frmPeliculas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 333);
			this.Controls.Add(this.cmbCategorias);
			this.Name = "frmPeliculas";
			this.Text = "frmPeliculas";
			this.Load += new System.EventHandler(this.FrmPeliculasLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbCategorias;
	}
}
