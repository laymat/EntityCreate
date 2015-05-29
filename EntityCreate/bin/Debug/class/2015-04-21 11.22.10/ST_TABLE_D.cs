using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_TABLE_D
    {
        public virtual String TABID { get; set; }
        public virtual String TABNO { get; set; }
        public virtual String TABCN { get; set; }
        public virtual String TABEN { get; set; }
        public virtual String EXCHFL { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

