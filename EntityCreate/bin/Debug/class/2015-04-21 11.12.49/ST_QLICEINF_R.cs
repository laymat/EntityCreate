using System;

namespace 
{
    [Serializable]
    public class ST_QLICEINF_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual String QLTICD { get; set; }
        public virtual String RLPSTN { get; set; }
        public virtual Decimal RLDSTN { get; set; }
        public virtual Decimal QLTITHK { get; set; }
        public virtual Decimal IOSNDP { get; set; }
        public virtual Decimal IUDFSTHK { get; set; }
    }
}

