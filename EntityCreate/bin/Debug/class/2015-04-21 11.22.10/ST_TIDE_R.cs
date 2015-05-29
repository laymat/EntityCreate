using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_TIDE_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal TDZ { get; set; }
        public virtual Decimal AIRP { get; set; }
        public virtual String TDCHRCD { get; set; }
        public virtual String TDPTN { get; set; }
        public virtual String HLTDMK { get; set; }
    }
}

