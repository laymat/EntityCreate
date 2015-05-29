using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_ZVARL_B
    {
        public virtual String STCD { get; set; }
        public virtual DateTime MSTM { get; set; }
        public virtual Decimal RZ { get; set; }
        public virtual Decimal W { get; set; }
        public virtual Decimal WSFA { get; set; }
        public virtual Decimal PTNO { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

