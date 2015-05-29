using System;

namespace 
{
    [Serializable]
    public class ST_RSVR_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Double FRZ { get; set; }
        public virtual Double FINQ { get; set; }
        public virtual Double FW { get; set; }
        public virtual Double FOTQ { get; set; }
        public virtual String RWPTN { get; set; }
        public virtual String RWCHRCD { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
        public virtual String FCCD { get; set; }
    }
}

