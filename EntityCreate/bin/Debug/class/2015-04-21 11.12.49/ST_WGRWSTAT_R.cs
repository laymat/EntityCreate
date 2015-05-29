using System;

namespace 
{
    [Serializable]
    public class ST_WGRWSTAT_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal ACCGDW { get; set; }
    }
}

