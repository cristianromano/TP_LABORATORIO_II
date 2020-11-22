using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class VentasException : Exception
    {
        public VentasException() : base("no se pudo realizar la venta")
        {

        }

        public VentasException(string mensaje) : base(mensaje)
        {

        }
    }
}
