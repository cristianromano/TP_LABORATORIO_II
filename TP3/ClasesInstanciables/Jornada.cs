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

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

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

        public static bool Guardar(Jornada jornada)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Jornada");
            Texto auxTexto = new Texto();

            return auxTexto.Guardar(path, jornada.ToString());
        }

        public static string Leer()
        {
            string datos;
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Jornada");
            Texto auxTexto = new Texto();

            auxTexto.Leer(path, out datos);

            return datos;
        }

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
