using System;
using System.Runtime.Serialization;

namespace Entidades
{
    
    public class NoExisteException : Exception
    {    

        public NoExisteException(string message) : base(message)
        {
        }

    }
}