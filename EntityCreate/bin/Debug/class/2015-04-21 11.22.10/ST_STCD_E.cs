using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_STCD_E
    {
        public virtual String INSTCD { get; set; }
        public virtual String STCD { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

