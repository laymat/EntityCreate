using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_RSVR_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal RZ { get; set; }
        public virtual Decimal INQ { get; set; }
        public virtual Decimal W { get; set; }
        public virtual Decimal OTQ { get; set; }
        public virtual String RWCHRCD { get; set; }
        public virtual String RWPTN { get; set; }
        public virtual Decimal INQDR { get; set; }
        public virtual String MSQMT { get; set; }
        public virtual Decimal BLRZ { get; set; }
    }
}

