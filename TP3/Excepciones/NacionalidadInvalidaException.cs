using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {

        public NacionalidadInvalidaException():base("mensaje automatico")
        {

        }

        public NacionalidadInvalidaException(Exception e):base("mensaje innerException" , e)
        {

        }

        public NacionalidadInvalidaException(string mensaje):base(mensaje)
        {

        }

        public NacionalidadInvalidaException(Exception e , string mensaje):base(mensaje , e)
        {

        }


    }
}
