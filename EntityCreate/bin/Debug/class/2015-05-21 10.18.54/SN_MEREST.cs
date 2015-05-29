using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_MEREST
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual String MEAITEM { get; set; }
        public virtual String MEAST { get; set; }
        public virtual String RESST { get; set; }
    }
}

