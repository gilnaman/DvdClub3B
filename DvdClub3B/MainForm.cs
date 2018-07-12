/*
 * Created by SharpDevelop.
 * User: Gilberto
 * Date: 26/06/2018
 * Time: 10:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DvdClub3B.Views;

namespace DvdClub3B
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void OperacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		 	lblStatus.Text = "B I E N V E N I D O ........................";
		 	
		}
		
		void MnuPanelGenerosClick(object sender, EventArgs e)
		{
			frmGeneros oGenero = new frmGeneros();
			oGenero.MdiParent = this;
			oGenero.Show();
			
			
		}
		
		void MnuPanelPelisClick(object sender, EventArgs e)
		{
			frmPeliculas oPelis = new frmPeliculas();
			oPelis.MdiParent = this;
			oPelis.Show();
			
		}
	}
}
