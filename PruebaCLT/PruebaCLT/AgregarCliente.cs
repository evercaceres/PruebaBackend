using System;
using System.Windows.Forms;

namespace PruebaCLT
{
	public partial class AgregarCliente : Form
	{
		public AgregarCliente()
		{
			InitializeComponent();
		}
		
		// Evento Load del formulario
		private void AgregarCliente_Load(object sender, EventArgs e)
		{
			// Puedes realizar alguna inicialización adicional aquí si es necesario
		}

		// Método para limpiar los campos del formulario
		// Método para limpiar los campos del formulario


		private void button2_Click()
		{
			/*txtNombre.Clear();
			txtApellido.Clear();
			txtDireccion.Clear();
			txtCedula.Clear();
			txtRUC.Clear();
			//* Limpia otros campos si es necesario*/
		}

		// Evento Click del botón "Cancelar"
		private void button_Click(object sender, EventArgs e)
		{
			button2_Click();
			this.Close(); // Cierra el formulario
		}

		// Evento Click del botón "Guardar"
		private void button1_Click(object sender, EventArgs e)
		{
			// Aquí debes escribir la lógica para guardar el cliente en la base de datos
			// Puedes utilizar los valores de los TextBoxes para guardar la información del cliente
			// Recuerda realizar las validaciones necesarias antes de guardar los datos
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
