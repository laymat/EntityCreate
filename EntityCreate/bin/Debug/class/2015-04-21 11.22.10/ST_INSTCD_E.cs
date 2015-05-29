using System;

namespace ConsoleApplication1.model
{
    [Serializable]
    public class ST_INSTCD_E
    {
        public virtual String INSTCD { get; set; }
        public virtual String INSTNM { get; set; }
        public virtual String EXCTYPE { get; set; }
        public virtual String EXCIP { get; set; }
        public virtual Decimal EXCPORT { get; set; }
        public virtual String EXCSRV { get; set; }
        public virtual String WEBURL { get; set; }
        public virtual String PASSWORD { get; set; }
        public virtual String ISSTARTS { get; set; }
        public virtual DateTime MODITIME { get; set; }
    }
}

