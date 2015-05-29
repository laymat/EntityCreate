using System;

namespace 
{
    [Serializable]
    public class ST_TIDEAV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal AVHTDZ { get; set; }
        public virtual Decimal AVLTDZ { get; set; }
    }
}

