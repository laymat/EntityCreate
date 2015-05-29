using System;

namespace 
{
    [Serializable]
    public class ST_FFRAR_B
    {
        public virtual String STCD { get; set; }
        public virtual Decimal TPCYR { get; set; }
        public virtual Decimal RCINT { get; set; }
        public virtual Decimal Q { get; set; }
        public virtual Decimal Z { get; set; }
        public virtual Decimal W1 { get; set; }
        public virtual Decimal W3 { get; set; }
        public virtual Decimal W5 { get; set; }
        public virtual Decimal W7 { get; set; }
        public virtual Decimal W10 { get; set; }
        public virtual Decimal W15 { get; set; }
        public virtual Decimal W30 { get; set; }
        public virtual Decimal W60 { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

