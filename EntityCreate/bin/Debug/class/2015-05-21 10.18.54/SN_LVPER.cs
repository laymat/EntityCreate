using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_LVPER
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual Decimal OBSHTZ { get; set; }
        public virtual String HTZTM { get; set; }
        public virtual Decimal OBSLTZ { get; set; }
        public virtual String MNZTM { get; set; }
        public virtual String DRTM { get; set; }
        public virtual Decimal DRD { get; set; }
    }
}

