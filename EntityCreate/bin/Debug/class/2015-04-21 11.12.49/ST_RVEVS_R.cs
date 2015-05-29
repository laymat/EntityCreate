using System;

namespace 
{
    [Serializable]
    public class ST_RVEVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal HTZ { get; set; }
        public virtual Decimal LTZ { get; set; }
        public virtual Decimal MXQ { get; set; }
        public virtual Decimal MNQ { get; set; }
        public virtual DateTime HTZTM { get; set; }
        public virtual DateTime LTZTM { get; set; }
        public virtual DateTime MXQTM { get; set; }
        public virtual DateTime MNQTM { get; set; }
    }
}

