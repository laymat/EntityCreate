using System;

namespace 
{
    [Serializable]
    public class ST_FORECASTC_F
    {
        public virtual String STCD { get; set; }
        public virtual String UNITNAME { get; set; }
        public virtual String PLCD { get; set; }
        public virtual DateTime FYMDH { get; set; }
        public virtual DateTime IYMDH { get; set; }
        public virtual String WNSTATUS { get; set; }
        public virtual String COMMENTS { get; set; }
    }
}

