using System;

namespace 
{
    [Serializable]
    public class ST_GRWAV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal AVGWBD { get; set; }
        public virtual Decimal AVSPQ { get; set; }
        public virtual Decimal AVGWTMP { get; set; }
    }
}

