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
using static PruebaCLT.Form1;

namespace PruebaCLT
{
	public partial class Form1 : Form
	{

		private List<Producto> productos = new List<Producto>();

		public Form1()
		{
			InitializeComponent();
		}
		/*
		private void Form1_Load(object sender, EventArgs e)
		{
			CargarProductosDesdeBaseDeDatos();

		}*/
		private void Form1_Load(object sender, EventArgs e)
		{
			// Inicializar la lista de productos con algunos datos de ejemplo
			productos.Add(new Producto { Id = 1, Nombre = "Producto 1", Precio = 1000, Codigo = "100" });
			productos.Add(new Producto { Id = 2, Nombre = "Producto 2", Precio = 1500, Codigo = "50" });

			// Mostrar los productos en el DataGridView
			dataGridView1.DataSource = productos;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			// Abrir el formulario para agregar un nuevo producto
			AgregarProductoForm agregarProductoForm = new AgregarProductoForm(this);
			agregarProductoForm.ShowDialog();
		}

		public void AgregarProducto(Producto producto)
		{
			// Agregar el producto a la lista de productos
			productos.Add(producto);

			// Actualizar el DataGridView
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = productos;
		}
		public class Producto
		{
			public int Id { get; set; }
			public string Nombre { get; set; }
			public string Codigo { get; set; }
			public decimal Precio { get; set; }
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}


		private void button3_Click(object sender, EventArgs e)
		{
			// Verificar si se ha seleccionado un producto en el DataGridView
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Obtener el producto seleccionado
				Producto productoSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Producto;

				// Mostrar un cuadro de diálogo de confirmación para confirmar la eliminación
				DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar el producto \"{productoSeleccionado.Nombre}\"?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				// Si el usuario confirma la eliminación, eliminar el producto seleccionado
				if (resultado == DialogResult.Yes)
				{
					// Eliminar el producto de la lista de productos
					productos.Remove(productoSeleccionado); // Suponiendo que "productos" es tu lista de productos en el formulario principal

					// Actualizar el DataGridView
					dataGridView1.DataSource = null;
					dataGridView1.DataSource = productos; // Vuelve a enlazar la lista de productos al DataGridView
				}
			}
			else
			{
				// Mostrar un mensaje al usuario indicando que debe seleccionar un producto para eliminar
				MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			// Obtener el producto seleccionado de la grilla (si es necesario)
			Producto ProductoActual = ObtenerProductoSeleccionado();

			// Crear una instancia del formulario de edición de productos y mostrarlo

			// Suponiendo que ProductoActual es el producto que se va a editar
			EditarProductoForm editarProductoForm = new EditarProductoForm(ProductoActual);
			editarProductoForm.ShowDialog();

			// Realizar alguna acción adicional si es necesario, como actualizar la lista de productos en la grilla
			if (editarProductoForm.CambiosGuardados)
			{
				// Actualizar el DataGridView
				dataGridView1.DataSource = null;
				dataGridView1.DataSource = productos; // Vuelve a enlazar la lista de productos al DataGridView
													  // Aquí puedes actualizar la lista de productos en la grilla si es necesario
			}
		}
/*

		private void CargarProductosDesdeBaseDeDatos()
		{
			using (OracleConnection connection = new OracleConnection(connectionString))
			{
				try
				{
					connection.Open();

					string sqlQuery = "SELECT id, nombre, codigo, precio FROM productos";
					OracleCommand command = new OracleCommand(sqlQuery, connection);
					OracleDataAdapter adapter = new OracleDataAdapter(command);

					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					foreach (DataRow row in dataTable.Rows)
					{
						int id = Convert.ToInt32(row["id"]);
						string nombre = row["nombre"].ToString();
						string codigo = row["codigo"].ToString();
						decimal precio = Convert.ToDecimal(row["precio"]);

						Producto producto = new Producto { Id = id, Nombre = nombre, Codigo = codigo, Precio = precio };
						productos.Add(producto);
					}

					// Mostrar los productos en el DataGridView
					dataGridView1.DataSource = productos;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar los productos desde la base de datos: " + ex.Message);
				}
			}
		}
	*/
	private Producto ObtenerProductoSeleccionado()
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Obtener el producto seleccionado
				Producto productoSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Producto;
				return productoSeleccionado;
			}
			else
			{
				// Si no hay ningún producto seleccionado, devolver null
				return null;
			}
		}

	}

}
