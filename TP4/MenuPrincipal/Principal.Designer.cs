namespace MenuPrincipal
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.dtgStocks = new System.Windows.Forms.DataGridView();
            this.lbStockDisponible = new System.Windows.Forms.Label();
            this.lbPedidoStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(316, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(72, 389);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(113, 418);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(140, 23);
            this.btnSerializar.TabIndex = 2;
            this.btnSerializar.Text = "Serializar Productos";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(189, 389);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(111, 23);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(512, 389);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(120, 23);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Solicitar Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // dtgStocks
            // 
            this.dtgStocks.AllowUserToAddRows = false;
            this.dtgStocks.AllowUserToDeleteRows = false;
            this.dtgStocks.AllowUserToResizeColumns = false;
            this.dtgStocks.AllowUserToResizeRows = false;
            this.dtgStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStocks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgStocks.Location = new System.Drawing.Point(421, 32);
            this.dtgStocks.Name = "dtgStocks";
            this.dtgStocks.ReadOnly = true;
            this.dtgStocks.Size = new System.Drawing.Size(316, 342);
            this.dtgStocks.TabIndex = 5;
            // 
            // lbStockDisponible
            // 
            this.lbStockDisponible.AutoSize = true;
            this.lbStockDisponible.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockDisponible.Location = new System.Drawing.Point(99, 4);
            this.lbStockDisponible.Name = "lbStockDisponible";
            this.lbStockDisponible.Size = new System.Drawing.Size(201, 22);
            this.lbStockDisponible.TabIndex = 6;
            this.lbStockDisponible.Text = "STOCK DISPONIBLE";
            // 
            // lbPedidoStock
            // 
            this.lbPedidoStock.AutoSize = true;
            this.lbPedidoStock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidoStock.Location = new System.Drawing.Point(481, 4);
            this.lbPedidoStock.Name = "lbPedidoStock";
            this.lbPedidoStock.Size = new System.Drawing.Size(190, 22);
            this.lbPedidoStock.TabIndex = 7;
            this.lbPedidoStock.Text = "PEDIDO DE STOCK";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPedidoStock);
            this.Controls.Add(this.lbStockDisponible);
            this.Controls.Add(this.dtgStocks);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.DataGridView dtgStocks;
        private System.Windows.Forms.Label lbStockDisponible;
        private System.Windows.Forms.Label lbPedidoStock;
    }
}

