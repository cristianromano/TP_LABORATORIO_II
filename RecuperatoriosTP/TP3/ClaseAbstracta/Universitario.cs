using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public abstract class Universitario:Persona
    {
        int legajo;

        #region Constructores
        public Universitario()
        {

        }

        public Universitario(int legajo , string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Metodos
        protected abstract string ParticiparEnClase();
        /// <summary>
        /// muestra los datos de una persona y a su vez se le agrega el legajo
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Legajo: {this.legajo}");

            return sb.ToString();
        }

        /// <summary>
        /// compara el tipo de dato de dos objetos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this.GetType(), obj.GetType()))
            {
                return true;
            }

            return false;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// devuelve verdadero si el objeto pasado por parametro conciden y tienen mismo dni o legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if(pg1.Equals(pg2) && pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// devuelve verdadero si el objeto pasado por parametro no conciden y no tienen mismo dni o legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion

    }
}
