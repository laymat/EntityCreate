using System;

namespace 
{
    [Serializable]
    public class ST_RVDMMYSQ_S
    {
        public virtual String STCD { get; set; }
        public virtual Decimal YR { get; set; }
        public virtual Decimal MNTH { get; set; }
        public virtual Decimal PRDTP { get; set; }
        public virtual Decimal AVZ { get; set; }
        public virtual Decimal AVQ { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

