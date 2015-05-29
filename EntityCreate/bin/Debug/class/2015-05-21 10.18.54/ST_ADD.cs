using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class ST_ADD
    {
        public virtual String ID { get; set; }
        public virtual String STNM { get; set; }
        public virtual String STTP { get; set; }
        public virtual Decimal LGTD { get; set; }
        public virtual Decimal LTTD { get; set; }
        public virtual String STCD { get; set; }
        public virtual String CITY { get; set; }
        public virtual String COUNTY { get; set; }
    }
}

