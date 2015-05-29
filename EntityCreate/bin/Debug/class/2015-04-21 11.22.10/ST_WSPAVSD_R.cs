using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_WSPAVSD_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual Decimal STTDR { get; set; }
        public virtual Decimal DRAVZ { get; set; }
        public virtual Decimal DRAVQ { get; set; }
        public virtual Decimal DRPW { get; set; }
        public virtual Decimal DRDW { get; set; }
    }
}

