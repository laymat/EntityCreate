using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_RNPER
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual Decimal EPEL { get; set; }
        public virtual Decimal MYAVP { get; set; }
        public virtual Decimal OBSMXYP { get; set; }
        public virtual Decimal MXYPYR { get; set; }
    }
}

