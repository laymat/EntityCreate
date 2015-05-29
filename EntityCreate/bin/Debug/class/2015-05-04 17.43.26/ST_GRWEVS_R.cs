using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_GRWEVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal MXBD { get; set; }
        public virtual Decimal MNBD { get; set; }
        public virtual Decimal MXSPQ { get; set; }
        public virtual Decimal MNSPQ { get; set; }
        public virtual Decimal MXGWTMP { get; set; }
        public virtual Decimal MNGWTMP { get; set; }
        public virtual DateTime MXBDTM { get; set; }
        public virtual DateTime MNBDTM { get; set; }
        public virtual DateTime MXSPQTM { get; set; }
        public virtual DateTime MNSPQTM { get; set; }
        public virtual DateTime MXGWTMPTM { get; set; }
        public virtual DateTime MNGWTMPTM { get; set; }
    }
}

