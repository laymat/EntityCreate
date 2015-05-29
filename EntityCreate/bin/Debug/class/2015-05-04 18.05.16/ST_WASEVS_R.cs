using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_WASEVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal HTUPZ { get; set; }
        public virtual Decimal LTUPZ { get; set; }
        public virtual Decimal MXGTQ { get; set; }
        public virtual Decimal MNGTQ { get; set; }
        public virtual Decimal HTDWZ { get; set; }
        public virtual Decimal LTDWZ { get; set; }
        public virtual DateTime HTUPZTM { get; set; }
        public virtual DateTime LTUPZTM { get; set; }
        public virtual DateTime MXGTQTM { get; set; }
        public virtual DateTime MNGTQTM { get; set; }
        public virtual DateTime HTDWZTM { get; set; }
        public virtual DateTime LTDWZTM { get; set; }
    }
}

