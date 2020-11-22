using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace MenuPrincipal
{
    public delegate void AgregarProductosRandom(Producto p);
    public partial class AgregarProducto : Form
    {
        public event AgregarProductosRandom Agregar;
        Producto producto;
        static Queue<Producto> ListaRandom = new Queue<Producto>();
        static float acumulador = 0;
        public AgregarProducto()
        {
            InitializeComponent();
        }

        public Producto Producto { get => producto; set => producto = value; }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            RefrescarDataGrid();
            this.btnEliminar.Enabled = false;
        }

        /// <summary>
        /// agrego un producto a la lista estatica comercio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                float precio = float.Parse(this.txtPrecio.Text);
                int stock = int.Parse(this.txtStock.Text);

                if (string.IsNullOrWhiteSpace(this.txtNombre.Text) == false && string.IsNullOrWhiteSpace(this.txtCodigo.Text) == false)
                {
                    producto = new Producto(this.txtNombre.Text, precio, stock, this.txtCodigo.Text);
                    if (Comercio.Productos + producto)
                    {
                        MessageBox.Show("agregado a la base de datos");
                    }

                    this.DialogResult = DialogResult.OK;
                }

                else
                {
                    throw new ProductosException("faltan datos");
                }
            }
            catch (ExcepcionesGenericas ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// elimino un producto seleccionado de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtNombre.Text) == false && string.IsNullOrWhiteSpace(this.txtCodigo.Text) == false)
                {
                    float precio = float.Parse(this.txtPrecio.Text);
                    int stock = int.Parse(this.txtStock.Text);
                    int id = int.Parse(this.txtID.Text);
                    producto = new Producto(this.txtNombre.Text, precio, stock, this.txtCodigo.Text, id);

                    if (Comercio.Productos - producto)
                    {
                        MessageBox.Show("producto eliminado de la base de datos");
                        this.DialogResult = DialogResult.OK;
                    }

                    else
                    {
                        MessageBox.Show($"no existe el producto: {this.txtNombre.Text} en la base de datos");
                    }
                }

                else
                {
                    throw new ProductosException("faltan datos");
                }
            }
            catch (ExcepcionesGenericas ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigo.Text = dtgProductos.CurrentRow.Cells[4].Value.ToString();
            this.txtCodigo.Enabled = false;
            this.txtNombre.Text = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            this.txtNombre.Enabled = false;
            this.txtPrecio.Text = dtgProductos.CurrentRow.Cells[2].Value.ToString();
            this.txtPrecio.Enabled = false;
            this.txtID.Text = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            this.txtID.Enabled = false;
            this.txtStock.Text = dtgProductos.CurrentRow.Cells[3].Value.ToString();
            this.txtStock.Enabled = false;
            this.btnEliminar.Enabled = true;
            this.btnAgregar.Enabled = false;
        }
        private void RefrescarDataGrid()
        {
            dtgProductos.DataSource = Comercio.Productos;
            dtgProductos.DataSource = null;
            dtgProductos.DataSource = Comercio.Productos;

            dtgProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;

            foreach (DataGridViewRow item in dtgProductos.Rows)
            {
                if (item.Cells["Stock"].Value.ToString() == "0")
                {
                    item.DefaultCellStyle.BackColor = Color.Coral;
                }
            }
        }

        /// <summary>
        /// agrego a travez de un hilo stock a los productos de manera aleatoria
        /// </summary>
        public void AgregarRandomProductosStock()
        {
            if (!(Agregar is null))
            {
                int cantidadProductos = 0;
                Random random = new Random();
                Random item = new Random();
                Random randomStock = new Random();
                int productoIndex = 0;
                List<Producto> auxProductos = new List<Producto>();
                

                auxProductos = Comercio.Productos;
                cantidadProductos = auxProductos.Count;
                int pos = random.Next(1, cantidadProductos);

                for (int i = 0; i < pos; i++)
                {
                    productoIndex = item.Next(0, cantidadProductos);

                    auxProductos[productoIndex].Stock = random.Next(5, 100);

                    if (Comercio.Productos + auxProductos[productoIndex])
                    {
                        acumulador += auxProductos[productoIndex].Precio;
                        ListaRandom.Enqueue(auxProductos[productoIndex]);
                    }

                    Thread.Sleep(3000);
                    Agregar.Invoke(ListaRandom.Dequeue());
                }
            }

            Venta reposicionStock = new Venta(acumulador, Principal.Aux);

            if (Venta.GuardarTextoStock(reposicionStock))
            {
                Thread.Sleep(2000);
                MessageBox.Show("stock repuesto con exito , ticket de precio a pagar generado", "SISTEMA DE VENTA ONLINE");
            }

        }

    }
}
