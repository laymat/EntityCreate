using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_ENNMCD_D
    {
        public virtual String ENNMCD { get; set; }
        public virtual String BSNM { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

