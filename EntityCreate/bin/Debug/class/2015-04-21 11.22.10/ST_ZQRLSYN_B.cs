using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_ZQRLSYN_B
    {
        public virtual String STCD { get; set; }
        public virtual Int32 YR { get; set; }
        public virtual Int32 PTNO { get; set; }
        public virtual Double Z { get; set; }
        public virtual Double Q { get; set; }
    }
}

