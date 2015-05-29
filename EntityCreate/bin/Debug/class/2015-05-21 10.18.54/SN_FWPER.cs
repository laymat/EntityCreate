using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_FWPER
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual Decimal MYAVTR { get; set; }
        public virtual Decimal OBSMXQ { get; set; }
        public virtual String MXQTM { get; set; }
        public virtual Decimal OBSMNQ { get; set; }
        public virtual String MNQTM { get; set; }
    }
}

