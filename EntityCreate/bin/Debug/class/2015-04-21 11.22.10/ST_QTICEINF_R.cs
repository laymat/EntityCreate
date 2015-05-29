using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_QTICEINF_R
    {
        public virtual String STCD { get; set; }
        public virtual DateTime TM { get; set; }
        public virtual String EXKEY { get; set; }
        public virtual String QNTICD { get; set; }
        public virtual String RLPSTN { get; set; }
        public virtual Decimal RLDSTN { get; set; }
        public virtual Decimal LBDIWD { get; set; }
        public virtual Decimal RBDIWD { get; set; }
        public virtual Decimal BDITHK { get; set; }
        public virtual Decimal IRCON { get; set; }
        public virtual Decimal DITHK { get; set; }
        public virtual Decimal MXIA { get; set; }
        public virtual Decimal MXIV { get; set; }
        public virtual Decimal IQ { get; set; }
        public virtual String FRZPROP { get; set; }
        public virtual String BRKPROP { get; set; }
        public virtual Decimal DIPCK { get; set; }
        public virtual String IDAMGRW { get; set; }
        public virtual Decimal IDAMHGT { get; set; }
        public virtual Decimal IDAMWD { get; set; }
        public virtual Decimal IDAMUPZ { get; set; }
        public virtual String IDAMUPWPTN { get; set; }
        public virtual String ELTY { get; set; }
        public virtual String IQPROP { get; set; }
    }
}

