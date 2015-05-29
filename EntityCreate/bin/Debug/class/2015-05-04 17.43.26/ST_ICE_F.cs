using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_ICE_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual String FICD { get; set; }
        public virtual String FIRPSTN { get; set; }
        public virtual Double FRLDSTN { get; set; }
        public virtual Double FITHK { get; set; }
        public virtual String ITHKCD { get; set; }
        public virtual Double FIQ { get; set; }
        public virtual String IQPROP { get; set; }
        public virtual DateTime FDT { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
    }
}

