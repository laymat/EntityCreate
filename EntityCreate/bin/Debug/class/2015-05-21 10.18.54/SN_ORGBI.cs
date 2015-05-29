using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_ORGBI
    {
        public virtual String ORGCD { get; set; }
        public virtual String ORGNM { get; set; }
        public virtual Decimal SN { get; set; }
        public virtual Decimal TYPE { get; set; }
    }
}

