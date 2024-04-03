namespace PruebaCLT
{
	partial class AgregarProductoForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textCodigo = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textPrecio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Guardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textCodigo
			// 
			this.textCodigo.Location = new System.Drawing.Point(105, 66);
			this.textCodigo.Name = "textCodigo";
			this.textCodigo.Size = new System.Drawing.Size(100, 20);
			this.textCodigo.TabIndex = 0;
			this.textCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(105, 106);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(100, 20);
			this.textName.TabIndex = 1;
			this.textName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textPrecio
			// 
			this.textPrecio.Location = new System.Drawing.Point(105, 143);
			this.textPrecio.Name = "textPrecio";
			this.textPrecio.Size = new System.Drawing.Size(100, 20);
			this.textPrecio.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(282, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Codigo";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Precio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nombre";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(69, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Agregar Producto";
			// 
			// Guardar
			// 
			this.Guardar.Location = new System.Drawing.Point(105, 184);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(75, 23);
			this.Guardar.TabIndex = 8;
			this.Guardar.Text = "Guardar";
			this.Guardar.UseVisualStyleBackColor = true;
			this.Guardar.Click += new System.EventHandler(this.button1_Click);
			// 
			// AgregarProductoForm
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.Guardar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textPrecio);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.textCodigo);
			this.Name = "AgregarProductoForm";
			this.Load += new System.EventHandler(this.AgregarProductoForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textCodigo;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textPrecio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Guardar;
	}
}