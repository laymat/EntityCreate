using System;

namespace 
{
    [Serializable]
    public class ST_WASAV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal AVUPZ { get; set; }
        public virtual Decimal AVDWZ { get; set; }
        public virtual Decimal AVGTQ { get; set; }
    }
}

