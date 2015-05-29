using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_LINE_DATA
    {
        public virtual Decimal SN_LINE_ID { get; set; }
        public virtual Decimal SN_LINE_LIST_ID { get; set; }
        public virtual String SN_LINE_E { get; set; }
        public virtual String SN_LINE_N { get; set; }
        public virtual Decimal SN_LINE_INDEX { get; set; }
    }
}

