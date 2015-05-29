using System;

namespace 
{
    [Serializable]
    public class ST_RVSECT_B
    {
        public virtual String STCD { get; set; }
        public virtual DateTime MSTM { get; set; }
        public virtual Decimal VTNO { get; set; }
        public virtual Decimal DI { get; set; }
        public virtual Decimal ZB { get; set; }
        public virtual String BGBK { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

