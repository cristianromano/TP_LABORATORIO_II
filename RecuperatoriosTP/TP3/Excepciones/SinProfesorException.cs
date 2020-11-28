using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   public class SinProfesorException:Exception
    {
        public SinProfesorException():base("sin profesor")
        {

        }

        public SinProfesorException(string mensaje):base(mensaje)
        {

        }

        public SinProfesorException(Exception a):base("error:" , a)
        {

        }
    }
}
