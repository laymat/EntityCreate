using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_EUNTLANG_D
    {
        public virtual String FLID { get; set; }
        public virtual String EUCD { get; set; }
        public virtual String NTLANG { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

