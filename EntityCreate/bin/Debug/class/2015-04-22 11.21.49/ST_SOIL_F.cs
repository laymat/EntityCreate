using System;

namespace 
{
    [Serializable]
    public class ST_SOIL_F
    {
        public virtual String STCD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual Double FAVSLM { get; set; }
        public virtual Double FSFLSLM { get; set; }
        public virtual Double FSLM10 { get; set; }
        public virtual Double FSLM20 { get; set; }
        public virtual Double FSLM30 { get; set; }
        public virtual Double FSLM40 { get; set; }
        public virtual Double FSLM50 { get; set; }
        public virtual Double FSLM60 { get; set; }
        public virtual Double FSLM70 { get; set; }
        public virtual Double FSLM80 { get; set; }
        public virtual Double FSLM90 { get; set; }
        public virtual Double FSLM100 { get; set; }
        public virtual Double FSLM110 { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
    }
}

