using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_STORM_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal STRMDR { get; set; }
        public virtual Double STRMP { get; set; }
        public virtual String WTH { get; set; }
    }
}

