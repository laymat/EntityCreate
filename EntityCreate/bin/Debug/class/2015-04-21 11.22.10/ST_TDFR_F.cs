using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_TDFR_F
    {
        public virtual String STCD { get; set; }
        public virtual String UNITNAME { get; set; }
        public virtual String PLCD { get; set; }
        public virtual DateTime FYMDH { get; set; }
        public virtual DateTime IYMDH { get; set; }
        public virtual DateTime YMDH { get; set; }
        public virtual Decimal TDZ { get; set; }
        public virtual Decimal STRMSRG { get; set; }
        public virtual String HLTDMK { get; set; }
    }
}

