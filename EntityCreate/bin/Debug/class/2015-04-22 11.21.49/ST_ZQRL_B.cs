using System;

namespace 
{
    [Serializable]
    public class ST_ZQRL_B
    {
        public virtual String STCD { get; set; }
        public virtual DateTime BGTM { get; set; }
        public virtual Decimal PTNO { get; set; }
        public virtual Decimal Z { get; set; }
        public virtual Decimal Q { get; set; }
        public virtual String LNNM { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

