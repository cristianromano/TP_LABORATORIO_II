namespace MenuPrincipal
{
    partial class VentaProducto
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
            this.dtgVentaProducto = new System.Windows.Forms.DataGridView();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbMonto = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.lbTicketNumero = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.lbMedioPago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentaProducto
            // 
            this.dtgVentaProducto.AllowUserToAddRows = false;
            this.dtgVentaProducto.AllowUserToDeleteRows = false;
            this.dtgVentaProducto.AllowUserToResizeColumns = false;
            this.dtgVentaProducto.AllowUserToResizeRows = false;
            this.dtgVentaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaProducto.Location = new System.Drawing.Point(34, 23);
            this.dtgVentaProducto.Name = "dtgVentaProducto";
            this.dtgVentaProducto.ReadOnly = true;
            this.dtgVentaProducto.RowHeadersVisible = false;
            this.dtgVentaProducto.Size = new System.Drawing.Size(409, 216);
            this.dtgVentaProducto.TabIndex = 0;
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(343, 254);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.ReadOnly = true;
            this.txtMontoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoFinal.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(101, 298);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(204, 260);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(40, 20);
            this.txtStock.TabIndex = 5;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(45, 263);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(50, 13);
            this.lbProducto.TabIndex = 6;
            this.lbProducto.Text = "Producto";
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Location = new System.Drawing.Point(271, 257);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(62, 13);
            this.lbMonto.TabIndex = 8;
            this.lbMonto.Text = "Monto Final";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(58, 301);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 10;
            this.lbPrecio.Text = "Precio";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(101, 260);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(97, 21);
            this.cmbProductos.TabIndex = 11;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(343, 338);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(101, 338);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(449, 21);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.ReadOnly = true;
            this.txtTicket.Size = new System.Drawing.Size(38, 20);
            this.txtTicket.TabIndex = 14;
            // 
            // lbTicketNumero
            // 
            this.lbTicketNumero.AutoSize = true;
            this.lbTicketNumero.Location = new System.Drawing.Point(422, 5);
            this.lbTicketNumero.Name = "lbTicketNumero";
            this.lbTicketNumero.Size = new System.Drawing.Size(74, 13);
            this.lbTicketNumero.TabIndex = 15;
            this.lbTicketNumero.Text = "TicketNumero";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(346, 301);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(97, 21);
            this.cmbMedioPago.TabIndex = 16;
            // 
            // lbMedioPago
            // 
            this.lbMedioPago.AutoSize = true;
            this.lbMedioPago.Location = new System.Drawing.Point(261, 304);
            this.lbMedioPago.Name = "lbMedioPago";
            this.lbMedioPago.Size = new System.Drawing.Size(79, 13);
            this.lbMedioPago.TabIndex = 17;
            this.lbMedioPago.Text = "Medio de Pago";
            // 
            // VentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 380);
            this.Controls.Add(this.lbMedioPago);
            this.Controls.Add(this.cmbMedioPago);
            this.Controls.Add(this.lbTicketNumero);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtMontoFinal);
            this.Controls.Add(this.dtgVentaProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentaProducto";
            this.Text = "VentaProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentaProducto_FormClosing);
            this.Load += new System.EventHandler(this.VentaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVentaProducto;
        private System.Windows.Forms.TextBox txtMontoFinal;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label lbTicketNumero;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label lbMedioPago;
    }
}