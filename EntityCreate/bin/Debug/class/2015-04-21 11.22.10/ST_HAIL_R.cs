using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_HAIL_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual Decimal HPD { get; set; }
        public virtual Decimal HLDR { get; set; }
    }
}

