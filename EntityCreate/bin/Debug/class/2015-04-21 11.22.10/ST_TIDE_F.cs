using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_TIDE_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Double FTDZ { get; set; }
        public virtual String TDPTN { get; set; }
        public virtual String TDCHRCD { get; set; }
        public virtual Double STRMSRG { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
        public virtual String FCCD { get; set; }
    }
}

