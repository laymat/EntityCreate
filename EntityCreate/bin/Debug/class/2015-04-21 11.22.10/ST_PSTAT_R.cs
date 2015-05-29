using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_PSTAT_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal ACCP { get; set; }
    }
}

