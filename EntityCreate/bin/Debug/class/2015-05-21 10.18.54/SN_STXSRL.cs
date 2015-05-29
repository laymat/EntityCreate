using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_STXSRL
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual String CRSTID { get; set; }
        public virtual Decimal RLID { get; set; }
        public virtual String RLILL { get; set; }
    }
}

