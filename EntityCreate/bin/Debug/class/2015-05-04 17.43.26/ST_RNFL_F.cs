using System;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ST_RNFL_F
    {
        public virtual String FAREACD { get; set; }
        public virtual DateTime FTM { get; set; }
        public virtual Int32 FP { get; set; }
        public virtual Int32 FPDR { get; set; }
        public virtual String FRNTDCD { get; set; }
        public virtual DateTime FDT { get; set; }
        public virtual DateTime RLSTM { get; set; }
        public virtual String RLSINSTCD { get; set; }
        public virtual DateTime REFTM { get; set; }
    }
}

