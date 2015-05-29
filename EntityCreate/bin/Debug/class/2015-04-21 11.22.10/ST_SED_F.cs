using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_SED_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Double FS { get; set; }
        public virtual String SCHRCD { get; set; }
        public virtual DateTime FDT { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
    }
}

