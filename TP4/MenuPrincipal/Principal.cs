using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Threading;

namespace MenuPrincipal
{
    public partial class Principal : Form
    {
        AgregarProducto agregarForm = new AgregarProducto();
        Thread hilo;
        static List<Producto> aux = new List<Producto>();
        
        public static List<Producto> Aux { get => aux; set => aux = value; }

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarDataGrid();
            agregarForm.Agregar += apretoEvento;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto OpcionProductos = new AgregarProducto();

            if (OpcionProductos.ShowDialog() == DialogResult.OK)
            {
                RefrescarDataGrid();
            }
        }

        private void RefrescarDataGrid()
        {
            dataGridView1.DataSource = Comercio.Productos;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Comercio.Productos;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["Stock"].Value.ToString() == "0")
                {
                    item.DefaultCellStyle.BackColor = Color.Coral;
                }
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            VentaProducto venta = new VentaProducto();

            if (venta.ShowDialog() == DialogResult.OK)
            {
                RefrescarDataGrid();
            }
        }

        /// <summary>
        /// inicio el hilo para realizar el stockeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            aux.Clear();
            hilo = new Thread(agregarForm.AgregarRandomProductosStock);
            hilo.Start();
        }

        /// <summary>
        /// creo evento para poder ir mostrando de a uno los productos que estan siendo stockeados y su cantidad
        /// </summary>
        /// <param name="p"></param>
        public void apretoEvento(Producto p)
        {
            if (this.InvokeRequired)
            {
                AgregarProductosRandom del = new AgregarProductosRandom(apretoEvento);
                this.Invoke(del, new object[] { p });
            }
            else
            {
                aux.Add(p);
                dtgStocks.DataSource = aux;
                dtgStocks.DataSource = null;
                dtgStocks.DataSource = aux;

                RefrescarDataGrid();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(hilo is null) && hilo.IsAlive)
            {
                hilo.Abort();
            }
            Comercio.GuardarXml(Comercio.Productos);
            this.DialogResult = DialogResult.OK;
        }
    }
}
