using ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        static Random random;
        Queue<Universidad.EClases> claseDelDia;

        #region Constructores

        static Profesor()
        {
            random = new Random();
        }
        public Profesor() : base()
        {

        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseDelDia = new Queue<Universidad.EClases>();
            _randomClase();

        }
        #endregion

        #region Metodos

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(ParticiparEnClase());

            return sb.ToString();

        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASE DEL DIA:");
            foreach (Universidad.EClases item in claseDelDia)
            {
                sb.AppendLine($"{item.ToString()}");
            }

            return sb.ToString(); ;
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public void _randomClase()
        {
            for (int i = 0; i < 2; i++)
            {
                int opcion = random.Next(0, 3);

                switch (opcion)
                {
                    case 0:
                        this.claseDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;
                    case 1:
                        this.claseDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                    case 2:
                        this.claseDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;
                    case 3:
                        this.claseDelDia.Enqueue(Universidad.EClases.SPD);
                        break;
                }
            }
        }
        #endregion

        #region Propiedades

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in i.claseDelDia )
            {
                if(item == clase)
                {
                    return true;
                }

            }

            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }


        #endregion

    }
}
