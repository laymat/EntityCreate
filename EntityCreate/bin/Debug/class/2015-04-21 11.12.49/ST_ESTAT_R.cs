using System;

namespace 
{
    [Serializable]
    public class ST_ESTAT_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal ACCE { get; set; }
    }
}

