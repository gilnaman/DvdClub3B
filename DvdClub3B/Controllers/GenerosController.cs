/*
 * Created by SharpDevelop.
 * User: Gilberto
 * Date: 05/07/2018
 * Time: 12:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos; // Para tener acceso a los datos
using System.Windows.Forms; // Para tener acceso a los componentes

namespace DvdClub3B.Controllers
{
	/// <summary>
	/// Description of GenerosController.
	/// </summary>
	public class GenerosController
	{
		//Definimos los campos como atributos
		
		public string id_categoria  { get; set; }
		public string categoria  { get; set; }
		
		public GenerosController()
		{
		}
		
		public void BuscarCategorias(string cat,DataGridView dgv)
		{
			string sql= "SELECT * from categorias WHERE categoria LIKE'" + cat + "%'";
			
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "datos";
		}
		
		// Método para agregar una nueva categoria
		
		public void Store()
		{
			string sql= string.Format("INSERT INTO categorias(id_categoria,categoria) VALUES('{0}','{1}')",
			                         id_categoria,categoria);
			FrameBD.SQLIDU(sql);
		}
		
		// Almacena un género mediante un procedimiento almacenado
		public void Guardar()
		{
			string proc = String.Format("CALL AddCategoria('{0}','{1}');",id_categoria,categoria);
			FrameBD.SQLIDU(proc);
		}
		
		// Método para eliminar una categoria
		
		public void Eliminar(string pk)
		{
			string sql = string.Format("DELETE FROM categorias WHERE id_categoria='{0}';",pk);
			//MessageBox.Show(sql);
			FrameBD.SQLIDU(sql);
		}
		
		
		public void Update(string pk,string cat)
		{
			string sql = string.Format("UPDATE categorias SET categoria='{0}' WHERE id_categoria='{1}';",cat,pk);
			FrameBD.SQLIDU(sql);
			
		}
		
		
		public void getCategorias(ComboBox cmb)
		{
			// Paso 1: defimos los datos que llenarán al comboBox
			string consulta= "SELECT id_categoria,categoria FROM categorias";
			
			//Paso 2:  Vinculasmos los datos al DAtasource del COmbo
			cmb.DataSource = FrameBD.SQLCOMBO(consulta);
			
			//Paso 3: Especificar el valor a mostrar al usuario
			cmb.DisplayMember ="categoria";
			
			// Paso 4: Definir la clave primaria
			cmb.ValueMember="id_categoria";
			
		}
		
		
	}
}
