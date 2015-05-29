using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_EQPQEVS_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime IDTM { get; set; }
        public virtual String STTDRCD { get; set; }
        public virtual String EQPTP { get; set; }
        public virtual String EQPNO { get; set; }
        public virtual Int32 MXGTOPNUM { get; set; }
        public virtual Double MXGTOPHGT { get; set; }
        public virtual Double MXGTQ { get; set; }
        public virtual Int32 MNGTOPNUM { get; set; }
        public virtual Double MNGTOPHGT { get; set; }
        public virtual Double MNGTQ { get; set; }
        public virtual DateTime MXGTQTM { get; set; }
        public virtual DateTime MNGTQTM { get; set; }
    }
}

