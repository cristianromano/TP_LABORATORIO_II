using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {

        public DniInvalidoException():base("este es un mensaje automatico")
        {

        }

        public DniInvalidoException(Exception e):base("mensaje innerException" , e)
        {

        }

        public DniInvalidoException(string mensaje):base(mensaje)
        {

        }

        public DniInvalidoException(Exception e , string mensaje):base(mensaje , e)
        {

        }


    }
}
