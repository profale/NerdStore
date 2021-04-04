using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.DomainObjects
{
    //classe de dominio de excecao personalizada
    public class DomainException : Exception
    {
        public DomainException()
        {
                
        }

        public DomainException(string message) : base (message)
        {
                
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
