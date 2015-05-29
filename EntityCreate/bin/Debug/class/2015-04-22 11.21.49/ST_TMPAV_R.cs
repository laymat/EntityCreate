using System;

namespace 
{
    [Serializable]
    public class ST_TMPAV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal AVATMP { get; set; }
        public virtual Decimal AVWTMP { get; set; }
    }
}

