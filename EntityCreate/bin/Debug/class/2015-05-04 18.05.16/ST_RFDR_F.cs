using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_RFDR_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Double FRNF { get; set; }
        public virtual Double FRNFDR { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual String DPNDST { get; set; }
        public virtual DateTime REFTM { get; set; }
    }
}

