using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_SNOW_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal SNOWDEP { get; set; }
        public virtual Decimal SNOWDEN { get; set; }
    }
}

