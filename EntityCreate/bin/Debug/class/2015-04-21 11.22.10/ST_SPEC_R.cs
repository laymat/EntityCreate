using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_SPEC_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String TPCD { get; set; }
        public virtual String PSTNCD { get; set; }
        public virtual Double RLDSTN { get; set; }
        public virtual Double DEPTH { get; set; }
        public virtual Double HEIGHT { get; set; }
        public virtual Double WIDTH { get; set; }
        public virtual Double Q { get; set; }
        public virtual String MSQMT { get; set; }
        public virtual String RSVRTP { get; set; }
    }
}

