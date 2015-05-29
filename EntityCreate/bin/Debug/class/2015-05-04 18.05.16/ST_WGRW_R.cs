using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_WGRW_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal WLMIN { get; set; }
        public virtual String WLMINMT { get; set; }
    }
}

