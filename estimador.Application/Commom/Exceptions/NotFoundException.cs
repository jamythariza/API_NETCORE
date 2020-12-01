using System;

namespace estimador.Application.Commom.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) 
            : base($"Entity \"{name}\" ({key}) was not found.")
        {           

        }
    }
}
