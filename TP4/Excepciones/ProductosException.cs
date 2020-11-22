using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ProductosException:Exception
    {
        public ProductosException():base("faltan datos a completar")
        {

        }

        public ProductosException(string mensaje):base(mensaje)
        {

        }
    }
}
