﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException:Exception
    {
        public ArchivosException() : base()
        {

        }
        public ArchivosException(string mensaje) : base(mensaje)
        {

        }
        public ArchivosException(Exception e) : base("error innerException:", e)
        {

        }

        public ArchivosException(string mensaje , Exception e):base(mensaje , e)
        {

        }
    }
}
