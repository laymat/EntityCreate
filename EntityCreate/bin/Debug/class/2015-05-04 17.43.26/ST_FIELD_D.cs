using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_FIELD_D
    {
        public virtual String TABID { get; set; }
        public virtual String FLID { get; set; }
        public virtual Decimal FLSID { get; set; }
        public virtual String FLCN { get; set; }
        public virtual String FLEN { get; set; }
        public virtual String FLTL { get; set; }
        public virtual String NLAT { get; set; }
        public virtual String UNNM { get; set; }
        public virtual String FCHSC { get; set; }
        public virtual String EUFL { get; set; }
        public virtual String PKAT { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

