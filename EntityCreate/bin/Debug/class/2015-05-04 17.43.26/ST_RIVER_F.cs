using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_RIVER_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Double FZ { get; set; }
        public virtual Double FQ { get; set; }
        public virtual String WPTN { get; set; }
        public virtual String FLWCHRCD { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
        public virtual Double ANTRNF { get; set; }
        public virtual Double BSAVP { get; set; }
        public virtual String FCCD { get; set; }
    }
}

