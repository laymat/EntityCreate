using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_DAYEV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String EPTP { get; set; }
        public virtual Decimal DYE { get; set; }
    }
}

