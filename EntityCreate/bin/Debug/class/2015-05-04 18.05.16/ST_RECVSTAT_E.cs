using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_RECVSTAT_E
    {
        public virtual String INSTCD { get; set; }
        public virtual DateTime COUNTDAY { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual String FRGRD { get; set; }
        public virtual String OPERATION { get; set; }
        public virtual String INFTYPE { get; set; }
        public virtual Decimal STCDNUM { get; set; }
        public virtual Decimal INFNUM { get; set; }
        public virtual Decimal COUNTL30 { get; set; }
        public virtual Decimal COUNTB60 { get; set; }
        public virtual Decimal COUNTT60 { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

