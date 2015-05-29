using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_REGLAT_F
    {
        public virtual String STCD { get; set; }
        public virtual String UNITNAME { get; set; }
        public virtual String PLCD { get; set; }
        public virtual DateTime FYMDH { get; set; }
        public virtual DateTime IYMDH { get; set; }
        public virtual DateTime YMDH { get; set; }
        public virtual Decimal Z { get; set; }
        public virtual Decimal W { get; set; }
        public virtual Decimal OTQ { get; set; }
    }
}

