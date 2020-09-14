using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        private static string validarOperador(char operador)
        {
            string retorno;

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return retorno = operador.ToString();
            }
            else
            {
                return retorno = "+";
            }

        }


        public static double Operar(Numero numero1, Numero numero2, string operador)
        {

            double resultado = 0;


            char operadorAux = Convert.ToChar(operador);

            string opciones = validarOperador(operadorAux);


                switch (opciones)
            {
                case "+":

                    resultado = numero1 + numero2; 

                    break;

                case "-":

                    resultado = numero1 - numero2;

                    break;


                case "/":

                    resultado = numero1 / numero2;

                    break;


                case "*":

                    resultado = numero1 * numero2;

                    break;

            }

            return resultado;
        }





    }
}
