using System;

namespace 
{
    [Serializable]
    public class ST_WDWV_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal WNDPWR { get; set; }
        public virtual Decimal WNDV { get; set; }
        public virtual String WNDDIR { get; set; }
        public virtual Decimal WVHGT { get; set; }
    }
}

