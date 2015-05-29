using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_WASRL_B
    {
        public virtual String STCD { get; set; }
        public virtual String RLSTCD { get; set; }
        public virtual String RLMRK { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

