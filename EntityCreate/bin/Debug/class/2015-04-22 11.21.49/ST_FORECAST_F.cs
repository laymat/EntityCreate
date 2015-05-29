using System;

namespace 
{
    [Serializable]
    public class ST_FORECAST_F
    {
        public virtual String STCD { get; set; }
        public virtual String UNITNAME { get; set; }
        public virtual String PLCD { get; set; }
        public virtual DateTime FYMDH { get; set; }
        public virtual DateTime IYMDH { get; set; }
        public virtual DateTime YMDH { get; set; }
        public virtual Decimal Z { get; set; }
        public virtual Decimal Q { get; set; }
    }
}

