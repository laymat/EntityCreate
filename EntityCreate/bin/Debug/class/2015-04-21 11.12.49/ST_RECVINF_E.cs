using System;

namespace 
{
    [Serializable]
    public class ST_RECVINF_E
    {
        public virtual Decimal RLSH { get; set; }
        public virtual Decimal RFNUM { get; set; }
        public virtual String INSTCD { get; set; }
        public virtual Decimal SLSH { get; set; }
        public virtual String STCD { get; set; }
        public virtual String TABID { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String EXCKEY { get; set; }
        public virtual String OPERATION { get; set; }
        public virtual String EXCINF { get; set; }
        public virtual String INSTOSTATUS { get; set; }
        public virtual DateTime INSTOTM { get; set; }
        public virtual String ERRINF { get; set; }
        public virtual DateTime MANUALTM { get; set; }
        public virtual String STAT { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

