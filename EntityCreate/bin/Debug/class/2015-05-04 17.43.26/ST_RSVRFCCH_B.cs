using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_RSVRFCCH_B
    {
        public virtual String STCD { get; set; }
        public virtual Decimal DAMEL { get; set; }
        public virtual Decimal CKFLZ { get; set; }
        public virtual Decimal DSFLZ { get; set; }
        public virtual Decimal NORMZ { get; set; }
        public virtual Decimal DDZ { get; set; }
        public virtual Decimal ACTZ { get; set; }
        public virtual Decimal TTCP { get; set; }
        public virtual Decimal FLDCP { get; set; }
        public virtual Decimal ACTCP { get; set; }
        public virtual Decimal DDCP { get; set; }
        public virtual Decimal HHRZ { get; set; }
        public virtual DateTime HHRZTM { get; set; }
        public virtual Decimal HMXINQ { get; set; }
        public virtual Decimal RSTDR { get; set; }
        public virtual DateTime HMXINQTM { get; set; }
        public virtual Decimal HMXW { get; set; }
        public virtual DateTime HMXWTM { get; set; }
        public virtual Double RHMXOTQ { get; set; }
        public virtual DateTime RHMXOTQTM { get; set; }
        public virtual String RSVRTP { get; set; }
        public virtual Decimal HMXOTQ { get; set; }
        public virtual DateTime HMXOTQTM { get; set; }
        public virtual Decimal HLRZ { get; set; }
        public virtual DateTime HLRZTM { get; set; }
        public virtual Decimal HMNINQ { get; set; }
        public virtual DateTime HMNINQTM { get; set; }
        public virtual Decimal LAZ { get; set; }
        public virtual Decimal SFQ { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

