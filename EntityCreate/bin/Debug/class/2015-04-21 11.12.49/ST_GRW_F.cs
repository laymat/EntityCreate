using System;

namespace 
{
    [Serializable]
    public class ST_GRW_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Double FGWBD { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
    }
}

