using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_GATE_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual String EQPTP { get; set; }
        public virtual String FEQPNO { get; set; }
        public virtual String FOPGTNUM { get; set; }
        public virtual Double FOPHGT { get; set; }
        public virtual Double FGTQ { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
    }
}

