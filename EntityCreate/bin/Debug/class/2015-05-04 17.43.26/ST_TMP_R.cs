using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_TMP_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal ATMP { get; set; }
        public virtual Decimal WTMP { get; set; }
    }
}

