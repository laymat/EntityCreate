using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_RSVRAV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal AVRZ { get; set; }
        public virtual Decimal AVINQ { get; set; }
        public virtual Decimal AVOTQ { get; set; }
        public virtual Decimal AVW { get; set; }
    }
}

