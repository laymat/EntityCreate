using System;

namespace 
{
    [Serializable]
    public class ST_SOILCH_B
    {
        public virtual String STCD { get; set; }
        public virtual String SLTP { get; set; }
        public virtual String SLTX { get; set; }
        public virtual String SFBR { get; set; }
        public virtual Decimal SSPG { get; set; }
        public virtual Decimal DSD { get; set; }
        public virtual Decimal SPOR { get; set; }
        public virtual Decimal SHWC { get; set; }
        public virtual Decimal FDCP { get; set; }
        public virtual Decimal WLCP { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

