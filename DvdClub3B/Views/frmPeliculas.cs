/*
 * Created by SharpDevelop.
 * User: Gilberto
 * Date: 10/07/2018
 * Time: 10:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using DvdClub3B.Controllers;

namespace DvdClub3B.Views
{
	/// <summary>
	/// Description of frmPeliculas.
	/// </summary>
	public partial class frmPeliculas : Form
	{
		GenerosController oGenero = new GenerosController();
		
		public frmPeliculas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmPeliculasLoad(object sender, EventArgs e)
		{
			oGenero.getCategorias(cmbCategorias);
			
		}
	}
}
