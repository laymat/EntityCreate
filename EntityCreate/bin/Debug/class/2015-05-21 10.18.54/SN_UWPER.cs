using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_UWPER
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual Decimal IWD { get; set; }
        public virtual String WLTP { get; set; }
        public virtual String GWTP { get; set; }
        public virtual String GWCON { get; set; }
        public virtual String GWITEM { get; set; }
    }
}

