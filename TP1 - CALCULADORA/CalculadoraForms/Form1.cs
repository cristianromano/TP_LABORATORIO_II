using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperadores.Text = null;
            this.lbResultado.Text = "";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperadores.SelectedItem == null)
            {
                this.cmbOperadores.SelectedItem = "+";
            }
            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperadores.SelectedItem.ToString());

            this.lbResultado.Text = resultado.ToString();

        }


        private static double Operar(string num1 , string num2 , string operador)
        {

            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);

            double resultado = Calculadora.Operar(numero1, numero2, operador);

            return resultado;
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
           // Numero numeroB = new Numero();

            string resultado = Numero.DecimalBinario(this.lbResultado.Text);

            this.lbResultado.Text = resultado;

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
           // Numero numeroB = new Numero();

            string resultado = Numero.BinarioADecimal(this.lbResultado.Text);

            this.lbResultado.Text = resultado;
        }
    }
}
