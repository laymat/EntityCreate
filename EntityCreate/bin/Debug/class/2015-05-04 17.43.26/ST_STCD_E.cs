using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_STCD_E
    {
        public virtual String INSTCD { get; set; }
        public virtual String STCD { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

