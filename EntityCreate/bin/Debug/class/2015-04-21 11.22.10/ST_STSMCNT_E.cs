using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_STSMCNT_E
    {
        public virtual String INSTCD { get; set; }
        public virtual String STCD { get; set; }
        public virtual DateTime COUNTDAY { get; set; }
        public virtual String INFSTATUS { get; set; }
        public virtual String INFTYPE { get; set; }
        public virtual String FRGRD { get; set; }
        public virtual Decimal ICNT { get; set; }
        public virtual Decimal UCNT { get; set; }
        public virtual Decimal DCNT { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

