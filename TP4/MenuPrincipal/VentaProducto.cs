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
    public partial class VentaProducto : Form
    {

        List<Producto> ListaProductos;
        List<Producto> ListaRandom;
        Thread thread;
        Producto MiProducto;
        public float acumulador = 0;
        public static int acum = 0;

        public List<Producto> RandomLista { get => ListaRandom; }
        public List<Producto> ProductoLista { get => ListaProductos; set => ListaProductos = value; }

        public VentaProducto()
        {
            InitializeComponent();
        }

        private void VentaProducto_Load(object sender, EventArgs e)
        {
            ListaProductos = new List<Producto>();
            ListaRandom = new List<Producto>();
            ListaProductos = Comercio.Productos;
            thread = new Thread(AgregarVentaOffline);
            thread.Start();

            this.cmbProductos.DataSource = Comercio.Productos;
            this.cmbProductos.DisplayMember = "nombre";
            this.txtTicket.Text = Interlocked.Increment(ref acum).ToString();
            this.cmbMedioPago.DataSource = Enum.GetValues(typeof(EMedioPago));

            ListaProductos.Clear();
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto MiProducto = (Producto)this.cmbProductos.SelectedItem;

            this.txtStock.Text = MiProducto.Stock.ToString();

            this.txtPrecio.Text = MiProducto.Precio.ToString();
        }

        /// <summary>
        /// agrego una nueva venta a la lista ListaProductos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                MiProducto = (Producto)this.cmbProductos.SelectedItem;

                if (MiProducto.Stock == 0)
                {
                    throw new VentasException("no hay stock");
                }
                else
                {

                    MiProducto.Stock--;

                    this.txtStock.Text = MiProducto.Stock.ToString();

                    ListaProductos.Add(MiProducto);

                    acumulador += MiProducto.Precio;

                    this.txtMontoFinal.Text = acumulador.ToString();

                    RefrescarDataGridVenta();

                    dtgVentaProducto.Columns.Remove("Id");
                    dtgVentaProducto.Columns.Remove("Stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA STOCK");
            }
        }

        private void RefrescarDataGridVenta()
        {
            this.dtgVentaProducto.DataSource = ListaProductos;
            this.dtgVentaProducto.DataSource = null;
            this.dtgVentaProducto.DataSource = ListaProductos;
        }

        /// <summary>
        /// genero una venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtMontoFinal.Text) == false)
                {
                    float monto = float.Parse(this.txtMontoFinal.Text);
                    Venta miVenta = new Venta(monto, ListaProductos, (EMedioPago)this.cmbMedioPago.SelectedItem);

                    if (Comercio.Ventas + miVenta && Producto.ModificarLista(ListaProductos))
                    {

                        if (Venta.GuardarTexto(miVenta))
                        {
                            MessageBox.Show("venta exitosa , ticket generado con exito", "SISTEMA DE VENTA");
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }

                else
                {
                    throw new VentasException("falta completar la venta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// mientras voy realizando una venta , el sistema me informa que de manera ONLINE genera ya una venta y me la guarda en un texto
        /// </summary>
        public void AgregarVentaOffline()
        {
            int cantidadProductos = 0;
            Random random = new Random();
            Random item = new Random();
            float acumulador = 0;
            int productoIndex = 0;
            List<Producto> auxProductos = new List<Producto>();

            auxProductos = ListaProductos;
            cantidadProductos = auxProductos.Count;
            int pos = random.Next(1, cantidadProductos);

            for (int i = 0; i < pos; i++)
            {
                productoIndex = item.Next(0, cantidadProductos);

                if (auxProductos[productoIndex].Stock > 0)
                {
                    ListaRandom.Add(auxProductos[productoIndex]);
                    acumulador += auxProductos[productoIndex].Precio;

                    auxProductos[productoIndex].Stock--;
                    auxProductos[productoIndex].Modificar();
                }

            }
            Venta ventaOffline = new Venta(acumulador, ListaRandom);

            if (Venta.GuardarTextoOnline(ventaOffline))
            {
                Thread.Sleep(7000);
                MessageBox.Show("venta realizada y ticket generado de manera ONLINE", "SISTEMA DE VENTA ONLINE");
            }
        }

        private void VentaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(thread is null) && thread.IsAlive)
            {
                thread.Abort();
            }
            this.DialogResult = DialogResult.OK;
        }

    }
}
