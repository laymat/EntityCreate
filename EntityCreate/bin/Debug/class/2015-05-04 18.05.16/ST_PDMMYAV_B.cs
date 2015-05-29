using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_PDMMYAV_B
    {
        public virtual String STCD { get; set; }
        public virtual String SRNO { get; set; }
        public virtual Int32 MNTH { get; set; }
        public virtual Int32 PRDTP { get; set; }
        public virtual Double MYAVP { get; set; }
    }
}

