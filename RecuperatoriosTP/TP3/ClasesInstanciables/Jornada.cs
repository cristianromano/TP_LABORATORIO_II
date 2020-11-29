using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using ClaseAbstracta;

namespace ClasesInstanciables
{
    public class Jornada
    {

        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;

        #region Constructor
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase , Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }

            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }

            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Operadores

        /// <summary>
        /// verifica si un alumno participa en la clase de una jornada.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno item in j.alumnos)
            {
                if(item == a)
                {
                    return true;
                }            
            }

            return false;
        }

        /// <summary>
        /// verifica si un alumno no participa en la clase de una jornada.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// agrega un alumno a una jornada en caso de que no este participando en ella
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }
        #endregion

        #region Metodos 

        /// <summary>
        /// Guarda los datos de una jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Jornada");
            Texto auxTexto = new Texto();

            return auxTexto.Guardar(path, jornada.ToString());
        }

        /// <summary>
        /// Lee los datos de una jornada de un archivo de texto.
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            string datos;
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Jornada");
            Texto auxTexto = new Texto();

            auxTexto.Leer(path, out datos);

            return datos;
        }

        /// <summary>
        /// muestra los datos de una jornada.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<--------------------------------------------------------------------->");
            sb.AppendLine($"CLASE DE {this.clase.ToString()} DOCENTE {this.instructor.ToString()}");
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno item in alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        #endregion
    }
}
