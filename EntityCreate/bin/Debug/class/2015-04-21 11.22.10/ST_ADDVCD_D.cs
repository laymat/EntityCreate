using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_ADDVCD_D
    {
        public virtual String ADDVCD { get; set; }
        public virtual String ADDVNM { get; set; }
        public virtual String COMMENTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

