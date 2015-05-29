using System;

namespace 
{
    [Serializable]
    public class ST_FRAPAR_B
    {
        public virtual String STCD { get; set; }
        public virtual Decimal TPCYR { get; set; }
        public virtual Decimal AVRG { get; set; }
        public virtual String VARTP { get; set; }
        public virtual Decimal CV { get; set; }
        public virtual Decimal CS { get; set; }
        public virtual Decimal BGYR { get; set; }
        public virtual Decimal EDYR { get; set; }
        public virtual Decimal SPNUM { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

