using System;

namespace 
{
    [Serializable]
    public class ST_WAS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal UPZ { get; set; }
        public virtual Decimal DWZ { get; set; }
        public virtual Decimal TGTQ { get; set; }
        public virtual String SWCHRCD { get; set; }
        public virtual String SUPWPTN { get; set; }
        public virtual String SDWWPTN { get; set; }
        public virtual String MSQMT { get; set; }
    }
}

