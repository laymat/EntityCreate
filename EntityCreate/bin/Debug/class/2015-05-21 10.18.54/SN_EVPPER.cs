using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_EVPPER
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual String EPTP { get; set; }
        public virtual Decimal MYAVE { get; set; }
    }
}

