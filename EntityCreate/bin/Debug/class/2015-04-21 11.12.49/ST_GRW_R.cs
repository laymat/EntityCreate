using System;

namespace 
{
    [Serializable]
    public class ST_GRW_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal GWBD { get; set; }
        public virtual String GWBDRMK { get; set; }
        public virtual Decimal SPQ { get; set; }
        public virtual Decimal GWTMP { get; set; }
        public virtual String GWPTN { get; set; }
        public virtual String SPQMMT { get; set; }
    }
}

