using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCLT
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Obtener los valores actualizados de los TextBoxes
			int idCliente = ObtenerIdClienteSeleccionado(); // Implementa este método para obtener el ID del cliente seleccionado en la interfaz
		/*	string nombre = txtNombre.Text;
			string apellido = txtApellido.Text;
			string direccion = txtDireccion.Text;
			string cedula = txtCedula.Text;
			string ruc = txtRuc.Text;
			*/// Agregar lógica para obtener otros datos actualizados del cliente...

			// Actualizar el cliente en la base de datos
			// Aquí debes escribir el código para ejecutar la actualización en la base de datos Oracle
			// Ejemplo:
			// string query = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, direccion = @direccion WHERE id = @idCliente";
			// SqlCommand cmd = new SqlCommand(query, connection);
			// cmd.Parameters.AddWithValue("@nombre", nombre);
			// cmd.Parameters.AddWithValue("@apellido", apellido);
			// cmd.Parameters.AddWithValue("@direccion", direccion);
			// cmd.Parameters.AddWithValue("@idCliente", idCliente);
			// connection.Open();
			// cmd.ExecuteNonQuery();
			// connection.Close();
		}

		private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}
		private DataTable ObtenerClientes()
		{
			DataTable dataTable = new DataTable();

			// Crear la estructura de la tabla de clientes
			dataTable.Columns.Add("Id", typeof(int));
			dataTable.Columns.Add("Nombre", typeof(string));
			dataTable.Columns.Add("Apellido", typeof(string));
			dataTable.Columns.Add("Direccion", typeof(string));
			dataTable.Columns.Add("Cedula", typeof(string)); // Agrega columna para cédula
			dataTable.Columns.Add("RUC", typeof(string)); // Agrega columna para RUC
														  // Agrega otras columnas según sea necesario

			// Agregar datos de clientes en duro
			dataTable.Rows.Add(1, "Juan", "Pérez", "Av. Principal 123", "12345678", "12345678912");
			dataTable.Rows.Add(2, "María", "González", "Calle Secundaria 456", "23456789", "98765432101");
			dataTable.Rows.Add(3, "Pedro", "Díaz", "Av. Independencia 789", "34567890", "34567890123");
			// Agrega más filas según sea necesario

			return dataTable;
		}
		private int ObtenerIdClienteSeleccionado()
		{
			int idCliente = -1; // Valor predeterminado en caso de no seleccionar ningún cliente

			// Verificar si se ha seleccionado una fila en el DataGridView
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Obtener el valor del ID del cliente de la primera fila seleccionada
				DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
				idCliente = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value); // Suponiendo que la columna del ID se llama "Id"
			}

			return idCliente;
		}


		private void button3_Click(object sender, EventArgs e)
		{
			// Agregar lógica para obtener el ID del cliente a eliminar, por ejemplo:
			int idCliente = ObtenerIdClienteSeleccionado(); // Implementa este método para obtener el ID del cliente seleccionado en la interfaz

			// Eliminar el cliente de la base de datos
			// Aquí debes escribir el código para ejecutar la eliminación en la base de datos Oracle
			// Ejemplo:
			// string query = "DELETE FROM clientes WHERE id = @idCliente";
			// SqlCommand cmd = new SqlCommand(query, connection);
			// cmd.Parameters.AddWithValue("@idCliente", idCliente);
			// connection.Open();
			// cmd.ExecuteNonQuery();
			// connection.Close();
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			CargarClientesEnDataGridView();
		}

		private void CargarClientesEnDataGridView()
		{
			DataTable clientesDataTable = ObtenerClientes();
			dataGridView1.DataSource = clientesDataTable;
		}

		private void button1_Click(object sender, EventArgs e)
		{

			AgregarCliente agregarClienteForm = new AgregarCliente();

			// Mostrar el formulario de agregar cliente
			agregarClienteForm.ShowDialog(); // Ut
											 // Obtener los valores de los TextBoxes
			/*	string nombre = txtNombre.Text;
				string apellido = txtApellido.Text;
				string direccion = txtDireccion.Text;
				string cedula = txtCedula.Text;
				string ruc = txtRuc.Text;
				*/
			// Agregar lógica para obtener otros datos del cliente...

			// Insertar el nuevo cliente en la base de datos
			// Aquí debes escribir el código para ejecutar la inserción en la base de datos Oracle
			// Ejemplo:
			// string query = "INSERT INTO clientes (nombre, apellido, direccion) VALUES (@nombre, @apellido, @direccion)";
			// Luego, ejecutas el comando con los parámetros correspondientes
			// SqlCommand cmd = new SqlCommand(query, connection);
			// cmd.Parameters.AddWithValue("@nombre", nombre);
			// cmd.Parameters.AddWithValue("@apellido", apellido);
			// cmd.Parameters.AddWithValue("@direccion", direccion);
			// connection.Open();
			// cmd.ExecuteNonQuery();
			// connection.Close();
		}
		List<Cliente> clientes = new List<Cliente>();
		public class Cliente
		{
			public int Id { get; set; }
			public string Nombre { get; set; }
			public string Apellido { get; set; }
			public string Direccion { get; set; }
			public string Cedula { get; set; }
			public string RUC { get; set; }
		}

		private void Form2_Load_1(object sender, EventArgs e)
		{

			// Agregar los datos directamente a la grilla
			clientes.Add(new Cliente { Id = 1, Nombre = "Juan", Apellido = "Pérez", Direccion = "Av. Principal 123", Cedula = "12345678", RUC = "12345678912" });
			clientes.Add(new Cliente { Id = 2, Nombre = "María", Apellido = "González", Direccion = "Calle Secundaria 456", Cedula = "23456789", RUC = "98765432101" });
			clientes.Add(new Cliente { Id = 3, Nombre = "Pedro", Apellido = "Díaz", Direccion = "Av. Independencia 789", Cedula = "34567890", RUC = "34567890123" });
			dataGridView1.DataSource = clientes;

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		/*	private DataTable ObtenerClientes()
			{
				DataTable dataTable = new DataTable();
				string connectionString = "aca debo agregar mi conexion"; // Reemplaza con tu cadena de conexión a Oracle

				using (OracleConnection connection = new OracleConnection(connectionString))
				{
					string query = "SELECT * FROM clientes";
					OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
					adapter.Fill(dataTable);
				}
			}*/
	}
}
