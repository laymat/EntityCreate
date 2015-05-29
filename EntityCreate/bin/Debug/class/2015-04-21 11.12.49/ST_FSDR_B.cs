using System;

namespace 
{
    [Serializable]
    public class ST_FSDR_B
    {
        public virtual String UPSTCD { get; set; }
        public virtual String DWSTCD { get; set; }
        public virtual Decimal RCHLEN { get; set; }
        public virtual Decimal SFTQ { get; set; }
        public virtual Decimal QMGN { get; set; }
        public virtual Decimal MNTRTM { get; set; }
        public virtual Decimal MXTRTM { get; set; }
        public virtual Decimal AVTRTM { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

