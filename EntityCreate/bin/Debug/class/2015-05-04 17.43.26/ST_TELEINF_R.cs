using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_TELEINF_R
    {
        public virtual String PRFIXNO { get; set; }
        public virtual DateTime PROCDT { get; set; }
        public virtual String TELE { get; set; }
    }
}

