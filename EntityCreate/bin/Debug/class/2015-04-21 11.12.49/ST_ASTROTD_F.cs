using System;

namespace 
{
    [Serializable]
    public class ST_ASTROTD_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime YMDH { get; set; }
        public virtual Decimal TDZ { get; set; }
    }
}

