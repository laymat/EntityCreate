using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_TELEINF_R
    {
        public virtual String PRFIXNO { get; set; }
        public virtual DateTime PROCDT { get; set; }
        public virtual String TELE { get; set; }
    }
}

