using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_PUMP_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal PPUPZ { get; set; }
        public virtual Decimal PPDWZ { get; set; }
        public virtual Decimal OMCN { get; set; }
        public virtual Decimal OMPWR { get; set; }
        public virtual Decimal PMPQ { get; set; }
        public virtual String PPWCHRCD { get; set; }
        public virtual String PPUPWPTN { get; set; }
        public virtual String PPDWWPTN { get; set; }
        public virtual String MSQMT { get; set; }
        public virtual String PDCHCD { get; set; }
    }
}

