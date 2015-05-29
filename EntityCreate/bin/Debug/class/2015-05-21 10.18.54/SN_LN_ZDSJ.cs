using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_LN_ZDSJ
    {
        public virtual Decimal ID { get; set; }
        public virtual String NAME { get; set; }
        public virtual String ADDVCD { get; set; }
        public virtual String LGTD { get; set; }
        public virtual String LTTD { get; set; }
        public virtual String CITYLEVEL { get; set; }
        public virtual String SHOWLEVEL { get; set; }
    }
}

