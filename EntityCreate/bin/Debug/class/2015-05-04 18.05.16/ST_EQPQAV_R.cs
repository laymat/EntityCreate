using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_EQPQAV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual String EQPTP { get; set; }
        public virtual String EQPNO { get; set; }
        public virtual Double AVGTQ { get; set; }
    }
}

