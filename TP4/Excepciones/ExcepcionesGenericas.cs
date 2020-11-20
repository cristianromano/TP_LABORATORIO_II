using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionesGenericas:Exception
    {

        public ExcepcionesGenericas():base("generico")
        {

        }
        public ExcepcionesGenericas(string mensaje):base(mensaje)
        {

        }
    }
}
