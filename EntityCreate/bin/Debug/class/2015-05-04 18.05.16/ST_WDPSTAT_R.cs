using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_WDPSTAT_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal PPTMS { get; set; }
        public virtual Double ACCPW { get; set; }
        public virtual Decimal PPHRS { get; set; }
        public virtual Decimal DRNTMS { get; set; }
        public virtual Double ACCDW { get; set; }
        public virtual Decimal DRNHRS { get; set; }
    }
}

