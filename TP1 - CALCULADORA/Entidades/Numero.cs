using System;

namespace Entidades
{
    public class Numero
    {

        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public string SetNumero
        {

            set { this.numero = validarNumero(value); }
        }




        public static double validarNumero(string numero)
        {
            double auxNumero;

            if (double.TryParse(numero, out auxNumero))
            {
                return auxNumero;
            }

            else
            {
                return 0;
            }

        }


        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if(num2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return num1.numero / num2.numero;
            }
            
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }


        private static bool esBinario(string binario)
        {
            bool retorno = true;

            char[] array = binario.ToCharArray();


            for (int i = 0; i < array.Length ; i++)
            {
                if (array[i] != '1' && array[i] != '0')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }


        public static string BinarioADecimal(string binario)
        {
            string resultado = "no es valido";
            char[] array = binario.ToCharArray();
           
            Array.Reverse(array);
            int sum = 0;

            if(esBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        
                        sum += (int)Math.Pow(2, i);
                    }
                }

                resultado = sum.ToString();
            }      
            return resultado;
        }


        public static string DecimalBinario(double numero)
        {

            int valor = Convert.ToInt32(Math.Abs(numero));
            
            string binario = "";
            string valorinvalido = "Valor Invalido";

            while (true)
            {
                if(  (valor%2)!=0 )
                {
                    binario = "1" + binario;
                }
                else
                {
                    binario = "0" + binario;
                }

                valor /= 2;

                if(valor <=0)
                {
                    return binario;
                    break;
                }

            }

            return valorinvalido;

        }

        public static string DecimalBinario(string numero)
        {
            double numeroAux;
            string retornoAux = "opcion invalida";

            if(double.TryParse(numero , out numeroAux))
            {
                retornoAux = DecimalBinario(numeroAux);
            }
           

            return retornoAux;
        }

    }
}
