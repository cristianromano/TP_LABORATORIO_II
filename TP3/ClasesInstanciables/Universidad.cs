using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using ClaseAbstracta;
using Archivos;

namespace ClasesInstanciables
{

    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;

        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }

            set { this.alumnos = value; }
        }
        public List<Jornada> Jornada
        {
            get { return this.jornada; }

            set { this.jornada = value; }
        }

        public List<Profesor> Profesores
        {
            get { return this.profesores; }

            set { this.profesores = value; }
        }

        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    return this.jornada[i];
                }
                else
                {
                    throw new ArchivosException("Indice invalido");
                }
            }

            set
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    this.jornada[i] = value;
                }
                else
                {
                    throw new ArchivosException("Indice invalido");
                }
            }
        }

        #endregion

        #region Operadores

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno item in g.alumnos)
            {
                if(item == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (var item in g.jornada)
            {
                if (item.Instructor == i)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.profesores)
            {
                if (item == clase)
                {
                    return item;
                }
            }

            throw new SinProfesorException("No hay profesor disponible para la clase requerida");
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.Profesores)
            {
                if (item != clase)
                {
                    return item;
                }
            }

            throw new SinProfesorException();
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);

            }
            else
            {
                throw new AlumnoRepetidoException("El alumno que intenta cargar, ya fue agregado a la lista previamente");
            }

            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {

                u.profesores.Add(i);
            }

            return u;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada auxJornada = new Jornada(clase, (g == clase));

            foreach (Alumno item in g.alumnos)
            {
                if (item == clase)
                {
                    auxJornada.Alumnos.Add(item);
                }
            }

            g.jornada.Add(auxJornada);

            return g;
        }

        #endregion

        #region Metodos

        public static bool Guardar(Universidad uni)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "universidad.xml");
            Xml<Universidad> auxUni = new Xml<Universidad>();

            return auxUni.Guardar(path, uni);
        }

        public static Universidad Leer()
        {
            Universidad datos = new Universidad();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "universidad.xml");
            Xml<Universidad> auxUni = new Xml<Universidad>();

            auxUni.Leer(path, out datos);

            return datos;

        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in uni.jornada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

        #endregion

    }
}
