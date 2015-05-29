using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_SENDDO_E
    {
        public virtual Decimal SLSH { get; set; }
        public virtual String STCD { get; set; }
        public virtual String TABID { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String EXCKEY { get; set; }
        public virtual String OPERATION { get; set; }
        public virtual String EXCINF { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

