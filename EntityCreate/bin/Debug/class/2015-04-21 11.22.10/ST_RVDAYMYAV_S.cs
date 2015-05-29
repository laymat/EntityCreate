using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_RVDAYMYAV_S
    {
        public virtual String STCD { get; set; }
        public virtual Decimal MNTH { get; set; }
        public virtual Decimal DAY { get; set; }
        public virtual Decimal MYDAVZ { get; set; }
        public virtual Decimal MYDAVQ { get; set; }
        public virtual Decimal BGYR { get; set; }
        public virtual Decimal EDYR { get; set; }
        public virtual Decimal STTYRNUM { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

