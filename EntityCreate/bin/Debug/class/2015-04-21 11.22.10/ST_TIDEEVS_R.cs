using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_TIDEEVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal HTTDZ { get; set; }
        public virtual Decimal LTTDZ { get; set; }
        public virtual Decimal MXWNDV { get; set; }
        public virtual DateTime HTTDZTM { get; set; }
        public virtual DateTime LTTDZTM { get; set; }
        public virtual DateTime MXWNDVTM { get; set; }
    }
}

