using System;

namespace 
{
    [Serializable]
    public class ST_RSVREVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal HTRZ { get; set; }
        public virtual Decimal LTRZ { get; set; }
        public virtual Decimal MXINQ { get; set; }
        public virtual Decimal MNINQ { get; set; }
        public virtual Decimal MXOTQ { get; set; }
        public virtual Decimal MNOTQ { get; set; }
        public virtual Decimal MXW { get; set; }
        public virtual Decimal MNW { get; set; }
        public virtual DateTime HTRZTM { get; set; }
        public virtual DateTime LTRZTM { get; set; }
        public virtual DateTime MXINQTM { get; set; }
        public virtual DateTime MNINQTM { get; set; }
        public virtual DateTime MXOTQTM { get; set; }
        public virtual DateTime MNOTQTM { get; set; }
        public virtual DateTime MXWTM { get; set; }
        public virtual DateTime MNWTM { get; set; }
    }
}

