using System;

namespace 
{
    [Serializable]
    public class ST_PMEVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual Decimal PPUPHTZ { get; set; }
        public virtual Decimal PPUPLTZ { get; set; }
        public virtual Decimal PPDWHTZ { get; set; }
        public virtual Decimal PPDWLTZ { get; set; }
        public virtual Decimal MXPPQ { get; set; }
        public virtual Decimal MNPPQ { get; set; }
        public virtual Decimal MXDNQ { get; set; }
        public virtual Decimal MNDNQ { get; set; }
        public virtual DateTime PPUPHTZTM { get; set; }
        public virtual DateTime PPUPLTZTM { get; set; }
        public virtual DateTime PPDWHTZTM { get; set; }
        public virtual DateTime PPDWLTZTM { get; set; }
        public virtual DateTime MXPPQTM { get; set; }
        public virtual DateTime MNPPQTM { get; set; }
        public virtual DateTime MXDNQTM { get; set; }
        public virtual DateTime MNDNQTM { get; set; }
    }
}

