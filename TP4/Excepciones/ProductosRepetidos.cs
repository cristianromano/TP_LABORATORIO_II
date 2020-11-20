using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ProductosRepetidos:Exception
    {
        public ProductosRepetidos():base("el producto ya se encuentra en la base de datos , se cargo el stock")
        {

        }
    }
}
