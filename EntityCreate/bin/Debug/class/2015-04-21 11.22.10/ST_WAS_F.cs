using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_WAS_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Double FUPZ { get; set; }
        public virtual Double FTGTQ { get; set; }
        public virtual String SUPWPTN { get; set; }
        public virtual String SWCHRCD { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
        public virtual String FCCD { get; set; }
    }
}

