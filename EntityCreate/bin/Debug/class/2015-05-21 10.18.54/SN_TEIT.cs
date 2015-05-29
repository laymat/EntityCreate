using System;

namespace LN_SYQINFO_DB.Model
{
    [Serializable]
    public class SN_TEIT
    {
        public virtual String STID { get; set; }
        public virtual String STCD { get; set; }
        public virtual String STRFLW { get; set; }
        public virtual String EVAP { get; set; }
        public virtual String MEME { get; set; }
        public virtual String GRDWAT { get; set; }
        public virtual String OTHER { get; set; }
        public virtual String BASEGAUG { get; set; }
    }
}

