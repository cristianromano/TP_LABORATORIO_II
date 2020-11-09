using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace ClaseAbstracta
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        string nombre;
        string apellido;
        ENacionalidad nacionalidad;
        int dni;


        #region Constructores

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni , ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, string dni , ENacionalidad nacionalidad):this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }


        #endregion


        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }

            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        public string Apellido
        {
            get { return this.apellido; }

            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }

            set
            {
                this.nacionalidad = value;
            }
        }

        public int Dni
        {
            get { return this.dni; }

            set
            {
                this.dni = ValidarDni(Nacionalidad , value);
            }
        }

        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        #endregion


        #region Metodos

        public int ValidarDni(ENacionalidad nacionalidad, int dato)
        {

            try
            {
                if (dato >= 1 && dato <= 99999999)
                {
                    if (nacionalidad.Equals(ENacionalidad.Argentino) && dato >= 1 && dato <= 89999999)
                    {
                        return dato;
                    }

                    else if (nacionalidad.Equals(ENacionalidad.Extranjero) && dato >= 90000000 && dato <= 99999999)
                    {
                        return dato;
                    }
                    else
                    {
                        throw new NacionalidadInvalidaException("el DNI ingresado no pertenece a ninguna nacionalidad enumerada");
                    }
                }

                else
                {
                    throw new DniInvalidoException("el dni pasado por parametro no corresponde a Argentino o Extranjero");
                }

            }
            catch (NacionalidadInvalidaException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DniInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int valor = 0;
            int auxParametro;

            try
            {
                if (int.TryParse(dato, out auxParametro))
                {
                    valor = ValidarDni(nacionalidad, auxParametro);

                    return valor;
                }

                else
                {
                    throw new DniInvalidoException("dni ingresado no corresponde a los parametros requeridos");
                }
            }
            catch (DniInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }

            return valor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El Nombre es: {this.nombre}");
            sb.AppendLine($"El Apellido es: {this.apellido}");
            sb.AppendLine($"El DNI es: {this.dni}");
            sb.AppendLine($"La Nacionalidad es: {this.nacionalidad}");

            return sb.ToString();
        }

        private string ValidarNombreApellido(string dato)
        {
            string pattern = @"\d";

            if (!String.IsNullOrEmpty(dato) && dato.Length > 2)
            {
                Regex auxRegex = new Regex(pattern);

                MatchCollection auxMatch = auxRegex.Matches(dato);

                if (auxMatch.Count == 0)
                {
                    return dato;
                }
            }

            return "Unknown";

        }


        #endregion


    }
}
