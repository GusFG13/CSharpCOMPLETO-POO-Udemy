using System;

namespace Section11.Aula154.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        { 
        }
    }
}
