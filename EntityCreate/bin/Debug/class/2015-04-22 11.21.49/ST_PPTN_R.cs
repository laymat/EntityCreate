using System;

namespace 
{
    [Serializable]
    public class ST_PPTN_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal DRP { get; set; }
        public virtual Decimal INTV { get; set; }
        public virtual Decimal PDR { get; set; }
        public virtual Decimal DYP { get; set; }
        public virtual String WTH { get; set; }
    }
}

