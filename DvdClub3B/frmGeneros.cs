/*
 * Created by SharpDevelop.
 * User: Gilberto
 * Date: 28/06/2018
 * Time: 01:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using DvdClub3B.Controllers; // Nos da acceso a los controladores

namespace DvdClub3B
{
	/// <summary>
	/// Description of frmGeneros.
	/// </summary>
	public partial class frmGeneros : Form
	{
		GenerosController oGenero = new GenerosController();
		
		public frmGeneros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
		void FrmGenerosLoad(object sender, EventArgs e)
		{
			oGenero.BuscarCategorias(txtBuscar.Text,dataGridView1);
			
		}
		
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			oGenero.BuscarCategorias(txtBuscar.Text,dataGridView1);
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			oGenero.id_categoria = txtClave.Text;
			oGenero.categoria = txtNombre.Text;
			//oGenero.Store(); // Guardamos los datos capturados
			oGenero.Guardar();
			
			oGenero.BuscarCategorias(txtBuscar.Text,dataGridView1); // Actualizamos el datagrid
			
			txtClave.Clear();
			txtNombre.Clear();
			txtClave.Focus();
			
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de eliminar","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
	
			{			
			string clave = dataGridView1[0,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			oGenero.Eliminar(clave);
			oGenero.BuscarCategorias(txtBuscar.Text,dataGridView1); // Actualizamos el datagrid
			}
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			txtClave.Text = dataGridView1[0,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Text = dataGridView1[1,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Focus();
			
			btnGuardarU.Visible=true;
			btnGuardar.Visible=false;
		}
		
		void BtnGuardarUClick(object sender, EventArgs e)
		{
			oGenero.Update(txtClave.Text,txtNombre.Text);
			oGenero.BuscarCategorias(txtBuscar.Text,dataGridView1); // Actualizamos el datagrid
			txtClave.Clear();
			txtNombre.Clear();
			
			btnGuardarU.Visible=false;
			btnGuardar.Visible=true;
			
			
		}
	}
}
