using System;

namespace 
{
    [Serializable]
    public class ST_SENDTO_E
    {
        public virtual String INSTCD { get; set; }
        public virtual Decimal SLSH { get; set; }
        public virtual Decimal SFNUM { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String SENDSTATUS { get; set; }
        public virtual String STAT { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

