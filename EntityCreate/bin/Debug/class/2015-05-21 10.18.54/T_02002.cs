using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class T_02002
    {
        public virtual Decimal ID { get; set; }
        public virtual String NAME { get; set; }
        public virtual Decimal AREA { get; set; }
        public virtual String BOX { get; set; }
        public virtual String CODE { get; set; }
        public virtual Decimal LEVEL1 { get; set; }
        public virtual Decimal PCOUNT { get; set; }
        public virtual String COORDINATES { get; set; }
    }
}

