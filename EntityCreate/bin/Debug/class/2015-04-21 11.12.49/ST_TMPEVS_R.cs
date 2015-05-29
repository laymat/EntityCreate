using System;

namespace 
{
    [Serializable]
    public class ST_TMPEVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal MXATMP { get; set; }
        public virtual Decimal MNATMP { get; set; }
        public virtual Decimal MXWTMP { get; set; }
        public virtual Decimal MNWTMP { get; set; }
        public virtual DateTime MXATMPTM { get; set; }
        public virtual DateTime MNATMPTM { get; set; }
        public virtual DateTime MXWTMPTM { get; set; }
        public virtual DateTime MNWTMPTM { get; set; }
    }
}

