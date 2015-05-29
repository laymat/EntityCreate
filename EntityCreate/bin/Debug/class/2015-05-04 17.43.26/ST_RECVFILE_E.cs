using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_RECVFILE_E
    {
        public virtual Decimal RFNUM { get; set; }
        public virtual String INSTCD { get; set; }
        public virtual String RECVTYPE { get; set; }
        public virtual String RECVSTATUS { get; set; }
        public virtual String RFILENAME { get; set; }
        public virtual DateTime RECVTM { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}
