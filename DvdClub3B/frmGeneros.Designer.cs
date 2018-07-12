/*
 * Created by SharpDevelop.
 * User: Gilberto
 * Date: 28/06/2018
 * Time: 01:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DvdClub3B
{
	partial class frmGeneros
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnGuardarU = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buscar por nombre";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(120, 22);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(418, 20);
			this.txtBuscar.TabIndex = 1;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Clave del genero";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(110, 82);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(109, 20);
			this.txtClave.TabIndex = 3;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(110, 111);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(109, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "nombre";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(236, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(302, 150);
			this.dataGridView1.TabIndex = 6;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(24, 233);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(124, 33);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(154, 233);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(124, 33);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(293, 233);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(124, 33);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "Modificar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnGuardarU
			// 
			this.btnGuardarU.Location = new System.Drawing.Point(24, 233);
			this.btnGuardarU.Name = "btnGuardarU";
			this.btnGuardarU.Size = new System.Drawing.Size(124, 33);
			this.btnGuardarU.TabIndex = 10;
			this.btnGuardarU.Text = "Guardar";
			this.btnGuardarU.UseVisualStyleBackColor = true;
			this.btnGuardarU.Visible = false;
			this.btnGuardarU.Click += new System.EventHandler(this.BtnGuardarUClick);
			// 
			// frmGeneros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 278);
			this.Controls.Add(this.btnGuardarU);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "frmGeneros";
			this.Text = "Catálogo de géneros";
			this.Load += new System.EventHandler(this.FrmGenerosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnGuardarU;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label1;
	}
}
