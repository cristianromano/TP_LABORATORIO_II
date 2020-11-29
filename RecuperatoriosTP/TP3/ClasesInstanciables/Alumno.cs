using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using ClaseAbstracta;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;

        #region Constructores
        public Alumno() : base()
        {

        }

        public Alumno(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(legajo, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(legajo, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Propiedades
        public Universidad.EClases ClaseQueToma
        {
            get
            {
                return this.claseQueToma;                
            }

            set
            {
                this.claseQueToma = value;
            }
        }

        public EEstadoCuenta EstadoCuenta
        {
            get
            {
                return this.estadoCuenta;
            }

            set
            {
                this.estadoCuenta = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// realiza un override y suma datos a mostrar al objeto alumno.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(ParticiparEnClase());
            sb.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta}");

            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE: {this.claseQueToma}";
        }

        /// <summary>
        /// a travez de este metodo se muestran los datos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// verifica si el alumno toma la clase y no es deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// verifica si el alumno no toma la clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if(a.claseQueToma != clase)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
