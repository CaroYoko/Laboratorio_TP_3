using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoInvalidoException : Exception
    {
        public TipoInvalidoException(string mensaje) : base (mensaje)
        {
            
        }
    }
}
