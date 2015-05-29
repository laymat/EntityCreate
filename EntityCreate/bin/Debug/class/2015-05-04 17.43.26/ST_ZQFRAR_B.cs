using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_ZQFRAR_B
    {
        public virtual String STCD { get; set; }
        public virtual Int32 TPCYR { get; set; }
        public virtual Int32 RCINT { get; set; }
        public virtual Double Q { get; set; }
        public virtual Double Z { get; set; }
        public virtual Double W1 { get; set; }
        public virtual Double W3 { get; set; }
        public virtual Double W5 { get; set; }
        public virtual Double W7 { get; set; }
        public virtual Double W10 { get; set; }
        public virtual Double W15 { get; set; }
        public virtual Double W30 { get; set; }
        public virtual Double W60 { get; set; }
    }
}

