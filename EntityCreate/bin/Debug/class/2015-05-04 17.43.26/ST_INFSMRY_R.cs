using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_INFSMRY_R
    {
        public virtual String PRFIXNO { get; set; }
        public virtual String STCD { get; set; }
        public virtual DateTime INFODT { get; set; }
        public virtual DateTime INTODT { get; set; }
        public virtual DateTime RECVDT { get; set; }
        public virtual DateTime PROCDT { get; set; }
        public virtual String INFOTY { get; set; }
        public virtual String MODIFY { get; set; }
    }
}

