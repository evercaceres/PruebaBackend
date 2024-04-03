using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PruebaCLT.Form1;

namespace PruebaCLT
{
	public partial class EditarProductoForm : Form
	{
		private Producto ProductoActual;
		public bool CambiosGuardados { get; private set; }

		public EditarProductoForm(Producto productoSeleccionado)
		{
			InitializeComponent();
			ProductoActual = productoSeleccionado;
			CambiosGuardados = false;

		}

		private void EditarProductoForm_Load_1(object sender, EventArgs e)
		{
			// Preencher los TextBoxes con los datos actuales del producto
			txtNombre.Text = ProductoActual.Nombre;
			txtPrecio.Text = ProductoActual.Precio.ToString();
			txtCodigo.Text = ProductoActual.Codigo;
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnGuardarCambios_Click(object sender, EventArgs e)
		{
			// Obtener los datos editados por el usuario
			ProductoActual.Nombre = txtNombre.Text;
			ProductoActual.Precio = (int)decimal.Parse(txtPrecio.Text);
			ProductoActual.Codigo = txtCodigo.Text;
			CambiosGuardados = true;

			// Cerrar el formulario de edición de productos
			this.Close();
		}
	}
}
