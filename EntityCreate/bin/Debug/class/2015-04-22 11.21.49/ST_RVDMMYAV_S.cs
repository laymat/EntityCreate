using System;

namespace 
{
    [Serializable]
    public class ST_RVDMMYAV_S
    {
        public virtual String STCD { get; set; }
        public virtual Decimal MNTH { get; set; }
        public virtual Decimal PRDTP { get; set; }
        public virtual Decimal MYMAVZ { get; set; }
        public virtual Decimal MYMAVQ { get; set; }
        public virtual Decimal BGYR { get; set; }
        public virtual Decimal EDYR { get; set; }
        public virtual Decimal STTYRNUM { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

