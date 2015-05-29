using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class ST_CHGITEM
    {
        public virtual Decimal ID { get; set; }
        public virtual String CHG_ID { get; set; }
        public virtual String FLNM { get; set; }
        public virtual String FLUR { get; set; }
    }
}

