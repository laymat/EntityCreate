using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_SOIL_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual Decimal VTAVSLM { get; set; }
        public virtual Decimal SRLSLM { get; set; }
        public virtual Decimal SLM10 { get; set; }
        public virtual Decimal SLM20 { get; set; }
        public virtual Decimal SLM30 { get; set; }
        public virtual Decimal SLM40 { get; set; }
        public virtual Double SLM50 { get; set; }
        public virtual Decimal SLM60 { get; set; }
        public virtual Double SLM70 { get; set; }
        public virtual Decimal SLM80 { get; set; }
        public virtual Double SLM90 { get; set; }
        public virtual Decimal SLM100 { get; set; }
        public virtual Double SLM110 { get; set; }
        public virtual String CRPTY { get; set; }
        public virtual String CRPGRWPRD { get; set; }
        public virtual String HITRSN { get; set; }
        public virtual String HITEXT { get; set; }
        public virtual String SLTP { get; set; }
        public virtual Int32 DRSLD { get; set; }
        public virtual Int32 IRRINTV { get; set; }
        public virtual Int32 PINTV { get; set; }
        public virtual String SLMMMT { get; set; }
    }
}

