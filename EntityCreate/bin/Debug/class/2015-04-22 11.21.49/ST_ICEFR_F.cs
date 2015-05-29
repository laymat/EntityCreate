using System;

namespace 
{
    [Serializable]
    public class ST_ICEFR_F
    {
        public virtual String STCD { get; set; }
        public virtual String UNITNAME { get; set; }
        public virtual String PLCD { get; set; }
        public virtual DateTime FYMDH { get; set; }
        public virtual DateTime IYMDH { get; set; }
        public virtual DateTime YMDH { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual String FICD { get; set; }
        public virtual String FIRPSTN { get; set; }
        public virtual Decimal FRLDSTN { get; set; }
        public virtual Decimal FITHK { get; set; }
        public virtual String ITHKCD { get; set; }
        public virtual Decimal FIQ { get; set; }
        public virtual String IQPROP { get; set; }
    }
}

