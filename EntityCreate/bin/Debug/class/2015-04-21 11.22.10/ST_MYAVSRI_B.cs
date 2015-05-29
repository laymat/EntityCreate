using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_MYAVSRI_B
    {
        public virtual String STCD { get; set; }
        public virtual String SRNO { get; set; }
        public virtual String ACTFLG { get; set; }
        public virtual Int32 BGYR { get; set; }
        public virtual Int32 EDYR { get; set; }
        public virtual Int32 STTYRNUM { get; set; }
    }
}

