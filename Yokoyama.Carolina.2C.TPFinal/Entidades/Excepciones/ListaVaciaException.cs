using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    public class ListaVaciaException : Exception
    {     
        public ListaVaciaException(string message) : base(message)
        {
        }
       
    }
}