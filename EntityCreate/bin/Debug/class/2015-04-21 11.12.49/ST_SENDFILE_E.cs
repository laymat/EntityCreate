using System;

namespace 
{
    [Serializable]
    public class ST_SENDFILE_E
    {
        public virtual Decimal SFNUM { get; set; }
        public virtual String INSTCD { get; set; }
        public virtual String SENDTYPE { get; set; }
        public virtual String SENDSTATUS { get; set; }
        public virtual String SFILENAME { get; set; }
        public virtual DateTime SENDTM { get; set; }
        public virtual Decimal SENDCOUNT { get; set; }
        public virtual Decimal ERRLINE { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

