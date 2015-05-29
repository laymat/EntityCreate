using System;

namespace 
{
    [Serializable]
    public class ST_ERRINF_R
    {
        public virtual String PRFIXNO { get; set; }
        public virtual String STCD { get; set; }
        public virtual DateTime PROCDT { get; set; }
        public virtual String MDFMK { get; set; }
        public virtual String ERRMAIN { get; set; }
        public virtual String ERRCD { get; set; }
        public virtual Int32 ERRPSTN { get; set; }
        public virtual String ERRTEXT { get; set; }
        public virtual String UID { get; set; }
        public virtual DateTime MODIFYDT { get; set; }
    }
}

