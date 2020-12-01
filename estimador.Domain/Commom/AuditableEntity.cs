using System;

namespace estimador.Domain.Commom
{
    public abstract class AuditableEntity
    {
        public string UserName { get; set; }
        public DateTime dtFecha { get; set; }
        public string strModulo { get; set; }
    }
}


