using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_RSVRMYAV_B
    {
        public virtual String STCD { get; set; }
        public virtual String SRNO { get; set; }
        public virtual String MTHDY { get; set; }
        public virtual Double MYRAVW { get; set; }
    }
}

