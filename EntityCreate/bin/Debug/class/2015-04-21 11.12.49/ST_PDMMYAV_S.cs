using System;

namespace 
{
    [Serializable]
    public class ST_PDMMYAV_S
    {
        public virtual String STCD { get; set; }
        public virtual Decimal MNTH { get; set; }
        public virtual Decimal PRDTP { get; set; }
        public virtual Decimal MYMAVP { get; set; }
        public virtual Decimal BGYR { get; set; }
        public virtual Decimal EDYR { get; set; }
        public virtual Decimal STTYRNUM { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

