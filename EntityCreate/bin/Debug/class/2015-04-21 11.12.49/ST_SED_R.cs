using System;

namespace 
{
    [Serializable]
    public class ST_SED_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal S { get; set; }
        public virtual String SCHRCD { get; set; }
        public virtual String SMT { get; set; }
    }
}

