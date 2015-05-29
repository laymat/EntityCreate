using System;

namespace 
{
    [Serializable]
    public class ST_SEDRF_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Double FWRNF { get; set; }
        public virtual Double FSEDRNF { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
    }
}

