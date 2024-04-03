using System;
using System.Windows.Forms;
using static PruebaCLT.Form1;

namespace PruebaCLT
{
	public partial class AgregarProductoForm : Form
	{
		private Form1 mainForm;

		public bool CambiosGuardados { get; internal set; }
		public Producto NuevoProducto { get; internal set; }

		public AgregarProductoForm(Form1 mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
		}

		public AgregarProductoForm()
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Obtener los datos ingresados por el usuario
			string nombre = textName.Text;
			decimal precio = decimal.Parse(textPrecio.Text);
			string codigo = textCodigo.Text;

			// Crear una instancia de Producto con los datos ingresados
			Producto nuevoProducto = new Producto { Nombre = nombre, Precio = precio, Codigo = codigo };

			// Agregar el nuevo producto a la lista de productos en el formulario principal
			mainForm.AgregarProducto(nuevoProducto);

			// Cerrar el formulario de agregar producto
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void AgregarProductoForm_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

	
	}
}
