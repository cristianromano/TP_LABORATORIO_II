using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv:Vehiculo
    {


        public Suv(string chasis, EMarca marca, ConsoleColor color):base(chasis, marca, color )
        {
  

        }
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
       public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }

           
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {ETamanio.Grande}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
