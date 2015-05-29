using System;

namespace 
{
    [Serializable]
    public class ST_GATE_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual String EQPTP { get; set; }
        public virtual String EQPNO { get; set; }
        public virtual Decimal GTOPNUM { get; set; }
        public virtual Decimal GTOPHGT { get; set; }
        public virtual Decimal GTQ { get; set; }
        public virtual String MSQMT { get; set; }
    }
}

